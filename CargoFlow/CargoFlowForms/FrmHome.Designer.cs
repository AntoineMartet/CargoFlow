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
            // btnStock
            // 
            btnStock.AutoSize = true;
            btnStock.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStock.Location = new Point(3, 3);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(46, 25);
            btnStock.TabIndex = 0;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = true;
            // 
            // btnDeliveries
            // 
            btnDeliveries.AutoSize = true;
            btnDeliveries.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeliveries.Location = new Point(55, 3);
            btnDeliveries.Name = "btnDeliveries";
            btnDeliveries.Size = new Size(69, 25);
            btnDeliveries.TabIndex = 1;
            btnDeliveries.Text = "Livraisons";
            btnDeliveries.UseVisualStyleBackColor = true;
            // 
            // btnCarriers
            // 
            btnCarriers.AutoSize = true;
            btnCarriers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCarriers.Location = new Point(130, 3);
            btnCarriers.Name = "btnCarriers";
            btnCarriers.Size = new Size(88, 25);
            btnCarriers.TabIndex = 2;
            btnCarriers.Text = "Transporteurs";
            btnCarriers.UseVisualStyleBackColor = true;
            btnCarriers.Click += btnCarriers_Click;
            // 
            // btnClients
            // 
            btnClients.AutoSize = true;
            btnClients.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClients.Location = new Point(224, 3);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(62, 25);
            btnClients.TabIndex = 3;
            btnClients.Text = "Client.es";
            btnClients.UseVisualStyleBackColor = true;
            // 
            // btnEmployees
            // 
            btnEmployees.AutoSize = true;
            btnEmployees.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEmployees.Location = new Point(292, 3);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(77, 25);
            btnEmployees.TabIndex = 4;
            btnEmployees.Text = "Employé.es";
            btnEmployees.UseVisualStyleBackColor = true;
            // 
            // btnCategories
            // 
            btnCategories.AutoSize = true;
            btnCategories.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCategories.Location = new Point(375, 3);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(73, 25);
            btnCategories.TabIndex = 5;
            btnCategories.Text = "Catégories";
            btnCategories.UseVisualStyleBackColor = true;
            // 
            // btnArticles
            // 
            btnArticles.AutoSize = true;
            btnArticles.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnArticles.Location = new Point(454, 3);
            btnArticles.Name = "btnArticles";
            btnArticles.Size = new Size(56, 25);
            btnArticles.TabIndex = 6;
            btnArticles.Text = "Articles";
            btnArticles.UseVisualStyleBackColor = true;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpTabs);
            Name = "FrmHome";
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
    }
}