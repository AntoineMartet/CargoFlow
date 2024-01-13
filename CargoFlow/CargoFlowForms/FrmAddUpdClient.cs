using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CargoFlowMgmt;

namespace CargoFlowForms
{
    public partial class FrmAddUpdClient : Form
    {
        private int? id;
        private DBConnection? dbConn;

        public FrmAddUpdClient(int? id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void FrmAddUpdClient_Load(object sender, EventArgs e)
        {
            // If we are updating a client, we need to change form's text and fill the fields with the client's data
            if (id != null)
            {
                lblTitle.Text = "Modification d'un client";
                btnAddUpd.Text = "Modifier";

                // Open connection to the database
                dbConn = new DBConnection();
                dbConn.OpenConnection();

                // Prepare the SQL request
                string query = "SELECT lastName, firstName, email, street, streetNumber, city, postalCode FROM clients WHERE id = " + id;

                // Execute the SQL request
                // Explicit conversion of id to int because it is nullable
                string[] record = dbConn.GetRecord(query, (int)id);

                // Close connection to the database
                dbConn.CloseConnection();

                // Fill the fields with the client's data
                txtLastName.Text = record[0];
                txtFirstName.Text = record[1];
                txtEmail.Text = record[2];
                txtStreet.Text = record[3];
                txtStreetNumber.Text = record[4];
                txtCity.Text = record[5];
                txtPostalCode.Text = record[6];
            }
        }

        private void btnAddUpd_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text == "" || txtFirstName.Text == "" || txtEmail.Text == "" || txtStreet.Text == ""
                || txtStreetNumber.Text == "" || txtCity.Text == "" || txtPostalCode.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.\nLes champs obligatoires sont marqués par des astérisques (*).");
            }
            else
            {
                try
                {
                    // Open connection to the database
                    dbConn = new DBConnection();
                    dbConn.OpenConnection();

                    // Prepare the SQL request
                    string query;
                    if (id == null)
                    {
                        // Add a client
                        query = "INSERT INTO clients (lastName, firstName, email, street, streetNumber, city, postalCode) VALUES (@lastName, @firstName, @email, @street, @streetNumber, @city, @postalCode)";
                    }
                    else
                    {
                        // Update the client with the given id
                        query = "UPDATE clients SET lastName = @lastName, firstName = @firstName, email = @email,"
                                + " street = @street, streetNumber = @streetNumber, city = @city, postalCode = @postalCode WHERE id = " + id;
                    }

                    // Prepare the data for the SQL request
                    Dictionary<string, string?> queryData = new Dictionary<string, string?>();
                    queryData.Add("@lastName", txtLastName.Text);
                    queryData.Add("@firstName", txtFirstName.Text);
                    if (Utilities.CheckEmailaddressFormat(txtEmail.Text))
                    {
                        queryData.Add("@email", txtEmail.Text);
                    }
                    queryData.Add("@street", txtStreet.Text);
                    queryData.Add("@streetNumber", txtStreetNumber.Text.ToString());
                    queryData.Add("@city", txtCity.Text);
                    queryData.Add("@postalCode", txtPostalCode.Text.ToString());

                    if (id != null)
                    {
                        queryData.Add("@id", id.ToString());
                    }

                    // Execute the SQL request
                    if (id == null)
                    {
                        dbConn.AddRecord(query, queryData);
                        MessageBox.Show("Le client " + txtLastName.Text + " a été ajouté.");
                    }
                    else
                    {
                        dbConn.UpdateRecord(query, queryData);
                        MessageBox.Show("Le client " + txtLastName.Text + " a été modifié.");
                    }

                    // Close connection to the database
                    dbConn.CloseConnection();

                    // Open and create frmHome and close frmLists
                    FrmLists frmLists = new FrmLists("btnClients");
                    frmLists.Show();
                    this.Close();
                }
                catch (Utilities.EmailaddressException)
                {
                    MessageBox.Show("L'adresse mail n'est pas valide.");
                    dbConn.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout du client. Le client " + txtLastName.Text + " n'a pas pu être ajouté.\n\nDétail : \n" + ex.Message);
                    dbConn.CloseConnection();
                }
            }
        }

        /// <summary>
        /// Close the current form and open frmLists
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmLists frmLists = new FrmLists("btnClients");
            frmLists.Show();
            this.Close();
        }
    }
}
