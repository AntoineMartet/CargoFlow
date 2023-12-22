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

namespace CargoFlowForms
{
    public partial class FrmCarriersList : Form
    {
        private List<Carrier> carriers = new List<Carrier>();
        private DBConnection? dbConn;

        public FrmCarriersList()
        {
            this.carriers = GetCarriers();
            InitializeComponent();
        }

        ///TODO : Get the carriers from the database
        private List<Carrier> GetCarriers()
        {
            List<Carrier> list = new List<Carrier>();
            dbConn = new DBConnection();
            dbConn.OpenConnection();
            list = dbConn.GetAllCarriers();
            dbConn.CloseConnection();
            return list;
        }

        private void FrmCarriersList_Load(object sender, EventArgs e)
        {
            dgvCarriers.DataSource = carriers;
            // Renommage des colonnes. Pourquoi en fonction des propriétés de l'objet Carrier et non pas de ses attributs ? À voir...
            dgvCarriers.Columns["Id"].HeaderText = "ID";
            dgvCarriers.Columns["Name"].HeaderText = "Nom";
            dgvCarriers.Columns["LoadCapacity"].HeaderText = "Capacité";
            dgvCarriers.Columns["Email"].HeaderText = "Mail";
            dgvCarriers.Columns["PhoneNumber"].HeaderText = "Téléphone";
            dgvCarriers.Columns["Id"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create and open frmAddCarrier and close frmCarriersList
            FrmAddCarrier frmAddCarrier = new FrmAddCarrier();
            frmAddCarrier.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCarriers.SelectedRows.Count == 1)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvCarriers.SelectedRows[0];

                // Get the id in the selected row
                int carrierId = (int)selectedRow.Cells["Id"].Value;

                // Delete the carrier with the id
                dbConn = new DBConnection();
                dbConn.OpenConnection();
                int result = dbConn.DeleteCarrier(carrierId);
                dbConn.CloseConnection();

                // Message box to confirm or not the deletion
                string carrierName = (string)selectedRow.Cells["Name"].Value;
                if (result == 1)
                {
                    
                    MessageBox.Show("Le transporteur " + carrierName + " a été supprimé.");
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression du transporteur.\nLe transporteur " + carrierName + " n'a pas pu être supprimé.");
                }

                // Refresh the list of carriers
                this.carriers = GetCarriers();
                dgvCarriers.DataSource = carriers;
            }
        }
    }
}
