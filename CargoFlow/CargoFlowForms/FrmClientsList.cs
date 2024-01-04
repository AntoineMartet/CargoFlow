using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
// Reference to CargoFlowMgmt project to access its classes
using CargoFlowMgmt;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static CargoFlowMgmt.DBConnection;

namespace CargoFlowForms
{
    /// <summary>
    /// Form to display the list of clients
    /// </summary>
    public partial class FrmClientsList : Form
    {
        private List<Client> clients = new List<Client>();
        private DBConnection? dbConn;

        public FrmClientsList()
        {
            try
            {
                this.clients = GetClients();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des données. Elles pourraient être erronées ou incomplètes.\n\nDétail : \n" + ex.Message);
            }
            InitializeComponent();
        }

        /// <summary>
        /// Get all the clients from the database and return them as a list of Client objects
        /// </summary>
        private List<Client> GetClients()
        {
            List<Client> list = new List<Client>();
            dbConn = new DBConnection();
            dbConn.OpenConnection();
            string getAllClientsQuery = "SELECT id, lastName, firstName, email, street, streetNumber, city, postalCode FROM clients";
            List<string[]> records = dbConn.GetAllRecords(getAllClientsQuery);

            // Double loop reading records
            foreach (string[] record in records)
            {
                // Preparing the parameters for the Client constructor
                int id = Int32.Parse(record[0]);
                string lastName = record[1];
                string firstName = record[2];
                string email = record[3];
                string street = record[4];
                string streetNumber = record[5];
                string city = record[6];
                string postalCode = record[7];
                // Create the Address object
                Address address = new Address(street, streetNumber, city, postalCode);
                // Create the Client object
                Client client = new Client(id, lastName, firstName, email, address);
                // Add the Client object to the list
                list.Add(client);
            }
            dbConn.CloseConnection();
            return list;
        }

        /// <summary>
        /// Fill the DataGridView with the all the clients
        /// </summary>
        private void FrmClientsList_Load(object sender, EventArgs e)
        {
            try
            {
                dgvClients.DataSource = clients;
                // Renommage des colonnes
                dgvClients.Columns["Id"].HeaderText = "ID";
                dgvClients.Columns["Id"].Visible = false;
                dgvClients.Columns["LastName"].HeaderText = "Nom";
                dgvClients.Columns["FirstName"].HeaderText = "Prénom";
                dgvClients.Columns["Email"].HeaderText = "Mail";
                dgvClients.Columns["Email"].Width = 150;
                dgvClients.Columns["Address"].HeaderText = "Adresse";
                dgvClients.Columns["Address"].Width = 250;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'affichage des données. Elles pourraient être erronées ou incomplètes.\n\nDétail : \n" + ex.Message);
            }
        }

        /// <summary>
        /// Close the current form and open frmDetails with the selected client
        /// </summary>
        private void btnDetails_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvClients.SelectedRows[0];

                // Get the id in the selected row
                int clientId = (int)selectedRow.Cells["Id"].Value;

                // Get the selected client with his id
                Client? selectedClient = clients.FirstOrDefault(c => c.Id == clientId);

                // MessageBox displaying the client's details
                // MessageBox.Show(selectedClient.ToString());

                // Create and open frmDetails
                FrmDetails frmDetails = new FrmDetails(selectedClient.ToString(), "Détail du client·e " + selectedClient.LastName);
                frmDetails.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Close the current form and open frmAddUpdClient
        /// </summary>


        /// <summary>
        /// Close the current form and open frmAddUpdClient with the selected client
        /// </summary>


        /// <summary>
        /// Delete  from the database the selected client in the DataGridView
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count == 1)
            {
                try
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dgvClients.SelectedRows[0];

                    // Get the id in the selected row
                    int clientId = (int)selectedRow.Cells["Id"].Value;

                    // Open connection to the database
                    dbConn = new DBConnection();
                    dbConn.OpenConnection();

                    // Prepare the SQL request
                    string deleteQuery = "DELETE FROM clients WHERE id = @id";

                    // Execute the SQL request
                    dbConn.DeleteRecord(deleteQuery, clientId);
                    dbConn.CloseConnection();

                    // Message box to confirm
                    string clientName = (string)selectedRow.Cells["LastName"].Value;
                    MessageBox.Show("Le/la client·e " + clientName + " a été supprimé·e.");

                    // Refresh the list of clients
                    this.clients = GetClients();
                    dgvClients.DataSource = clients;
                }
                catch (Exception ex)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dgvClients.SelectedRows[0];

                    // Get the id in the selected row
                    string clientName = (string)selectedRow.Cells["LastName"].Value;
                    MessageBox.Show("Erreur lors de la suppression du client·e. Le/la client·e " + clientName + " n'a pas pu être supprimé·e.\n\nDétail : \n" + ex.Message);
                }
            }
        }

        /// <summary>
        /// Close the current form and open frmHome
        /// </summary>
        private void btnHome_Click(object sender, EventArgs e)
        {
            // Create and open frmHome and close frmClientsList
            FrmHome frmHome = new FrmHome();
            frmHome.Show();
            this.Close();
        }

        private void btnCarriers_Click(object sender, EventArgs e)
        {
            FrmCarriersList frmCarriersList = new FrmCarriersList();
            frmCarriersList.Show();
            this.Close();
        }
    }
}
