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
            else {
                switch (searchByBox.SelectedItem.ToString())
                {
                    case "Employee Id":
                        int id;
                        if (int.TryParse(searchBox.Text, out id))
                            usersTableAdapter.SearchByEid(falloutShelterDBDataSet.Users, id);
                        break;
                    case "Username":
                        usersTableAdapter.SearchByUsername(falloutShelterDBDataSet.Users, searchBox.Text);
                        break;
                    default:
                        break;
                }
            }
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(crtEidBox.Text, out id))
            {
                if(tenantsTableAdapter.GetTenant(id).Count == 0)
                {
                    MessageBox.Show("Employee does not exist");
                    resetBoxes();
                }
                else if(crtPassBox.Text != confPassBox.Text)
                {
                    MessageBox.Show("Passwords don't match");
                    resetBoxes();
                }
                else if(crtRoleBox.Text != "admin"
                    && crtRoleBox.Text != "watch"
                    && crtRoleBox.Text != "fsa")
                {
                    MessageBox.Show("Role does not exist");
                    resetBoxes();
                }
                else
                {
                    usersTableAdapter.create(id, crtRoleBox.Text, crtUserBox.Text, crtPassBox.Text);
                    usersTableAdapter.Fill(falloutShelterDBDataSet.Users);
                }
            }
        }

        private void resetBoxes()
        {
            crtEidBox.Clear();
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
                    usersTableAdapter.delete(int.Parse(delEidBox.Text));
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
