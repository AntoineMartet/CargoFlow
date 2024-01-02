namespace CargoFlowForms
{
    partial class FrmHome : Form
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
            flpTabs.SuspendLayout();
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
            flpTabs.Size = new Size(797, 57);
            flpTabs.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.LightCyan;
            btnHome.FlatAppearance.BorderColor = Color.PowderBlue;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.Location = new Point(3, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 27);
            btnHome.TabIndex = 7;
            btnHome.Text = "Accueil";
            btnHome.UseVisualStyleBackColor = false;
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
            btnDeliveries.Text = "Livraisons";
            btnDeliveries.UseVisualStyleBackColor = false;
            // 
            // btnCarriers
            // 
            btnCarriers.AutoSize = true;
            btnCarriers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCarriers.BackColor = Color.PowderBlue;
            btnCarriers.FlatAppearance.BorderColor = Color.PowderBlue;
            btnCarriers.FlatStyle = FlatStyle.Flat;
            btnCarriers.Location = new Point(215, 3);
            btnCarriers.Name = "btnCarriers";
            btnCarriers.Size = new Size(90, 27);
            btnCarriers.TabIndex = 2;
            btnCarriers.Text = "Transporteurs";
            btnCarriers.UseVisualStyleBackColor = false;
            btnCarriers.Click += btnCarriers_Click;
            // 
            // btnClients
            // 
            btnClients.AutoSize = true;
            btnClients.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClients.BackColor = Color.PowderBlue;
            btnClients.FlatAppearance.BorderColor = Color.PowderBlue;
            btnClients.FlatStyle = FlatStyle.Flat;
            btnClients.Location = new Point(311, 3);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(64, 27);
            btnClients.TabIndex = 3;
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
            btnEmployees.Location = new Point(381, 3);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(79, 27);
            btnEmployees.TabIndex = 4;
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
            btnCategories.Location = new Point(466, 3);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(75, 27);
            btnCategories.TabIndex = 5;
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
            btnArticles.Location = new Point(547, 3);
            btnArticles.Name = "btnArticles";
            btnArticles.Size = new Size(58, 27);
            btnArticles.TabIndex = 6;
            btnArticles.Text = "Articles";
            btnArticles.UseVisualStyleBackColor = false;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(flpTabs);
            Name = "FrmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmHome";
            flpTabs.ResumeLayout(false);
            flpTabs.PerformLayout();
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
        private Button btnHome;
    }
}