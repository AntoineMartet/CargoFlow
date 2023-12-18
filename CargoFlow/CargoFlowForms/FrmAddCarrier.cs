using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoFlowForms
{
    public class FrmAddCarrier : Form
    {
        public FrmAddCarrier()
        {
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
            lblName.Size = new Size(111, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Nom de l'entreprise";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(147, 157);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(61, 15);
            lblTel.TabIndex = 2;
            lblTel.Text = "Téléphone";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(147, 197);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(36, 15);
            lblMail.TabIndex = 3;
            lblMail.Text = "Email";
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
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(433, 295);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = true;
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
            ResumeLayout(false);
            PerformLayout();
        }

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
    }
}
