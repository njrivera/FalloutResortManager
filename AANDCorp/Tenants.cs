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
    public partial class Tenants : Form
    {
        Regex rgx = new Regex("^[a-zA-Z]*$");
        public Tenants()
        {
            InitializeComponent();
            searchByBox.SelectedIndex = 0;
        }

        private void Tenants_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'falloutShelterDBDataSet.Tenants' table. You can move, or remove it, as needed.
            this.tenantsTableAdapter.Fill(this.falloutShelterDBDataSet.Tenants);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
                tenantsTableAdapter.Fill(falloutShelterDBDataSet.Tenants);
            else
            {
                switch (searchByBox.SelectedItem.ToString())
                {
                    case "Tenant Id":
                        int id;
                        if (int.TryParse(searchBox.Text, out id))
                            tenantsTableAdapter.SearchByTid(falloutShelterDBDataSet.Tenants, id);
                        break;
                    case "First Name":
                        tenantsTableAdapter.SearchByFirstname(falloutShelterDBDataSet.Tenants, searchBox.Text);
                        break;
                    case "Last Name":
                        tenantsTableAdapter.SearchByLastname(falloutShelterDBDataSet.Tenants, searchBox.Text);
                        break;
                    case "Room":
                        int room;
                        if (int.TryParse(searchBox.Text, out room))
                            tenantsTableAdapter.SearchByRoom(falloutShelterDBDataSet.Tenants, room);
                        break;
                    default:
                        break;
                }
            }
        }

        private void regTenant_Click(object sender, EventArgs e)
        {
            if(rgx.IsMatch(firstNBox.Text) && rgx.IsMatch(lastNBox.Text))
            {
                FalloutShelterDBDataSet.TenantsDataTable t = tenantsTableAdapter.Register(firstNBox.Text, lastNBox.Text);
                rationsTableAdapter.register((int)t.Rows[0][t.TidColumn]);
                tenantsTableAdapter.Fill(falloutShelterDBDataSet.Tenants);
            }
            else
            {
                MessageBox.Show("Names must only compose of letters");
                firstNBox.Clear();
                lastNBox.Clear();
            }
        }

        private void delTenButton_Click(object sender, EventArgs e)
        {
            if (tenantsTableAdapter.GetTenant(int.Parse(editTenIdBox.Text)).Count != 0)
                if (MessageBox.Show("Are you sure?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    usersTableAdapter.delete(editTenIdBox.Text);
                    rationsTableAdapter.delete(int.Parse(editTenIdBox.Text));
                    tenantsTableAdapter.delete(int.Parse(editTenIdBox.Text));
                    tenantsTableAdapter.Fill(falloutShelterDBDataSet.Tenants);
                }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditTenant et = new EditTenant(int.Parse(editTenIdBox.Text), editTenFBox.Text, editTenLBox.Text);
            et.ShowDialog();
            tenantsTableAdapter.Fill(falloutShelterDBDataSet.Tenants);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
