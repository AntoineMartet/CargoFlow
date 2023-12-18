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
        public FrmHome(string email, string role)
        {
            InitializeComponent();
        }

        private void btnCarriers_Click(object sender, EventArgs e)
        {
            // Open and create frmHome and close frmLogin
            FrmCarriersList frmCarriersList = new FrmCarriersList();
            frmCarriersList.Show();
            this.Close();
        }
    }
}
