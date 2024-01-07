using CargoFlowMgmt;
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
        private string tab;
        private List<Carrier> carriers = new List<Carrier>();
        private List<Client> clients = new List<Client>();
        private DBConnection? dbConn;

        public FrmLists(string tab)
        {
            this.tab = tab;
            InitializeComponent();
        }

        private void FrmLists_Load(object sender, EventArgs e)
        {
            updateDGV(tab);
        }

        public void updateDGV(string tab)
        {
            switch (tab)
            {
                case "carriers":
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
                case "clients":
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
    }
}
