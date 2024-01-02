namespace CargoFlowForms
{
    public partial class FrmCarriersList : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flpTabs = new FlowLayoutPanel();
            btnHome = new Button();
            btnStock = new Button();
            btnDeliveries = new Button();
            btnCarriers = new Button();
            btnClients = new Button();
            btnEmployees = new Button();
            btnCategories = new Button();
            btnArticles = new Button();
            dgvCarriers = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            flpTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarriers).BeginInit();
            SuspendLayout();
            // 
            // flpTabs
            // 
            flpTabs.Controls.Add(btnHome);
            flpTabs.Controls.Add(btnStock);
            flpTabs.Controls.Add(btnDeliveries);
            flpTabs.Controls.Add(btnCarriers);
            flpTabs.Controls.Add(btnClients);
            flpTabs.Controls.Add(btnEmployees);
            flpTabs.Controls.Add(btnCategories);
            flpTabs.Controls.Add(btnArticles);
            flpTabs.Location = new Point(1, 1);
            flpTabs.Name = "flpTabs";
            flpTabs.Size = new Size(796, 57);
            flpTabs.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.PowderBlue;
            btnHome.FlatAppearance.BorderColor = Color.PowderBlue;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Location = new Point(3, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 27);
            btnHome.TabIndex = 7;
            btnHome.TabStop = false;
            btnHome.Text = "Accueil";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnStock
            // 
            btnStock.AutoSize = true;
            btnStock.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStock.BackColor = Color.PowderBlue;
            btnStock.FlatAppearance.BorderColor = Color.PowderBlue;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Location = new Point(84, 3);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(48, 27);
            btnStock.TabIndex = 0;
            btnStock.TabStop = false;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = false;
            // 
            // btnDeliveries
            // 
            btnDeliveries.AutoSize = true;
            btnDeliveries.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeliveries.BackColor = Color.PowderBlue;
            btnDeliveries.FlatAppearance.BorderColor = Color.PowderBlue;
            btnDeliveries.FlatStyle = FlatStyle.Flat;
            btnDeliveries.Location = new Point(138, 3);
            btnDeliveries.Name = "btnDeliveries";
            btnDeliveries.Size = new Size(71, 27);
            btnDeliveries.TabIndex = 1;
            btnDeliveries.TabStop = false;
            btnDeliveries.Text = "Livraisons";
            btnDeliveries.UseVisualStyleBackColor = false;
            // 
            // btnCarriers
            // 
            btnCarriers.AutoSize = true;
            btnCarriers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCarriers.BackColor = Color.LightCyan;
            btnCarriers.FlatAppearance.BorderColor = Color.PowderBlue;
            btnCarriers.FlatStyle = FlatStyle.Flat;
            btnCarriers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarriers.Location = new Point(215, 3);
            btnCarriers.Name = "btnCarriers";
            btnCarriers.Size = new Size(96, 27);
            btnCarriers.TabIndex = 2;
            btnCarriers.TabStop = false;
            btnCarriers.Text = "Transporteurs";
            btnCarriers.UseVisualStyleBackColor = false;
            // 
            // btnClients
            // 
            btnClients.AutoSize = true;
            btnClients.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClients.BackColor = Color.PowderBlue;
            btnClients.FlatAppearance.BorderColor = Color.PowderBlue;
            btnClients.FlatStyle = FlatStyle.Flat;
            btnClients.Location = new Point(317, 3);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(64, 27);
            btnClients.TabIndex = 3;
            btnClients.TabStop = false;
            btnClients.Text = "Client.es";
            btnClients.UseVisualStyleBackColor = false;
            // 
            // btnEmployees
            // 
            btnEmployees.AutoSize = true;
            btnEmployees.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEmployees.BackColor = Color.PowderBlue;
            btnEmployees.FlatAppearance.BorderColor = Color.PowderBlue;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Location = new Point(387, 3);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(79, 27);
            btnEmployees.TabIndex = 4;
            btnEmployees.TabStop = false;
            btnEmployees.Text = "Employé.es";
            btnEmployees.UseVisualStyleBackColor = false;
            // 
            // btnCategories
            // 
            btnCategories.AutoSize = true;
            btnCategories.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCategories.BackColor = Color.PowderBlue;
            btnCategories.FlatAppearance.BorderColor = Color.PowderBlue;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Location = new Point(472, 3);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(75, 27);
            btnCategories.TabIndex = 5;
            btnCategories.TabStop = false;
            btnCategories.Text = "Catégories";
            btnCategories.UseVisualStyleBackColor = false;
            // 
            // btnArticles
            // 
            btnArticles.AutoSize = true;
            btnArticles.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnArticles.BackColor = Color.PowderBlue;
            btnArticles.FlatAppearance.BorderColor = Color.PowderBlue;
            btnArticles.FlatStyle = FlatStyle.Flat;
            btnArticles.Location = new Point(553, 3);
            btnArticles.Name = "btnArticles";
            btnArticles.Size = new Size(58, 27);
            btnArticles.TabIndex = 6;
            btnArticles.TabStop = false;
            btnArticles.Text = "Articles";
            btnArticles.UseVisualStyleBackColor = false;
            // 
            // dgvCarriers
            // 
            dgvCarriers.AllowUserToAddRows = false;
            dgvCarriers.AllowUserToDeleteRows = false;
            dgvCarriers.AllowUserToOrderColumns = true;
            dgvCarriers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarriers.Location = new Point(47, 95);
            dgvCarriers.MultiSelect = false;
            dgvCarriers.Name = "dgvCarriers";
            dgvCarriers.RowTemplate.Height = 25;
            dgvCarriers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarriers.Size = new Size(529, 268);
            dgvCarriers.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.WhiteSmoke;
            btnAdd.FlatAppearance.BorderColor = Color.DarkGray;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(631, 95);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 40);
            btnAdd.TabIndex = 3;
            btnAdd.TabStop = false;
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.WhiteSmoke;
            btnUpdate.FlatAppearance.BorderColor = Color.DarkGray;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(631, 152);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 40);
            btnUpdate.TabIndex = 4;
            btnUpdate.TabStop = false;
            btnUpdate.Text = "Modifier";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.WhiteSmoke;
            btnDelete.FlatAppearance.BorderColor = Color.DarkGray;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(631, 210);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 40);
            btnDelete.TabIndex = 5;
            btnDelete.TabStop = false;
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // FrmCarriersList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvCarriers);
            Controls.Add(flpTabs);
            Name = "FrmCarriersList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCarriersList";
            Load += FrmCarriersList_Load;
            flpTabs.ResumeLayout(false);
            flpTabs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarriers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpTabs;
        private Button btnStock;
        private Button btnDeliveries;
        private Button btnCarriers;
        private Button btnClients;
        private Button btnEmployees;
        private Button btnCategories;
        private Button btnArticles;
        private DataGridView dgvCarriers;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loadCapacityDataGridViewTextBoxColumn;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnHome;
    }
}