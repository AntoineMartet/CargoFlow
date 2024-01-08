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
        private List<CargoFlowMgmt.Employee> employees = new List<CargoFlowMgmt.Employee>();
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

        /// <summary>
        /// Update the DataGridView with the data corresponding to the tab
        /// </summary>
        /// <param name="tab"></param>
        public void updateDGV(string tab)
        {
            switch (tab)
            {
                case "btnCarriers":
                    //TODO: put GetClients in a static methhod in Client class
                    this.carriers = Carrier.GetCarriers();
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
                case "btnEmployees":
                    this.employees = CargoFlowMgmt.Employee.GetEmployees();
                    try
                    {
                        dgvList.DataSource = employees;
                        // Renommage des colonnes
                        dgvList.Columns["Id"].HeaderText = "ID";
                        dgvList.Columns["Id"].Visible = false;
                        dgvList.Columns["LastName"].HeaderText = "Nom";
                        dgvList.Columns["FirstName"].HeaderText = "Prénom";
                        dgvList.Columns["Email"].HeaderText = "Mail";
                        dgvList.Columns["Email"].Width = 200;
                        dgvList.Columns["PhoneNumber"].HeaderText = "Numéro de téléphone";
                        dgvList.Columns["Role"].HeaderText = "Rôle";
                        dgvList.Columns["EmployeeNumber"].HeaderText = "Numéro d'employé.e";
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
        /// Update the colors of the tab depending on the current tab
        /// </summary>
        /// <param name="tab"></param>
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
            currentTab = btnCarriers.Name;
            updateDGV(btnCarriers.Name);
            updateFlpTabs(btnCarriers.Name);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            currentTab = btnClients.Name;
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

        #region Details, Add, Update and Delete buttons
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
                    case "btnEmployees":
                        // Get the selected employee with his id
                        CargoFlowMgmt.Employee? selectedEmployee = employees.FirstOrDefault(c => c.Id == objectId);
                        // Create and open frmDetails
                        frmDetails = new FrmDetails(selectedEmployee.ToString(), "Détail de l'employé·e " + selectedEmployee.LastName);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                switch (currentTab)
                {
                    case "btnCarriers":
                        // Create and open frmAddUpdCarrier and close frmLists
                        // Argument is null because we are adding a new carrier, not updating an existing one
                        FrmAddUpdCarrier frmAddUpdCarrier = new FrmAddUpdCarrier(null);
                        frmAddUpdCarrier.Show();
                        this.Close();
                        break;
                    case "btnClients":
                        //TODO
                        break;
                    case "btnEmployees":
                        //TODO
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
                            //TODO
                            break;
                        case "btnEmployees":
                            //TODO
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
                            {
                                // Prepare the SQL request
                                string deleteQuery = "DELETE FROM carriers WHERE id = @id";

                                // Execute the SQL request
                                dbConn.DeleteRecord(deleteQuery, objectId);

                                // Message box to confirm
                                string carrierName = (string)selectedRow.Cells["Name"].Value;
                                MessageBox.Show("Le transporteur " + carrierName + " a été supprimé.");

                                // Refresh the list of carriers
                                this.carriers = Carrier.GetCarriers();
                                dgvList.DataSource = carriers;
                                break;
                            }
                        case "btnClients":
                            {
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
                        case "btnEmployees":
                            {
                                // Prepare the SQL request
                                string deleteQuery = "DELETE FROM employees WHERE id = @id";

                                // Execute the SQL request
                                dbConn.DeleteRecord(deleteQuery, objectId);
                                dbConn.CloseConnection();

                                // Message box to confirm
                                string employeeName = (string)selectedRow.Cells["LastName"].Value;
                                MessageBox.Show("L'employé·e " + employeeName + " a été supprimé·e.");

                                // Refresh the list of employees
                                this.employees = CargoFlowMgmt.Employee.GetEmployees();
                                dgvList.DataSource = employees;
                                break;
                            }
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
