﻿using System.Drawing;

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
            btnWarehouses = new Button();
            btnArticles = new Button();
            lblHeadline = new Label();
            picLogo = new PictureBox();
            lblSession = new Label();
            btnLogout = new Button();
            flpTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
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
            flpTabs.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.LightCyan;
            btnHome.FlatAppearance.BorderColor = Color.PowderBlue;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.Location = new Point(3, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(120, 40);
            btnHome.TabIndex = 0;
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
            btnStock.TabIndex = 1;
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
            btnDeliveries.TabIndex = 2;
            btnDeliveries.Text = "Livraisons";
            btnDeliveries.UseVisualStyleBackColor = false;
            // 
            // btnCarriers
            // 
            btnCarriers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCarriers.BackColor = Color.PowderBlue;
            btnCarriers.FlatAppearance.BorderColor = Color.PowderBlue;
            btnCarriers.FlatStyle = FlatStyle.Flat;
            btnCarriers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCarriers.Location = new Point(381, 3);
            btnCarriers.Name = "btnCarriers";
            btnCarriers.Size = new Size(120, 40);
            btnCarriers.TabIndex = 3;
            btnCarriers.Text = "Transporteurs";
            btnCarriers.UseVisualStyleBackColor = false;
            btnCarriers.Click += btnCarriers_Click;
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
            btnClients.TabIndex = 4;
            btnClients.Text = "Client.es";
            btnClients.UseVisualStyleBackColor = false;
            btnClients.Click += btnClients_Click;
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
            btnEmployees.TabIndex = 5;
            btnEmployees.Text = "Employé.es";
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
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
            btnWarehouses.TabIndex = 6;
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
            btnArticles.TabIndex = 7;
            btnArticles.Text = "Articles";
            btnArticles.UseVisualStyleBackColor = false;
            // 
            // lblHeadline
            // 
            lblHeadline.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeadline.Location = new Point(298, 281);
            lblHeadline.Name = "lblHeadline";
            lblHeadline.Size = new Size(444, 69);
            lblHeadline.TabIndex = 1;
            lblHeadline.Text = "Optimisez votre chaîne logistique avec CargoFlow, votre partenaire pour une gestion fluide de vos opérations, des clients aux livraisons.";
            lblHeadline.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.cargoflow_01_white;
            picLogo.InitialImage = null;
            picLogo.Location = new Point(255, 128);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(498, 154);
            picLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // lblSession
            // 
            lblSession.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSession.Location = new Point(298, 394);
            lblSession.Name = "lblSession";
            lblSession.Size = new Size(444, 83);
            lblSession.TabIndex = 3;
            lblSession.Text = "Utilisateur et rôle : ";
            lblSession.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.WhiteSmoke;
            btnLogout.FlatAppearance.BorderColor = Color.DarkGray;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(444, 480);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 40);
            btnLogout.TabIndex = 10;
            btnLogout.TabStop = false;
            btnLogout.Text = "Déconnexion";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1039, 599);
            Controls.Add(btnLogout);
            Controls.Add(lblSession);
            Controls.Add(picLogo);
            Controls.Add(lblHeadline);
            Controls.Add(flpTabs);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmHome";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CargoFlow";
            Load += FrmHome_Load;
            flpTabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox picLogo = new PictureBox();
        private FlowLayoutPanel flpTabs;
        private Button btnStock;
        private Button btnDeliveries;
        private Button btnCarriers;
        private Button btnClients;
        private Button btnEmployees;
        private Button btnWarehouses;
        private Button btnArticles;
        private Button btnHome;
        private Label lblHeadline;
        private Label lblSession;
        private Button btnLogout;
    }
}