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
    /// <summary>
    /// Form to add or update a carrier
    /// </summary>
    public class FrmAddCarrier : Form
    {
        private int? id;
        private DBConnection? dbConn;
        private Label lblTitle;
        private Label lblName;
        private Label lblTel;
        private Label lblMail;
        private Label lblCapacity;
        private TextBox txtName;
        private TextBox txtTel;
        private TextBox txtMail;
        private TextBox txtCapacity;
        private Button btnAdd;
        private Button btnCancel;

        public FrmAddCarrier(int? id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblName = new Label();
            lblTel = new Label();
            lblMail = new Label();
            lblCapacity = new Label();
            txtName = new TextBox();
            txtTel = new TextBox();
            txtMail = new TextBox();
            txtCapacity = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.YellowGreen;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(801, 43);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ajout d'un transporteur";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(147, 117);
            lblName.Name = "lblName";
            lblName.Size = new Size(119, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Nom de l'entreprise *";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(147, 157);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(69, 15);
            lblTel.TabIndex = 2;
            lblTel.Text = "Téléphone *";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(147, 197);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(44, 15);
            lblMail.TabIndex = 3;
            lblMail.Text = "Email *";
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Location = new Point(147, 237);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(111, 15);
            lblCapacity.TabIndex = 4;
            lblCapacity.Text = "Capacité maximum";
            // 
            // txtName
            // 
            txtName.Location = new Point(283, 114);
            txtName.Name = "txtName";
            txtName.Size = new Size(270, 23);
            txtName.TabIndex = 5;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(283, 154);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(270, 23);
            txtTel.TabIndex = 6;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(283, 197);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(270, 23);
            txtMail.TabIndex = 7;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(283, 234);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(270, 23);
            txtCapacity.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(283, 295);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 40);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Ajouter le transporteur";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(433, 295);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FrmAddCarrier
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtCapacity);
            Controls.Add(txtMail);
            Controls.Add(txtTel);
            Controls.Add(txtName);
            Controls.Add(lblCapacity);
            Controls.Add(lblMail);
            Controls.Add(lblTel);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "FrmAddCarrier";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmAddCarrier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        /// <summary>
        /// Changes labels and fill the fields with the carrier's data if we are updating a carrier
        /// </summary>
        private void FrmAddCarrier_Load(object sender, EventArgs e)
        {
            // If we are updating a carrier, we need to change form's text and fill the fields with the carrier's data
            if (id != null)
            {
                lblTitle.Text = "Modification d'un transporteur";
                btnAdd.Text = "Modifier le transporteur";

                // Open connection to the database
                dbConn = new DBConnection();
                dbConn.OpenConnection();

                // Prepare the SQL request
                string query = "SELECT companyName, loadCapacity, email, phoneNumber FROM carriers WHERE id = " + id;

                // Execute the SQL request
                // Explicit conversion of id to int because it is nullable
                string[] record = dbConn.GetRecord(query, (int)id);

                // Close connection to the database
                dbConn.CloseConnection();

                // Fill the fields with the carrier's data
                txtName.Text = record[0];
                txtCapacity.Text = record[1];
                txtMail.Text = record[2];
                txtTel.Text = record[3];
            }
        }

        /// <summary>
        /// Close the current form and open frmCarriersList
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Open and create frmHome and close frmAddCarrier
            FrmCarriersList frmCarriersList = new FrmCarriersList();
            frmCarriersList.Show();
            this.Close();
        }

        /// <summary>
        /// Add a new carrier or update an existing carrier in the database
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtTel.Text == "" || txtMail.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.\nLes champs obligatoires sont marqués par des astérisques (*).");
            }
            else
            {
                try
                {
                    // Open connection to the database
                    dbConn = new DBConnection();
                    dbConn.OpenConnection();

                    // Prepare the capacity value (must be null or integer)
                    int? capacity = null;
                    if (txtCapacity.Text != "")
                    {
                        capacity = int.Parse(txtCapacity.Text);
                    }

                    // Prepare the SQL request
                    string query;
                    if (id == null)
                    {
                        // Add a carrier
                        query = "INSERT INTO carriers (companyName, loadCapacity, email, phoneNumber) VALUES (@companyName, @loadCapacity, @email, @phoneNumber)";
                    }
                    else
                    {
                        // Update the carrier with the given id
                        query = "UPDATE carriers SET companyName = @companyName, loadCapacity = @loadCapacity, email = @email,"
                                + " phoneNumber = @phoneNumber WHERE id = " + id;
                    }

                    // Prepare the data for the SQL request
                    Dictionary<string, string?> queryData = new Dictionary<string, string?>();
                    queryData.Add("@companyName", txtName.Text);
                    queryData.Add("@loadCapacity", capacity.HasValue ? capacity.ToString() : null);
                    queryData.Add("@email", txtMail.Text);
                    queryData.Add("@phoneNumber", txtTel.Text);
                    if (id != null)
                    {
                        queryData.Add("@id", id.ToString());
                    }

                    // Execute the SQL request
                    if (id == null)
                    {
                        dbConn.AddRecord(query, queryData);
                        MessageBox.Show("Le transporteur " + txtName.Text + " a été ajouté.");
                    }
                    else
                    {
                        dbConn.UpdateRecord(query, queryData);
                        MessageBox.Show("Le transporteur " + txtName.Text + " a été modifié.");
                    }

                    // Close connection to the database
                    dbConn.CloseConnection();

                    // Create and open frmCarriersList and close frmAddCarrier
                    FrmCarriersList frmCarriersList = new FrmCarriersList();
                    frmCarriersList.Show();
                    this.Close();
                }
                // When the capacity is not null && not an integer
                catch (FormatException fEx)
                {
                    MessageBox.Show("Erreur lors de l'ajout du transporteur. Le transporteur " + txtName.Text + " n'a pas pu être ajouté.\n\n" +
                                    "La capacité maximum doit être un nombre entier. Vous pouvez aussi laisser le champ vide.\n\nDétail : \n" + fEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout du transporteur. Le transporteur " + txtName.Text + " n'a pas pu être ajouté.\n\nDétail : \n" + ex.Message);
                }
            }
        }
    }
}
