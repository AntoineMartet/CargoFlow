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
            dbConn = new DBConnection();
            dbConn.OpenConnection();
            list = dbConn.GetAllCarriers();
            return list;
        }

        private void FrmCarriersList_Load(object sender, EventArgs e)
        {
            dgvCarriers.DataSource = carriers;
            // Renommage des colonnes. Pourquoi en fonction des propriétés de l'objet Carrier ? À voir...
            dgvCarriers.Columns["Id"].HeaderText = "ID";
            dgvCarriers.Columns["Name"].HeaderText = "Nom";
            dgvCarriers.Columns["LoadCapacity"].HeaderText = "Capacité";
            dgvCarriers.Columns["Id"].Visible = false;

            /*
            // Add a column for deleting rows
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "";
            deleteColumn.Text = "Supprimer";
            deleteColumn.UseColumnTextForButtonValue = true;
            dgvCarriers.Columns.Add(deleteColumn);

            // Add a column for updating rows
            DataGridViewButtonColumn updateColumn = new DataGridViewButtonColumn();
            updateColumn.HeaderText = "";
            updateColumn.Text = "Modifier";
            updateColumn.UseColumnTextForButtonValue = true;
            dgvCarriers.Columns.Add(updateColumn);
            */
        }

        // Create the event handler method
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Your code logic here
            // This method will be executed when the button is clicked
        }

    }
}
