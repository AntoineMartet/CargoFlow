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
    public partial class FrmCarriersList : Form
    {
        private BindingList<Carrier> carriers = new BindingList<Carrier>();
        private DBConnection dbConn;

        public FrmCarriersList()
        {
            this.carriers = GetCarriers();
            InitializeComponent();
        }

        ///TODO : Get the carriers from the database
        private BindingList<Carrier> GetCarriers()
        {
            BindingList<Carrier> list = new BindingList<Carrier>();
            /*
            list.Add(new Carrier(1, "La Poste CH", 1000));
            list.Add(new Carrier(2, "DHL", 1200));
            list.Add(new Carrier(3, "DPD", 950));
            */
            dbConn = new DBConnection();
            dbConn.OpenConnection();
            list = dbConn.GetAllCarriers();
            return list;
        }

        private void FrmCarriersList_Load(object sender, EventArgs e)
        {
            //BindingList<Carrier> list = this.carriers;
            dgvCarriers.DataSource = carriers;
            dgvCarriers.Columns["Id"].Visible = false;
        }

    }
}
