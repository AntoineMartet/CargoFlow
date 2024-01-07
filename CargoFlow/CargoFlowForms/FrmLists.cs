using CargoFlowMgmt;
//using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoFlowForms
{
    public partial class FrmLists : Form
    {
        private string currentTab;
        private List<Button> tabButtons = new List<Button>();
        private List<Carrier> carriers = new List<Carrier>();
        private List<Client> clients = new List<Client>();
        private DBConnection? dbConn;


        public FrmLists(string tab)
        {
            InitializeComponent();
            this.currentTab = tab;
            this.tabButtons.Add(btnStock);
            this.tabButtons.Add(btnDeliveries);
            this.tabButtons.Add(btnCarriers);
            this.tabButtons.Add(btnClients);
            this.tabButtons.Add(btnEmployees);
            this.tabButtons.Add(btnWarehouses);
            this.tabButtons.Add(btnArticles);
        }

        private void FrmLists_Load(object sender, EventArgs e)
        {
            updateDGV(currentTab);
            updateFlpTabs(currentTab);
        }

        public void updateDGV(string tab)
        {
            switch (tab)
            {
                case "btnCarriers":
                    //TODO: put GetClients in a static methhod in Client class
                    this.carriers = GetCarriers();
                    try
                    {
                        dgvList.DataSource = carriers;
                        // Renommage des colonnes. Pourquoi en fonction des propriétés de l'objet Carrier et non pas de ses attributs ? À voir...
                        dgvList.Columns["Id"].HeaderText = "ID";
                        dgvList.Columns["Id"].Visible = false;
                        dgvList.Columns["Name"].HeaderText = "Nom";
                        dgvList.Columns["Name"].Width = 150;
                        dgvList.Columns["LoadCapacity"].HeaderText = "Capacité";
                        dgvList.Columns["Email"].HeaderText = "Mail";
                        dgvList.Columns["Email"].Width = 150;
                        dgvList.Columns["PhoneNumber"].HeaderText = "Téléphone";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de l'affichage des données. Elles pourraient être erronées ou incomplètes.\n\nDétail : \n" + ex.Message);
                    }
                    break;
                case "btnClients":
                    //TODO: put GetClients in a static methhod in Client class
                    this.clients = GetClients();
                    try
                    {
                        dgvList.DataSource = clients;
                        // Renommage des colonnes
                        dgvList.Columns["Id"].HeaderText = "ID";
                        dgvList.Columns["Id"].Visible = false;
                        dgvList.Columns["LastName"].HeaderText = "Nom";
                        dgvList.Columns["FirstName"].HeaderText = "Prénom";
                        dgvList.Columns["Email"].HeaderText = "Mail";
                        dgvList.Columns["Email"].Width = 150;
                        dgvList.Columns["Address"].HeaderText = "Adresse";
                        dgvList.Columns["Address"].Width = 250;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de l'affichage des données. Elles pourraient être erronées ou incomplètes.\n\nDétail : \n" + ex.Message);
                    }
                    break;
                default:
                    break;
            }
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

        private void updateFlpTabs(string tab)
        {
            foreach (Button button in tabButtons)
            {
                if (button.Name == tab)
                {
                    button.BackColor = Color.LightCyan;
                }
                else
                {
                    button.BackColor = Color.PowderBlue;
                }
            }
        }

        #region Updates when clicking tabs
        private void btnHome_Click(object sender, EventArgs e)
        {
            // Create and open frmHome and close frmLists
            FrmHome frmHome = new FrmHome();
            frmHome.Show();
            this.Close();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            updateDGV(btnStock.Name);
            updateFlpTabs(btnStock.Name);
        }

        private void btnDeliveries_Click(object sender, EventArgs e)
        {
            updateDGV(btnDeliveries.Name);
            updateFlpTabs(btnDeliveries.Name);
        }

        private void btnCarriers_Click(object sender, EventArgs e)
        {
            updateDGV(btnCarriers.Name);
            updateFlpTabs(btnCarriers.Name);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            updateDGV(btnClients.Name);
            updateFlpTabs(btnClients.Name);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            updateDGV(btnEmployees.Name);
            updateFlpTabs(btnEmployees.Name);
        }

        private void btnWarehouses_Click(object sender, EventArgs e)
        {
            updateDGV(btnWarehouses.Name);
            updateFlpTabs(btnWarehouses.Name);
        }

        private void btnArticles_Click(object sender, EventArgs e)
        {
            updateDGV(btnArticles.Name);
            updateFlpTabs(btnArticles.Name);
        }
        #endregion

        private void btnDetails_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvList.SelectedRows[0];

                // Get the id in the selected row
                int objectId = (int)selectedRow.Cells["Id"].Value;

                FrmDetails frmDetails;

                switch (currentTab)
                {
                    case "btnCarriers":
                        // Get the selected carrier with his id
                        Carrier? selectedCarrier = carriers.FirstOrDefault(c => c.Id == objectId);
                        // Create and open frmDetails
                        frmDetails = new FrmDetails(selectedCarrier.ToString(), "Détail du transporteur " + selectedCarrier.Name);
                        frmDetails.Show();
                        break;
                    case "btnClients":
                        // Get the selected client with his id
                        Client? selectedClient = clients.FirstOrDefault(c => c.Id == objectId);
                        // Create and open frmDetails
                        frmDetails = new FrmDetails(selectedClient.ToString(), "Détail du client·e " + selectedClient.LastName);
                        frmDetails.Show();
                        break;
                    default :
                        break;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
