namespace CargoFlowForms
{
    public partial class FrmAddUpdCarrier
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
            lblName = new Label();
            lblTel = new Label();
            lblMail = new Label();
            lblCapacity = new Label();
            txtName = new TextBox();
            txtTel = new TextBox();
            txtMail = new TextBox();
            txtCapacity = new TextBox();
            btnAddUpd = new Button();
            btnCancel = new Button();
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
            lblTitle.Text = "Ajout d'un transporteur";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(246, 118);
            lblName.Name = "lblName";
            lblName.Size = new Size(159, 21);
            lblName.TabIndex = 1;
            lblName.Text = "Nom de l'entreprise *";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTel.Location = new Point(246, 158);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(91, 21);
            lblTel.TabIndex = 2;
            lblTel.Text = "Téléphone *";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail.Location = new Point(246, 198);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(59, 21);
            lblMail.TabIndex = 3;
            lblMail.Text = "Email *";
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCapacity.Location = new Point(246, 238);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(143, 21);
            lblCapacity.TabIndex = 4;
            lblCapacity.Text = "Capacité maximum";
            // 
            // txtName
            // 
            txtName.Location = new Point(433, 115);
            txtName.Name = "txtName";
            txtName.Size = new Size(334, 23);
            txtName.TabIndex = 1;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(433, 155);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(334, 23);
            txtTel.TabIndex = 2;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(433, 195);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(334, 23);
            txtMail.TabIndex = 3;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(433, 235);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(334, 23);
            txtCapacity.TabIndex = 4;
            // 
            // btnAddUpd
            // 
            btnAddUpd.BackColor = Color.WhiteSmoke;
            btnAddUpd.FlatAppearance.BorderColor = Color.DarkGray;
            btnAddUpd.FlatStyle = FlatStyle.Flat;
            btnAddUpd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddUpd.Location = new Point(433, 295);
            btnAddUpd.Name = "btnAddUpd";
            btnAddUpd.Size = new Size(150, 60);
            btnAddUpd.TabIndex = 5;
            btnAddUpd.Text = "Ajouter le transporteur";
            btnAddUpd.UseVisualStyleBackColor = false;
            btnAddUpd.Click += btnAddUpd_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.FlatAppearance.BorderColor = Color.DarkGray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(617, 295);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 60);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FrmAddUpdCarrier
            // 
            BackColor = Color.White;
            ClientSize = new Size(1039, 599);
            Controls.Add(btnCancel);
            Controls.Add(btnAddUpd);
            Controls.Add(txtCapacity);
            Controls.Add(txtMail);
            Controls.Add(txtTel);
            Controls.Add(txtName);
            Controls.Add(lblCapacity);
            Controls.Add(lblMail);
            Controls.Add(lblTel);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmAddUpdCarrier";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CargoFlow";
            Load += FrmAddUpdCarrier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label lblTel;
        private Label lblMail;
        private Label lblCapacity;
        private TextBox txtName;
        private TextBox txtTel;
        private TextBox txtMail;
        private TextBox txtCapacity;
        private Button btnAddUpd;
        private Button btnCancel;
    }
}