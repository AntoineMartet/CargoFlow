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

        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Check the given email and password and open frmHome if they are correct
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        /// <summary>
        /// Trigger the login method when the user presses enter in the email textbox
        /// </summary>
        private void txtMail_KeyUp(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Login();
                }
            }
        }

        /// <summary>
        /// Trigger the login method when the user presses enter in the password textbox
        /// </summary>
        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Login();
                }
            }
        }

        /// <summary>
        /// Check the given email and password and open frmHome if they are correct
        /// </summary>
        private void Login()
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
                Session.UserMail = email;
                Session.UserRole = role;

                // Create and open frmHome and close frmLogin
                FrmHome frmHome = new FrmHome();
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
    }
}