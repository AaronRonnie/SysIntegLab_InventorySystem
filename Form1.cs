using System;
using System.Windows.Forms;

namespace Gatmaitan_M1_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Load items from API here
        }

        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            // TODO: Populate text fields when a row is selected
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add clicked");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update clicked");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete clicked");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Refresh clicked");
        }
    }
}
