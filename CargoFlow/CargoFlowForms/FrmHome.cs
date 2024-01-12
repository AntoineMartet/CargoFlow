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
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            lblSession.Text = "Utilisateur : " + Session.UserMail;
            lblSession.Text += "\n\nRôle (niveau d'accès) : " + Session.UserRole;
        }

        private void btnCarriers_Click(object sender, EventArgs e)
        {
            // Create and open frmLists and close frmHome
            FrmLists frmLists = new FrmLists(btnCarriers.Name);
            frmLists.Show();
            this.Close();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            // Create and open frmLists and close frmHome
            FrmLists frmLists = new FrmLists(btnClients.Name);
            frmLists.Show();
            this.Close();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            // Create and open frmLists and close frmHome
            FrmLists frmLists = new FrmLists(btnEmployees.Name);
            frmLists.Show();
            this.Close();
        }
    }
}
