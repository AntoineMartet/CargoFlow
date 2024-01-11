namespace CargoFlowForms
{
    public partial class FrmLogin : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLoginMessage = new Label();
            lblMail = new Label();
            lblPassword = new Label();
            txtMail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblLoginMessage
            // 
            lblLoginMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginMessage.Location = new Point(130, 144);
            lblLoginMessage.Name = "lblLoginMessage";
            lblLoginMessage.Size = new Size(279, 58);
            lblLoginMessage.TabIndex = 0;
            lblLoginMessage.Text = "Veuillez vous connectez pour accéder aux ressources de votre entreprise.";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail.Location = new Point(130, 225);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(48, 21);
            lblMail.TabIndex = 1;
            lblMail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(130, 270);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(102, 21);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mot de passe";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(246, 227);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(155, 23);
            txtMail.TabIndex = 3;
            txtMail.KeyUp += txtMail_KeyUp;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(246, 272);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(155, 23);
            txtPassword.TabIndex = 4;
            txtPassword.KeyUp += txtPassword_KeyUp;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.WhiteSmoke;
            btnLogin.FlatAppearance.BorderColor = Color.DarkGray;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(246, 317);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(155, 32);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Se connecter";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cargoflow_01_white;
            pictureBox1.Location = new Point(130, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(542, 404);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtMail);
            Controls.Add(lblPassword);
            Controls.Add(lblMail);
            Controls.Add(lblLoginMessage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CargoFlow";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoginMessage;
        private Label lblMail;
        private Label lblPassword;
        private TextBox txtMail;
        private TextBox txtPassword;
        private Button btnLogin;
        private PictureBox pictureBox1;
    }
}