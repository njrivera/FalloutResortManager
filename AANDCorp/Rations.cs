using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AANDCorp
{
    public partial class Rations : Form
    {
        public Rations()
        {
            InitializeComponent();
        }

        private void Rations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'falloutShelterDBDataSet.Rations' table. You can move, or remove it, as needed.
            this.rationsTableAdapter.Fill(this.falloutShelterDBDataSet.Rations);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(searchBox.Text, out id))
                rationsTableAdapter.SearchTenant(falloutShelterDBDataSet.Rations, id);
            if (searchBox.Text == "")
                rationsTableAdapter.Fill(falloutShelterDBDataSet.Rations);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm update and reset", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                rationsTableAdapter.update();
                rationsTableAdapter.reset();
            }
        }
    }
}
