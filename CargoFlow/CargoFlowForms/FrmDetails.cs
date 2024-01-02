using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoFlowForms
{
    public partial class FrmDetails : Form
    {
        private string details;
        private string title;

        public FrmDetails(string details, string title)
        {
            this.details = details;
            this.title = title;
            InitializeComponent();
        }

        // Properties
        public string Details
        {
            get { return details; }
        }
        public string Title
        {
            get { return title; }
        }

        private void FrmDetails_Load(object sender, EventArgs e)
        {
            lblTitle.Text = Title;
            txtDetails.Text = Details.Replace("\n", Environment.NewLine);
            // Unselecting the text in the textbox
            txtDetails.SelectionLength = 0;
        }
    }
}
