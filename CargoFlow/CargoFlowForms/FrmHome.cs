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
        // Email and role should not be optional in future versions
        public FrmHome(string email = "", string role = "")
        {
            InitializeComponent();
        }

        private void btnCarriers_Click(object sender, EventArgs e)
        {
            // Create and open frmCarriersList and close frmHome
            FrmCarriersList frmCarriersList = new FrmCarriersList();
            frmCarriersList.Show();
            this.Close();
        }
    }
}
