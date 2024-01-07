namespace CargoFlowForms
{
    public partial class FrmLists : Form
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
            btnWarehouses = new Button();
            btnArticles = new Button();
            dgvList = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnDetails = new Button();
            flpTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
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
            flpTabs.Controls.Add(btnWarehouses);
            flpTabs.Controls.Add(btnArticles);
            flpTabs.Location = new Point(12, 12);
            flpTabs.Name = "flpTabs";
            flpTabs.Size = new Size(1016, 58);
            flpTabs.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.PowderBlue;
            btnHome.FlatAppearance.BorderColor = Color.PowderBlue;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.Location = new Point(3, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(120, 40);
            btnHome.TabIndex = 7;
            btnHome.TabStop = false;
            btnHome.Text = "Accueil";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnStock
            // 
            btnStock.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStock.BackColor = Color.PowderBlue;
            btnStock.FlatAppearance.BorderColor = Color.PowderBlue;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStock.Location = new Point(129, 3);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(120, 40);
            btnStock.TabIndex = 0;
            btnStock.TabStop = false;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = false;
            // 
            // btnDeliveries
            // 
            btnDeliveries.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeliveries.BackColor = Color.PowderBlue;
            btnDeliveries.FlatAppearance.BorderColor = Color.PowderBlue;
            btnDeliveries.FlatStyle = FlatStyle.Flat;
            btnDeliveries.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeliveries.Location = new Point(255, 3);
            btnDeliveries.Name = "btnDeliveries";
            btnDeliveries.Size = new Size(120, 40);
            btnDeliveries.TabIndex = 1;
            btnDeliveries.TabStop = false;
            btnDeliveries.Text = "Livraisons";
            btnDeliveries.UseVisualStyleBackColor = false;
            // 
            // btnCarriers
            // 
            btnCarriers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCarriers.BackColor = Color.LightCyan;
            btnCarriers.FlatAppearance.BorderColor = Color.PowderBlue;
            btnCarriers.FlatStyle = FlatStyle.Flat;
            btnCarriers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCarriers.Location = new Point(381, 3);
            btnCarriers.Name = "btnCarriers";
            btnCarriers.Size = new Size(120, 40);
            btnCarriers.TabIndex = 2;
            btnCarriers.TabStop = false;
            btnCarriers.Text = "Transporteurs";
            btnCarriers.UseVisualStyleBackColor = false;
            // 
            // btnClients
            // 
            btnClients.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClients.BackColor = Color.PowderBlue;
            btnClients.FlatAppearance.BorderColor = Color.PowderBlue;
            btnClients.FlatStyle = FlatStyle.Flat;
            btnClients.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClients.Location = new Point(507, 3);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(120, 40);
            btnClients.TabIndex = 3;
            btnClients.TabStop = false;
            btnClients.Text = "Client.es";
            btnClients.UseVisualStyleBackColor = false;
            // 
            // btnEmployees
            // 
            btnEmployees.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEmployees.BackColor = Color.PowderBlue;
            btnEmployees.FlatAppearance.BorderColor = Color.PowderBlue;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployees.Location = new Point(633, 3);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(120, 40);
            btnEmployees.TabIndex = 4;
            btnEmployees.TabStop = false;
            btnEmployees.Text = "Employé.es";
            btnEmployees.UseVisualStyleBackColor = false;
            // 
            // btnWarehouses
            // 
            btnWarehouses.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnWarehouses.BackColor = Color.PowderBlue;
            btnWarehouses.FlatAppearance.BorderColor = Color.PowderBlue;
            btnWarehouses.FlatStyle = FlatStyle.Flat;
            btnWarehouses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnWarehouses.Location = new Point(759, 3);
            btnWarehouses.Name = "btnWarehouses";
            btnWarehouses.Size = new Size(120, 40);
            btnWarehouses.TabIndex = 5;
            btnWarehouses.TabStop = false;
            btnWarehouses.Text = "Entrepôts";
            btnWarehouses.UseVisualStyleBackColor = false;
            // 
            // btnArticles
            // 
            btnArticles.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnArticles.BackColor = Color.PowderBlue;
            btnArticles.FlatAppearance.BorderColor = Color.PowderBlue;
            btnArticles.FlatStyle = FlatStyle.Flat;
            btnArticles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnArticles.Location = new Point(885, 3);
            btnArticles.Name = "btnArticles";
            btnArticles.Size = new Size(120, 40);
            btnArticles.TabIndex = 6;
            btnArticles.TabStop = false;
            btnArticles.Text = "Articles";
            btnArticles.UseVisualStyleBackColor = false;
            // 
            // dgvList
            // 
            dgvList.AllowUserToAddRows = false;
            dgvList.AllowUserToDeleteRows = false;
            dgvList.AllowUserToOrderColumns = true;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(15, 95);
            dgvList.MultiSelect = false;
            dgvList.Name = "dgvList";
            dgvList.RowTemplate.Height = 25;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(819, 473);
            dgvList.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.WhiteSmoke;
            btnAdd.FlatAppearance.BorderColor = Color.DarkGray;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(867, 260);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 40);
            btnAdd.TabIndex = 3;
            btnAdd.TabStop = false;
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.WhiteSmoke;
            btnUpdate.FlatAppearance.BorderColor = Color.DarkGray;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(867, 320);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 40);
            btnUpdate.TabIndex = 4;
            btnUpdate.TabStop = false;
            btnUpdate.Text = "Modifier";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.WhiteSmoke;
            btnDelete.FlatAppearance.BorderColor = Color.DarkGray;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(867, 380);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 40);
            btnDelete.TabIndex = 5;
            btnDelete.TabStop = false;
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnDetails
            // 
            btnDetails.BackColor = Color.WhiteSmoke;
            btnDetails.FlatAppearance.BorderColor = Color.DarkGray;
            btnDetails.FlatStyle = FlatStyle.Flat;
            btnDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetails.Location = new Point(867, 200);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(150, 40);
            btnDetails.TabIndex = 6;
            btnDetails.TabStop = false;
            btnDetails.Text = "Détails";
            btnDetails.UseVisualStyleBackColor = false;
            // 
            // FrmLists
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1039, 599);
            Controls.Add(btnDetails);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvList);
            Controls.Add(flpTabs);
            Name = "FrmLists";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLists";
            Load += FrmLists_Load;
            flpTabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpTabs;
        private Button btnStock;
        private Button btnDeliveries;
        private Button btnCarriers;
        private Button btnClients;
        private Button btnEmployees;
        private Button btnArticles;
        private DataGridView dgvList;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loadCapacityDataGridViewTextBoxColumn;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnHome;
        private Button btnDetails;
        private Button btnWarehouses;
    }
}