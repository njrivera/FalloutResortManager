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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'falloutShelterDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.falloutShelterDBDataSet.Users);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
                    usersTableAdapter.Fill(falloutShelterDBDataSet.Users);
            else
                    usersTableAdapter.SearchUser(falloutShelterDBDataSet.Users, searchBox.Text);
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            if (crtPassBox.Text != confPassBox.Text)
            {
                MessageBox.Show("Passwords don't match");
                resetBoxes();
            }
            else if (crtRoleBox.Text != "admin"
                && crtRoleBox.Text != "watch"
                && crtRoleBox.Text != "fsa")
            {
                MessageBox.Show("Role does not exist");
                resetBoxes();
            }
            else
            {
                usersTableAdapter.create(crtRoleBox.Text, crtUserBox.Text, crtPassBox.Text);
                usersTableAdapter.Fill(falloutShelterDBDataSet.Users);
            }
        }

        private void resetBoxes()
        {
            crtUserBox.Clear();
            crtPassBox.Clear();
            confPassBox.Clear();
            crtRoleBox.Clear();
        }

        private void delUserButton_Click(object sender, EventArgs e)
        {
            if (delUserBox.Text != "")
            {
                if (MessageBox.Show("Are you sure?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    usersTableAdapter.delete(delUserBox.Text);
                    usersTableAdapter.Fill(falloutShelterDBDataSet.Users);
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
