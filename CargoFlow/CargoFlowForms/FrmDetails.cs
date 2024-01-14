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

        /// <summary>
        /// Constructor for the FrmDetails class
        /// </summary>
        /// <param name="details">The text to display</param>
        /// <param name="title">The title of the form</param>
        public FrmDetails(string details, string title)
        {
            this.details = details;
            this.title = title;
            InitializeComponent();
        }

        /// <summary>
        /// Details property
        /// </summary>
        public string Details
        {
            get { return details; }
        }

        /// <summary>
        /// Title property
        /// </summary>
        public string Title
        {
            get { return title; }
        }

        /// <summary>
        /// Fill the title and the details textbox
        /// </summary>
        private void FrmDetails_Load(object sender, EventArgs e)
        {
            lblTitle.Text = Title;
            txtDetails.Text = Details.Replace("\n", Environment.NewLine);
            // Unselecting the text in the textbox
            txtDetails.SelectionLength = 0;
        }
    }
}
