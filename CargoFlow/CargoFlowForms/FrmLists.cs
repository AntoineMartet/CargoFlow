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
        private bool orderByNameAsc;
        private List<Button> tabButtons = new List<Button>();
        private List<Carrier> carriers = new List<Carrier>();
        // CargoFlowMgmt.Client needed instead of Client because of conflict with MySqlX.XDevAPI
        private List<CargoFlowMgmt.Client> clients = new List<CargoFlowMgmt.Client>();
        private List<Employee> employees = new List<Employee>();
        private DBConnection? dbConn;

        /// <summary>
        /// Constructor of the FrmLists class
        /// </summary>
        /// <param name="tab">Name of the selected tab button</param>
        public FrmLists(string tab)
        {
            InitializeComponent();
            this.currentTab = tab;
            this.orderByNameAsc = false;
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
                        this.carriers = Carrier.GetCarriers(null);
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
                case "btnEmployees":
                    this.employees = Employee.GetEmployees();
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

        /// <summary>
        /// Sort the carriers by name when clicking on the Name header
        /// </summary>
        private void dgvList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (currentTab)
            {
                case "btnCarriers":
                    {
                        // Get the name of the header clicked
                        string headerName = dgvList.Columns[e.ColumnIndex].Name;

                        if (headerName == "Name")
                        {
                            if (orderByNameAsc == false)
                            {
                                // Sort the carriers by name (ascending)
                                carriers = Carrier.GetCarriers(true);
                                orderByNameAsc = true;
                            }
                            else
                            {
                                // Sort the carriers by name (descending)
                                carriers = Carrier.GetCarriers(false);
                                orderByNameAsc = false;
                            }
                            dgvList.DataSource = carriers;
                        }
                        break;
                    }
            }
        }

        #region Updates when clicking tabs
        /// <summary>
        /// Create and open frmHome and close frmLists
        /// </summary>
        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            frmHome.Show();
            this.Close();
        }

        /// <summary>
        /// Update the DataGridView and the tab colors when clicking on the Stock tab
        /// </summary>
        private void btnStock_Click(object sender, EventArgs e)
        {
            updateDGV(btnStock.Name);
            updateFlpTabs(btnStock.Name);
        }

        /// <summary>
        /// Update the DataGridView and the tab colors when clicking on the Deliveries tab
        /// </summary>
        private void btnDeliveries_Click(object sender, EventArgs e)
        {
            updateDGV(btnDeliveries.Name);
            updateFlpTabs(btnDeliveries.Name);
        }

        /// <summary>
        /// Update the DataGridView and the tab colors when clicking on the Carriers tab
        /// </summary>
        private void btnCarriers_Click(object sender, EventArgs e)
        {
            currentTab = btnCarriers.Name;
            updateDGV(btnCarriers.Name);
            updateFlpTabs(btnCarriers.Name);
        }

        /// <summary>
        /// Update the DataGridView and the tab colors when clicking on the Clients tab
        /// </summary>
        private void btnClients_Click(object sender, EventArgs e)
        {
            currentTab = btnClients.Name;
            updateDGV(btnClients.Name);
            updateFlpTabs(btnClients.Name);
        }

        /// <summary>
        /// Update the DataGridView and the tab colors when clicking on the Employees tab
        /// </summary>
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            currentTab = btnEmployees.Name;
            updateDGV(btnEmployees.Name);
            updateFlpTabs(btnEmployees.Name);
        }

        /// <summary>
        /// Update the DataGridView and the tab colors when clicking on the Warehouses tab
        /// </summary>
        private void btnWarehouses_Click(object sender, EventArgs e)
        {
            updateDGV(btnWarehouses.Name);
            updateFlpTabs(btnWarehouses.Name);
        }

        /// <summary>
        /// Update the DataGridView and the tab colors when clicking on the Articles tab
        /// </summary>
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
        private void btnDetails_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvList.SelectedRows[0];

                // Get the id in the selected row
                int objectId = (int)selectedRow.Cells["Id"].Value;

                switch (currentTab)
                {
                    case "btnCarriers":
                        {
                            // Get the selected carrier with his id
                            Carrier? selectedCarrier = carriers.FirstOrDefault(c => c.Id == objectId);
                            // Create and open frmDetails
                            FrmDetails frmDetails = new FrmDetails(selectedCarrier.ToString(), "Détails du transporteur " + selectedCarrier.Name);
                            frmDetails.Show();
                            break;
                        }
                    case "btnClients":
                        {
                            // Get the selected client with his id
                            CargoFlowMgmt.Client? selectedClient = clients.FirstOrDefault(c => c.Id == objectId);
                            // Create and open frmDetails
                            FrmDetails frmDetails = new FrmDetails(selectedClient.ToString(), "Détails du client·e " + selectedClient.LastName);
                            frmDetails.Show();
                            break;
                        }
                    case "btnEmployees":
                        {
                            // Get the selected employee with his id
                            Employee? selectedEmployee = employees.FirstOrDefault(c => c.Id == objectId);
                            // Create and open frmDetails
                            FrmDetails frmDetails = new FrmDetails(selectedEmployee.ToString(), "Détails de l'employé·e " + selectedEmployee.LastName);
                            frmDetails.Show();
                        }
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
                    case "btnEmployees":
                        FrmAddUpdEmployee frmAddUpdEmployee = new FrmAddUpdEmployee(null);
                        frmAddUpdEmployee.Show();
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
                                // Create and open frmUpdateClient and close frmClientsList
                                FrmAddUpdClient frmAddUpdClient = new FrmAddUpdClient(objectId);
                                frmAddUpdClient.Show();
                                this.Close();
                            }
                            break;
                        case "btnEmployees":
                            if (dgvList.SelectedRows.Count == 1)
                            {
                                // Create and open frmUpdateEmployee and close frmEmployeesList
                                FrmAddUpdEmployee frmAddUpdEmployee = new FrmAddUpdEmployee(objectId);
                                frmAddUpdEmployee.Show();
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
        /// Delete the selected row in the DataGridView and refresh the list of carriers or clients or employees
        /// </summary>
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

                                // Name of the carrier to delete
                                string carrierName = (string)selectedRow.Cells["Name"].Value;

                                if (MessageBox.Show("Êtes-vous sûr·e de vouloir supprimer le transporteur " + carrierName + "?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    // Execute the SQL request
                                    dbConn.DeleteRecord(deleteQuery, objectId);

                                    // Message box to confirm
                                    carrierName = (string)selectedRow.Cells["Name"].Value;

                                    // Refresh the list of carriers
                                    carriers = Carrier.GetCarriers(null);
                                    dgvList.DataSource = carriers;
                                }
                                break;
                            }
                        case "btnClients":
                            {
                                // Prepare the SQL request
                                string deleteQuery = "DELETE FROM clients WHERE id = @id";

                                // Name of the client to delete
                                string clientName = (string)selectedRow.Cells["LastName"].Value;

                                if (MessageBox.Show("Êtes-vous sûr·e de vouloir supprimer le client " + clientName + "?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    // Execute the SQL request
                                    dbConn.DeleteRecord(deleteQuery, objectId);

                                    // Message box to confirm
                                    clientName = (string)selectedRow.Cells["LastName"].Value;

                                    // Refresh the list of carriers
                                    clients = CargoFlowMgmt.Client.GetClients();
                                    dgvList.DataSource = clients;
                                }
                                break;
                            }
                        case "btnEmployees":
                            {
                                // Prepare the SQL request
                                string deleteQuery = "DELETE FROM employees WHERE id = @id";

                                // Name of the employee to delete
                                string employeeName = (string)selectedRow.Cells["LastName"].Value;

                                if (MessageBox.Show("Êtes-vous sûr·e de vouloir supprimer l'employé " + employeeName + "?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    // Execute the SQL request
                                    dbConn.DeleteRecord(deleteQuery, objectId);

                                    // Message box to confirm
                                    employeeName = (string)selectedRow.Cells["LastName"].Value;

                                    // Refresh the list of carriers
                                    employees = Employee.GetEmployees();
                                    dgvList.DataSource = employees;
                                }
                                break;
                            }
                    }
                    dbConn.CloseConnection();
                }
                catch (Exception ex)
                {
                    dbConn.CloseConnection();
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
