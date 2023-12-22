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

                // Create and open frmHome and close frmLogin
                FrmHome frmHome = new FrmHome(email, role);
                frmHome.Show();
                // Hide the login form. Closing it would close the whole application.
                this.Hide();
            }
            catch (WrongLoginException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (EmailNotInDbException ex)
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