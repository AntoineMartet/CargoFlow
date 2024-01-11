namespace CargoFlowForms
{
    public partial class FrmAddUpdClient
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
            lblTitle = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblEmail = new Label();
            lblStreet = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtEmail = new TextBox();
            txtStreet = new TextBox();
            btnAddUpd = new Button();
            btnCancel = new Button();
            txtStreetNumber = new TextBox();
            txtCity = new TextBox();
            lblStreetNumber = new Label();
            lblCity = new Label();
            txtPostalCode = new TextBox();
            lblPostalCode = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.PowderBlue;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1040, 61);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ajout d'un·e client·e";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.Location = new Point(246, 118);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(56, 21);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Nom *";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.Location = new Point(246, 158);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(76, 21);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "Prénom *";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(246, 198);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 21);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email *";
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStreet.Location = new Point(246, 238);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(48, 21);
            lblStreet.TabIndex = 4;
            lblStreet.Text = "Rue *";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(433, 115);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(334, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(433, 155);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(334, 23);
            txtFirstName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(433, 195);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(334, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(433, 235);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(334, 23);
            txtStreet.TabIndex = 4;
            // 
            // btnAddUpd
            // 
            btnAddUpd.BackColor = Color.WhiteSmoke;
            btnAddUpd.FlatAppearance.BorderColor = Color.DarkGray;
            btnAddUpd.FlatStyle = FlatStyle.Flat;
            btnAddUpd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddUpd.Location = new Point(433, 407);
            btnAddUpd.Name = "btnAddUpd";
            btnAddUpd.Size = new Size(150, 60);
            btnAddUpd.TabIndex = 8;
            btnAddUpd.Text = "Ajouter le client";
            btnAddUpd.UseVisualStyleBackColor = false;
            btnAddUpd.Click += btnAddUpd_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.FlatAppearance.BorderColor = Color.DarkGray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(617, 407);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 60);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtStreetNumber
            // 
            txtStreetNumber.Location = new Point(433, 275);
            txtStreetNumber.Name = "txtStreetNumber";
            txtStreetNumber.Size = new Size(334, 23);
            txtStreetNumber.TabIndex = 5;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(433, 315);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(334, 23);
            txtCity.TabIndex = 6;
            // 
            // lblStreetNumber
            // 
            lblStreetNumber.AutoSize = true;
            lblStreetNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStreetNumber.Location = new Point(246, 278);
            lblStreetNumber.Name = "lblStreetNumber";
            lblStreetNumber.Size = new Size(87, 21);
            lblStreetNumber.TabIndex = 13;
            lblStreetNumber.Text = "N° de rue *";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCity.Location = new Point(246, 318);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(94, 21);
            lblCity.TabIndex = 14;
            lblCity.Text = "Commune *";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(433, 355);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(334, 23);
            txtPostalCode.TabIndex = 7;
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPostalCode.Location = new Point(246, 358);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(51, 21);
            lblPostalCode.TabIndex = 16;
            lblPostalCode.Text = "NPA *";
            // 
            // FrmAddUpdClient
            // 
            BackColor = Color.White;
            ClientSize = new Size(1039, 599);
            Controls.Add(lblPostalCode);
            Controls.Add(txtPostalCode);
            Controls.Add(lblCity);
            Controls.Add(lblStreetNumber);
            Controls.Add(txtCity);
            Controls.Add(txtStreetNumber);
            Controls.Add(btnCancel);
            Controls.Add(btnAddUpd);
            Controls.Add(txtStreet);
            Controls.Add(txtEmail);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lblStreet);
            Controls.Add(lblEmail);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmAddUpdClient";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmAddUpdClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblEmail;
        private Label lblStreet;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtEmail;
        private TextBox txtStreet;
        private Button btnAddUpd;
        private Button btnCancel;
        private TextBox txtStreetNumber;
        private TextBox txtCity;
        private Label lblStreetNumber;
        private Label lblCity;
        private TextBox txtPostalCode;
        private Label lblPostalCode;
    }
}