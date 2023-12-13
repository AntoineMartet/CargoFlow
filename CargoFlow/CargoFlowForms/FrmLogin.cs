using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Reference to CargoFlowMgmt
using CargoFlowMgmt;

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
            dbConn = new DBConnection();
            dbConn.OpenConnection();
            string email = txtMail.Text;
            string password = txtPassword.Text;
            if (dbConn.CheckPassword(email, password))
            {
                // Get employee role from database
                string role = dbConn.GetEmployeeRole(email);

                // Open frmHome and close frmLogin
                FrmHome frmHome = new FrmHome(email, role);
                frmHome.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Mot de passe incorrect");
            }
        }
    }
}