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
        /// </summary
        private List<Carrier> GetCarriers()
        {
            List<Carrier> list = new List<Carrier>();
            dbConn = new DBConnection();
            dbConn.OpenConnection();
            list = dbConn.GetAllCarriers();
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
                dgvCarriers.Columns["Name"].HeaderText = "Nom";
                dgvCarriers.Columns["LoadCapacity"].HeaderText = "Capacité";
                dgvCarriers.Columns["Email"].HeaderText = "Mail";
                dgvCarriers.Columns["PhoneNumber"].HeaderText = "Téléphone";
                dgvCarriers.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'affichage des données. Elles pourraient être erronées ou incomplètes.\n\nDétail : \n" + ex.Message);
            }
        }

        /// <summary>
        /// Close the current form and open frmAddCarrier
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create and open frmAddCarrier and close frmCarriersList
            FrmAddCarrier frmAddCarrier = new FrmAddCarrier();
            frmAddCarrier.Show();
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

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
    }
}
