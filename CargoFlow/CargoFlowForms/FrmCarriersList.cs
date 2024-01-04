using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Reference to CargoFlowMgmt project to access its classes
using CargoFlowMgmt;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static CargoFlowMgmt.DBConnection;

namespace CargoFlowForms
{
    /// <summary>
    /// Form to display the list of carriers
    /// </summary>
    public partial class FrmCarriersList : Form
    {
        private List<Carrier> carriers = new List<Carrier>();
        private DBConnection? dbConn;

        public FrmCarriersList()
        {
            try
            {
                this.carriers = GetCarriers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des données. Elles pourraient être erronées ou incomplètes.\n\nDétail : \n" + ex.Message);
            }
            InitializeComponent();
        }

        /// <summary>
        /// Get all the carriers from the database and return them as a list of Carrier objects
        /// </summary>
        private List<Carrier> GetCarriers()
        {
            List<Carrier> list = new List<Carrier>();
            dbConn = new DBConnection();
            dbConn.OpenConnection();
            string getAllCarriersQuery = "SELECT id, companyName, loadCapacity, email, phoneNumber FROM carriers";
            List<string[]> records = dbConn.GetAllRecords(getAllCarriersQuery);

            // Double loop reading records
            foreach (string[] record in records)
            {
                // Preparing the parameters for the Carrier constructor
                int id = Int32.Parse(record[0]);
                string name = record[1];
                // If the value is null, we set it to null, else we set it to the value retrieved from the database
                int? capacity;
                if (record[2] == null)
                {
                    capacity = null;
                }
                else
                {
                    capacity = Int32.Parse(record[2]);
                }
                string email = record[3];
                string phoneNumber = record[4];
                // Create the Carrier object
                Carrier carrier = new Carrier(id, name, phoneNumber, email, capacity);
                // Add the Carrier object to the list
                list.Add(carrier);
            }
            dbConn.CloseConnection();
            return list;
        }

        /// <summary>
        /// Fill the DataGridView with the all the carriers
        /// </summary>
        private void FrmCarriersList_Load(object sender, EventArgs e)
        {
            try
            {
                dgvCarriers.DataSource = carriers;
                // Renommage des colonnes. Pourquoi en fonction des propriétés de l'objet Carrier et non pas de ses attributs ? À voir...
                dgvCarriers.Columns["Id"].HeaderText = "ID";
                dgvCarriers.Columns["Id"].Visible = false;
                dgvCarriers.Columns["Name"].HeaderText = "Nom";
                dgvCarriers.Columns["Name"].Width = 150;
                dgvCarriers.Columns["LoadCapacity"].HeaderText = "Capacité";
                dgvCarriers.Columns["Email"].HeaderText = "Mail";
                dgvCarriers.Columns["Email"].Width = 150;
                dgvCarriers.Columns["PhoneNumber"].HeaderText = "Téléphone";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'affichage des données. Elles pourraient être erronées ou incomplètes.\n\nDétail : \n" + ex.Message);
            }
        }

        /// <summary>
        /// Close the current form and open frmDetails with the selected carrier
        /// </summary>
        private void btnDetails_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvCarriers.SelectedRows[0];

                // Get the id in the selected row
                int carrierId = (int)selectedRow.Cells["Id"].Value;

                // Get the selected carrier with his id
                Carrier? selectedCarrier = carriers.FirstOrDefault(c => c.Id == carrierId);

                // MessageBox displaying the carrier's details
                // MessageBox.Show(selectedCarrier.ToString());

                // Create and open frmDetails
                FrmDetails frmDetails = new FrmDetails(selectedCarrier.ToString(), "Détail du transporteur " + selectedCarrier.Name);
                frmDetails.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Close the current form and open frmAddUpdCarrier
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create and open frmAddUpdCarrier and close frmCarriersList
            // Argument is null because we are adding a new carrier, not updating an existing one
            FrmAddUpdCarrier frmAddUpdCarrier = new FrmAddUpdCarrier(null);
            frmAddUpdCarrier.Show();
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Close the current form and open frmAddUpdCarrier with the selected carrier
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCarriers.SelectedRows.Count == 1)
            {
                try
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dgvCarriers.SelectedRows[0];

                    // Get the id in the selected row
                    int carrierId = (int)selectedRow.Cells["Id"].Value;

                    // Create and open frmUpdateCarrier and close frmCarriersList
                    FrmAddUpdCarrier frmAddUpdCarrier = new FrmAddUpdCarrier(carrierId);
                    frmAddUpdCarrier.Show();

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Delete  from the database the selected carrier in the DataGridView
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCarriers.SelectedRows.Count == 1)
            {
                try
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dgvCarriers.SelectedRows[0];

                    // Get the id in the selected row
                    int carrierId = (int)selectedRow.Cells["Id"].Value;

                    // Open connection to the database
                    dbConn = new DBConnection();
                    dbConn.OpenConnection();

                    // Prepare the SQL request
                    string deleteQuery = "DELETE FROM carriers WHERE id = @id";

                    // Execute the SQL request
                    dbConn.DeleteRecord(deleteQuery, carrierId);
                    dbConn.CloseConnection();

                    // Message box to confirm
                    string carrierName = (string)selectedRow.Cells["Name"].Value;
                    MessageBox.Show("Le transporteur " + carrierName + " a été supprimé.");

                    // Refresh the list of carriers
                    this.carriers = GetCarriers();
                    dgvCarriers.DataSource = carriers;
                }
                catch (Exception ex)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dgvCarriers.SelectedRows[0];

                    // Get the id in the selected row
                    string carrierName = (string)selectedRow.Cells["Name"].Value;
                    MessageBox.Show("Erreur lors de la suppression du transporteur. Le transporteur " + carrierName + " n'a pas pu être supprimé.\n\nDétail : \n" + ex.Message);
                }
            }
        }

        /// <summary>
        /// Close the current form and open frmHome
        /// </summary>
        private void btnHome_Click(object sender, EventArgs e)
        {
            // Create and open frmHome and close frmCarriersList
            FrmHome frmHome = new FrmHome();
            frmHome.Show();
            this.Close();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            // Create and open frmClientsList and close frmCarriersList
            FrmClientsList frmClientsList = new FrmClientsList();
            frmClientsList.Show();
            this.Close();
        }
    }
}
