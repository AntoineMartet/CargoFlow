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
using static CargoFlowMgmt.DBConnection;

namespace CargoFlowForms
{
    public partial class FrmLogin : Form
    {
        private DBConnection dbConn;
        private string email;
        private string role;

        public FrmLogin()
        {
            InitializeComponent();
        }

        public string Email
        {
            get { return email; }
            private set { email = value; }
        }

        public string Role
        {
            get { return role; }
            private set { role = value; }
        }

        /// <summary>
        /// Check the given email and password and open frmHome if they are correct
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a DBConnection object and open the connection
                dbConn = new DBConnection();
                dbConn.OpenConnection();

                // Check the given email and password
                string email = txtMail.Text;
                string password = txtPassword.Text;
                dbConn.CheckPassword(email, password);

                // Get employee role from database
                string role = dbConn.GetEmployeeRole(email);

                dbConn.CloseConnection();

                // Initialize email and role object attributes.
                // They will be used in all the other forms as the login form is always open.
                this.Email = email;
                this.Role = role;

                // Create and open frmHome and close frmLogin
                FrmHome frmHome = new FrmHome(this.Email, this.Role);
                frmHome.Show();
                // Hide the login form. Closing it would close the whole application.
                this.Hide();
            }
            catch (WrongLoginException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (EmailNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMail_KeyUp(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnLogin_Click(sender, e);
                }
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnLogin_Click(sender, e);
                }
            }
        }
    }
}