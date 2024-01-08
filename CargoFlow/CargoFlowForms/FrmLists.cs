using CargoFlowMgmt;
using MySqlX.XDevAPI;
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
        private List<CargoFlowMgmt.Client> clients = new List<CargoFlowMgmt.Client>();
        private DBConnection? dbConn;

        /// <summary>
        /// Constructor of FrmLists
        /// </summary>
        /// <param name="tab">Name of the selected tab button</param>
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

        /// <summary>
        /// At load of the form, fill the DataGridView and set the tab colors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLists_Load(object sender, EventArgs e)
        {
            updateDGV(currentTab);
            updateFlpTabs(currentTab);
        }

        /// <summary>
        /// Update the DataGridView with the data corresponding to the selected tab
        /// </summary>
        /// <param name="tab">Name of the selected tab button</param>
        public void updateDGV(string tab)
        {
            switch (tab)
            {
                case "btnCarriers":
                    try
                    {
                        // Get all carriers in DB and fill the DataGridView with them
                        this.carriers = Carrier.GetCarriers();
                        dgvList.DataSource = carriers;
                        // Rename and set properties of the DGV columns
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
                    this.clients = CargoFlowMgmt.Client.GetClients();
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
        /// Update the colors of the tab depending on the current selected tab
        /// </summary>
        /// <param name="tab">Name of the selected tab button</param>
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
        /// <summary>
        /// Create and open frmHome and close frmLists
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            frmHome.Show();
            this.Close();
        }

        /// <summary>
        /// Update the DataGridView and the tab colors when clicking on the Stock tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStock_Click(object sender, EventArgs e)
        {
            updateDGV(btnStock.Name);
            updateFlpTabs(btnStock.Name);
        }

        /// <summary>
        /// Update the DataGridView and the tab colors when clicking on the Deliveries tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeliveries_Click(object sender, EventArgs e)
        {
            updateDGV(btnDeliveries.Name);
            updateFlpTabs(btnDeliveries.Name);
        }

        /// <summary>
        /// Update the DataGridView and the tab colors when clicking on the Carriers tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCarriers_Click(object sender, EventArgs e)
        {
            currentTab = btnCarriers.Name;
            updateDGV(btnCarriers.Name);
            updateFlpTabs(btnCarriers.Name);
        }

        /// <summary>
        /// Update the DataGridView and the tab colors when clicking on the Clients tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClients_Click(object sender, EventArgs e)
        {
            currentTab = btnClients.Name;
            updateDGV(btnClients.Name);
            updateFlpTabs(btnClients.Name);
        }

        /// <summary>
        /// Update the DataGridView and the tab colors when clicking on the Employees tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            updateDGV(btnEmployees.Name);
            updateFlpTabs(btnEmployees.Name);
        }

        /// <summary>
        /// Update the DataGridView and the tab colors when clicking on the Warehouses tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWarehouses_Click(object sender, EventArgs e)
        {
            updateDGV(btnWarehouses.Name);
            updateFlpTabs(btnWarehouses.Name);
        }

        /// <summary>
        /// Update the DataGridView and the tab colors when clicking on the Articles tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArticles_Click(object sender, EventArgs e)
        {
            updateDGV(btnArticles.Name);
            updateFlpTabs(btnArticles.Name);
        }
        #endregion

        #region Details, Add, Update and Delete buttons
        /// <summary>
        /// Open frmDetails corresponding to the selected row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        CargoFlowMgmt.Client? selectedClient = clients.FirstOrDefault(c => c.Id == objectId);
                        // Create and open frmDetails
                        frmDetails = new FrmDetails(selectedClient.ToString(), "Détail du client·e " + selectedClient.LastName);
                        frmDetails.Show();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Open frmAddUpd corresponding to the selected tab and close frmLists
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Arguments are null because whe are adding a new entity, not updating an existing one
                switch (currentTab)
                {
                    case "btnCarriers":
                        FrmAddUpdCarrier frmAddUpdCarrier = new FrmAddUpdCarrier(null);
                        frmAddUpdCarrier.Show();
                        this.Close();
                        break;
                    case "btnClients":
                        FrmAddUpdClient frmAddUpdClient = new FrmAddUpdClient(null);
                        frmAddUpdClient.Show();
                        this.Close();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Open frmAddUpd corresponding to the selected row and close frmLists
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvList.SelectedRows.Count == 1)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dgvList.SelectedRows[0];

                    // Get the id in the selected row
                    int objectId = (int)selectedRow.Cells["Id"].Value;

                    switch (currentTab)
                    {
                        case "btnCarriers":
                            if (dgvList.SelectedRows.Count == 1)
                            {
                                // Create and open frmUpdateCarrier and close frmCarriersList
                                FrmAddUpdCarrier frmAddUpdCarrier = new FrmAddUpdCarrier(objectId);
                                frmAddUpdCarrier.Show();
                                this.Close();
                            }
                            break;
                        case "btnClients":
                            if (dgvList.SelectedRows.Count == 1)
                            {
                                // Create and open frmUpdateCarrier and close frmCarriersList
                                FrmAddUpdClient frmAddUpdClient = new FrmAddUpdClient(objectId);
                                frmAddUpdClient.Show();
                                this.Close();
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Delete the selected row in the DataGridView and refresh the list of carriers or clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count == 1)
            {
                try
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dgvList.SelectedRows[0];

                    // Get the id in the selected row
                    int objectId = (int)selectedRow.Cells["Id"].Value;

                    // Open connection to the database
                    dbConn = new DBConnection();
                    dbConn.OpenConnection();

                    switch (currentTab)
                    {
                        case "btnCarriers":
                            // Prepare the SQL request
                            string deleteCarrierQuery = "DELETE FROM carriers WHERE id = @id";

                            // Execute the SQL request
                            dbConn.DeleteRecord(deleteCarrierQuery, objectId);

                            // Message box to confirm
                            string carrierName = (string)selectedRow.Cells["Name"].Value;
                            MessageBox.Show("Le transporteur " + carrierName + " a été supprimé.");

                            // Refresh the list of carriers
                            this.carriers = Carrier.GetCarriers();
                            dgvList.DataSource = carriers;
                            break;
                        case "btnClients":
                            // Prepare the SQL request
                            string deleteQuery = "DELETE FROM clients WHERE id = @id";

                            // Execute the SQL request
                            dbConn.DeleteRecord(deleteQuery, objectId);
                            dbConn.CloseConnection();

                            // Message box to confirm
                            string clientName = (string)selectedRow.Cells["LastName"].Value;
                            MessageBox.Show("Le/la client·e " + clientName + " a été supprimé·e.");

                            // Refresh the list of clients
                            this.clients = CargoFlowMgmt.Client.GetClients();
                            dgvList.DataSource = clients;
                            break;
                    }
                    dbConn.CloseConnection();
                }
                catch (Exception ex)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dgvList.SelectedRows[0];

                    // Get the id in the selected row
                    //string objectName = (string)selectedRow.Cells["Name"].Value;
                    //MessageBox.Show("Erreur lors de la suppression de l'objet. L'objet " + objectName + " n'a pas pu être supprimé.\n\nDétail : \n" + ex.Message);
                    MessageBox.Show("Erreur lors de la suppression de l'objet. L'objet n'a pas pu être supprimé.\n\nDétail : \n" + ex.Message);
                }
            }
        }
        #endregion
    }
}
