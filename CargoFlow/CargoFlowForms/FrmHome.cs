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
        private string email;
        private string role;

        // Email and role should not be optional in future versions of the software
        public FrmHome(string email = "", string role = "")
        {
            this.email = email;
            this.role = role;
            InitializeComponent();
        }

        public string Email
        {
            get { return email; }
        }

        public string Role
        {
            get { return role; }
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            lblSession.Text = "Utilisateur : " + email;
            lblSession.Text += "\n\nRôle (niveau d'accès) : " + role;
        }

        private void btnCarriers_Click(object sender, EventArgs e)
        {
            // Create and open frmCarriersList and close frmHome
            FrmCarriersList frmCarriersList = new FrmCarriersList();
            frmCarriersList.Show();
            this.Close();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            // Create and open frmClientsList and close frmHome
            FrmClientsList frmClientsList = new FrmClientsList();
            frmClientsList.Show();
            this.Close();
        }
    }
}
