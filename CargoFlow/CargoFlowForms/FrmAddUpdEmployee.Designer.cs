namespace CargoFlowForms
{
    partial class FrmAddUpdEmployee
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
            lblPassword = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnAddUpd = new Button();
            btnCancel = new Button();
            txtPhoneNumber = new TextBox();
            txtRole = new TextBox();
            lblPhoneNumber = new Label();
            lblRole = new Label();
            lblEmployeeNumber = new Label();
            txtEmployeeNumber = new TextBox();
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
            lblTitle.Text = "Ajout d'un·e employé·e";
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
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(246, 238);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(113, 21);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Mot de passe *";
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
            // txtPassword
            // 
            txtPassword.Location = new Point(433, 235);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(334, 23);
            txtPassword.TabIndex = 4;
            // 
            // btnAddUpd
            // 
            btnAddUpd.BackColor = Color.WhiteSmoke;
            btnAddUpd.FlatAppearance.BorderColor = Color.DarkGray;
            btnAddUpd.FlatStyle = FlatStyle.Flat;
            btnAddUpd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddUpd.Location = new Point(433, 406);
            btnAddUpd.Name = "btnAddUpd";
            btnAddUpd.Size = new Size(154, 60);
            btnAddUpd.TabIndex = 8;
            btnAddUpd.Text = "Ajouter l'employé·e";
            btnAddUpd.UseVisualStyleBackColor = false;
            btnAddUpd.Click += btnAddUpd_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.FlatAppearance.BorderColor = Color.DarkGray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(617, 406);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 60);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(433, 275);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(334, 23);
            txtPhoneNumber.TabIndex = 5;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(433, 315);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(334, 23);
            txtRole.TabIndex = 6;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNumber.Location = new Point(246, 278);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(173, 21);
            lblPhoneNumber.TabIndex = 13;
            lblPhoneNumber.Text = "Numéro de téléphone *";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRole.Location = new Point(246, 318);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(52, 21);
            lblRole.TabIndex = 14;
            lblRole.Text = "Rôle *";
            // 
            // lblEmployeeNumber
            // 
            lblEmployeeNumber.AutoSize = true;
            lblEmployeeNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmployeeNumber.Location = new Point(246, 357);
            lblEmployeeNumber.Name = "lblEmployeeNumber";
            lblEmployeeNumber.Size = new Size(167, 21);
            lblEmployeeNumber.TabIndex = 15;
            lblEmployeeNumber.Text = "Numéro d'employé·e *";
            // 
            // txtEmployeeNumber
            // 
            txtEmployeeNumber.Location = new Point(433, 357);
            txtEmployeeNumber.Name = "txtEmployeeNumber";
            txtEmployeeNumber.Size = new Size(334, 23);
            txtEmployeeNumber.TabIndex = 7;
            // 
            // FrmAddUpdEmployee
            // 
            BackColor = Color.White;
            ClientSize = new Size(1039, 599);
            Controls.Add(txtEmployeeNumber);
            Controls.Add(lblEmployeeNumber);
            Controls.Add(lblRole);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtRole);
            Controls.Add(txtPhoneNumber);
            Controls.Add(btnCancel);
            Controls.Add(btnAddUpd);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmAddUpdEmployee";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CargoFlow";
            Load += FrmAddUpdEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnAddUpd;
        private Button btnCancel;
        private TextBox txtPhoneNumber;
        private TextBox txtRole;
        private Label lblPhoneNumber;
        private Label lblRole;
        private Label lblEmployeeNumber;
        private TextBox txtEmployeeNumber;
    }
}