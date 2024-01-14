using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CargoFlowMgmt;
using System.Security.Cryptography;
using System.Net.Mail;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Asn1.X509;

namespace CargoFlowForms
{
    public partial class FrmAddUpdEmployee : Form
    {
        private int? id;
        private DBConnection? dbConn;

        /// <summary>
        /// Constructor for the FrmAddUpdEmployee class
        /// </summary>
        /// <param name="id">Id of the employee to add or update</param>
        public FrmAddUpdEmployee(int? id)
        {
            this.id = id;
            InitializeComponent();
        }

        /// <summary>
        /// Changes labels and fill the fields with the employee's data if we are updating an employee
        /// </summary>
        private void FrmAddUpdEmployee_Load(object sender, EventArgs e)
        {
            List<string[]> roles = Employee.GetAllRoles();

            // Fill the cmbRole comboBox with the roles from the database
            foreach (string[] role in roles)
            {
                cmbRole.Items.Add(role[0]);
            }

            // If we are updating a employee, we need to change form's text and fill the fields with the employee's data
            if (id != null)
            {
                lblTitle.Text = "Modification d'un·e employé·e";
                btnAddUpd.Text = "Modifier";

                // Open connection to the database
                dbConn = new DBConnection();
                dbConn.OpenConnection();

                // Prepare the SQL request
                string employeeDataQuery = "SELECT lastName, firstName, email, password, phoneNumber, role, employeeNumber FROM employees WHERE id = " + id;

                // Execute the SQL request
                // Explicit conversion of id to int because it is nullable
                string[] record = dbConn.GetRecord(employeeDataQuery, (int)id);

                // Close connection to the database
                dbConn.CloseConnection();

                // Fill the fields with the employee's data
                txtLastName.Text = record[0];
                txtFirstName.Text = record[1];
                txtEmail.Text = record[2];
                txtPassword.Text = record[3];
                txtPassword.Enabled = false;
                txtPhoneNumber.Text = record[4];
                cmbRole.Text = record[5];
                txtEmployeeNumber.Text = record[6];
            }
        }

        /// <summary>
        /// Add a new employee or update an existing employee in the database
        /// </summary>
        private void btnAddUpd_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text == "" || txtFirstName.Text == "" || txtEmail.Text == "" || txtPassword.Text == ""
                || txtPhoneNumber.Text == "" || cmbRole.Text == "" || txtEmployeeNumber.Text == "")
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
                        // Add an employee
                        query = "INSERT INTO employees (lastName, firstName, email, password, phoneNumber, role, employeeNumber) VALUES (@lastName, @firstName, @email, @password, @phoneNumber, @role, @employeeNumber)";
                    }
                    else
                    {
                        // Update the employee with the given id
                        query = "UPDATE employees SET lastName = @lastName, firstName = @firstName, email = @email, phoneNumber = @phoneNumber, role = @role, employeeNumber = @employeeNumber"
                                + " WHERE id = " + id;
                    }

                    // Prepare the data for the SQL request
                    Dictionary<string, string?> queryData = new Dictionary<string, string?>();
                    queryData.Add("@lastName", txtLastName.Text);
                    queryData.Add("@firstName", txtFirstName.Text);
                    // Throw exception if the email address is not valid
                    if (Utilities.CheckEmailaddressFormat(txtEmail.Text))
                    {
                        queryData.Add("@email", txtEmail.Text);
                    }
                    // Create a byte array from input password
                    byte[] pwdBytes = ASCIIEncoding.ASCII.GetBytes(txtPassword.Text);
                    // Compute hash based on input password
                    byte[] pwdHashBytes = new MD5CryptoServiceProvider().ComputeHash(pwdBytes);
                    // Convert pwdHashBytes to hexadecimal string
                    string pwdHashHexa = BitConverter.ToString(pwdHashBytes);
                    // Replace() and ToLower needed otherwise result looks like "3A-E8-43-CA-22..."
                    pwdHashHexa = pwdHashHexa.Replace("-", "").ToLower();
                    queryData.Add("@password", pwdHashHexa);
                    queryData.Add("@phoneNumber", txtPhoneNumber.Text);
                    queryData.Add("@role", cmbRole.Text);
                    queryData.Add("@employeeNumber", txtEmployeeNumber.Text);

                    if (id != null)
                    {
                        queryData.Add("@id", id.ToString());
                    }

                    // Execute the SQL request
                    if (id == null)
                    {
                        dbConn.AddRecord(query, queryData);
                        MessageBox.Show("L'employé·e " + txtLastName.Text + " a été ajouté·e.");
                    }
                    else
                    {
                        dbConn.UpdateRecord(query, queryData);
                        MessageBox.Show("L'employé·e " + txtLastName.Text + " a été modifié·e.");
                    }

                    // Close connection to the database
                    dbConn.CloseConnection();

                    // Open and create frmHome and close frmLists
                    FrmLists frmLists = new FrmLists("btnEmployees");
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
                    MessageBox.Show("Erreur lors de l'ajout de l'employé·e. L'employé·e " + txtLastName.Text + " n'a pas pu être ajouté·e.\n\nDétail : \n" + ex.Message);
                    dbConn.CloseConnection();
                }
            }
        }

        /// <summary>
        /// Close the current form and open frmLists
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmLists frmLists = new FrmLists("btnEmployees");
            frmLists.Show();
            this.Close();
        }
    }
}
