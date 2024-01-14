using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CargoFlowForms
{
    public partial class FrmHome : Form
    {
        /// <summary>
        /// Constructor for the FrmHome class
        /// </summary>
        public FrmHome()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fill the user's email and role
        /// </summary>
        private void FrmHome_Load(object sender, EventArgs e)
        {
            lblSession.Text = "Utilisateur : " + Session.UserMail;
            lblSession.Text += "\n\nRôle (niveau d'accès) : " + Session.UserRole;
        }

        /// <summary>
        /// Close frmHome and open frmLists on the carriers tab
        /// </summary>

        private void btnCarriers_Click(object sender, EventArgs e)
        {
            // Create and open frmLists and close frmHome
            FrmLists frmLists = new FrmLists(btnCarriers.Name);
            frmLists.Show();
            this.Close();
        }

        /// <summary>
        /// Close frmHome and open frmLists on the clients tab
        /// </summary>
        private void btnClients_Click(object sender, EventArgs e)
        {
            // Create and open frmLists and close frmHome
            FrmLists frmLists = new FrmLists(btnClients.Name);
            frmLists.Show();
            this.Close();
        }

        /// <summary>
        /// Close frmHome and open frmLists on the employees tab
        /// </summary>
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            // Create and open frmLists and close frmHome
            FrmLists frmLists = new FrmLists(btnEmployees.Name);
            frmLists.Show();
            this.Close();
        }

        /// <summary>
        /// Reset session's variables, close frmHome and open frmLogin
        /// </summary>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.UserMail = "";
            Session.UserRole = "";
            // Dispose the current form and display frmLogin
            this.Close();
            Program.FrmLogin.Show();
         }
    }
}
