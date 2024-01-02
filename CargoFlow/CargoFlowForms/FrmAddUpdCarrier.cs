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
    public partial class FrmAddUpdCarrier : Form
    {
        private int? id;
        private DBConnection? dbConn;

        public FrmAddUpdCarrier(int? id)
        {
            this.id = id;
            InitializeComponent();
        }

        /// <summary>
        /// Changes labels and fill the fields with the carrier's data if we are updating a carrier
        /// </summary>
        private void FrmAddUpdCarrier_Load(object sender, EventArgs e)
        {
            // If we are updating a carrier, we need to change form's text and fill the fields with the carrier's data
            if (id != null)
            {
                lblTitle.Text = "Modification d'un transporteur";
                btnAddUpd.Text = "Modifier le transporteur";

                // Open connection to the database
                dbConn = new DBConnection();
                dbConn.OpenConnection();

                // Prepare the SQL request
                string query = "SELECT companyName, loadCapacity, email, phoneNumber FROM carriers WHERE id = " + id;

                // Execute the SQL request
                // Explicit conversion of id to int because it is nullable
                string[] record = dbConn.GetRecord(query, (int)id);

                // Close connection to the database
                dbConn.CloseConnection();

                // Fill the fields with the carrier's data
                txtName.Text = record[0];
                txtCapacity.Text = record[1];
                txtMail.Text = record[2];
                txtTel.Text = record[3];
            }
        }

        /// <summary>
        /// Close the current form and open frmCarriersList
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Open and create frmHome and close frmAddCarrier
            FrmCarriersList frmCarriersList = new FrmCarriersList();
            frmCarriersList.Show();
            this.Close();
        }

        /// <summary>
        /// Add a new carrier or update an existing carrier in the database
        /// </summary>
        private void btnAddUpd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtTel.Text == "" || txtMail.Text == "")
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

                    // Prepare the capacity value (must be null or integer)
                    int? capacity = null;
                    if (txtCapacity.Text != "")
                    {
                        capacity = int.Parse(txtCapacity.Text);
                    }

                    // Prepare the SQL request
                    string query;
                    if (id == null)
                    {
                        // Add a carrier
                        query = "INSERT INTO carriers (companyName, loadCapacity, email, phoneNumber) VALUES (@companyName, @loadCapacity, @email, @phoneNumber)";
                    }
                    else
                    {
                        // Update the carrier with the given id
                        query = "UPDATE carriers SET companyName = @companyName, loadCapacity = @loadCapacity, email = @email,"
                                + " phoneNumber = @phoneNumber WHERE id = " + id;
                    }

                    // Prepare the data for the SQL request
                    Dictionary<string, string?> queryData = new Dictionary<string, string?>();
                    queryData.Add("@companyName", txtName.Text);
                    queryData.Add("@loadCapacity", capacity.HasValue ? capacity.ToString() : null);
                    queryData.Add("@email", txtMail.Text);
                    queryData.Add("@phoneNumber", txtTel.Text);
                    if (id != null)
                    {
                        queryData.Add("@id", id.ToString());
                    }

                    // Execute the SQL request
                    if (id == null)
                    {
                        dbConn.AddRecord(query, queryData);
                        MessageBox.Show("Le transporteur " + txtName.Text + " a été ajouté.");
                    }
                    else
                    {
                        dbConn.UpdateRecord(query, queryData);
                        MessageBox.Show("Le transporteur " + txtName.Text + " a été modifié.");
                    }

                    // Close connection to the database
                    dbConn.CloseConnection();

                    // Create and open frmCarriersList and close frmAddCarrier
                    FrmCarriersList frmCarriersList = new FrmCarriersList();
                    frmCarriersList.Show();
                    this.Close();
                }
                // When the capacity is not null && not an integer
                catch (FormatException fEx)
                {
                    MessageBox.Show("Erreur lors de l'ajout du transporteur. Le transporteur " + txtName.Text + " n'a pas pu être ajouté.\n\n" +
                                    "La capacité maximum doit être un nombre entier. Vous pouvez aussi laisser le champ vide.\n\nDétail : \n" + fEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout du transporteur. Le transporteur " + txtName.Text + " n'a pas pu être ajouté.\n\nDétail : \n" + ex.Message);
                }
            }
        }
    }
}
