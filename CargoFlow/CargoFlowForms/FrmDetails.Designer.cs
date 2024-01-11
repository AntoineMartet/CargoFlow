namespace CargoFlowForms
{
    partial class FrmDetails
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
            txtDetails = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.PowderBlue;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1040, 61);
            lblTitle.TabIndex = 1;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDetails
            // 
            txtDetails.BorderStyle = BorderStyle.None;
            txtDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDetails.Location = new Point(35, 89);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.ReadOnly = true;
            txtDetails.ScrollBars = ScrollBars.Vertical;
            txtDetails.Size = new Size(964, 488);
            txtDetails.TabIndex = 2;
            // 
            // FrmDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1039, 599);
            Controls.Add(txtDetails);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmDetails";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CargoFlow";
            Load += FrmDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtDetails;
    }
}