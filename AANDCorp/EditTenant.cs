using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AANDCorp
{
    public partial class EditTenant : Form
    {
        Regex rgx = new Regex("^[a-zA-Z]*$");
        int tid;
        string firstname, lastname;

        public EditTenant(int tid, string firstname, string lastname)
        {
            InitializeComponent();
            this.tid = tid;
            firstBox.Text = this.firstname = firstname;
            lastBox.Text = this.lastname = lastname;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (rgx.IsMatch(firstBox.Text) && rgx.IsMatch(lastBox.Text))
            {
                tenantsTableAdapter.edit(firstBox.Text, lastBox.Text, tid);
                firstname = firstBox.Text;
                lastname = lastBox.Text;
            }
            else
            {
                MessageBox.Show("Names must only compose of letters");
                firstBox.Text = firstname;
                lastBox.Text = lastname;
            }
            saveButton.Enabled = false;
        }

        private void firstBox_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
        }

        private void lastBox_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
        }
    }
}
