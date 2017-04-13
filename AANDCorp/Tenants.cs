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
            if (searchBox.Text.Trim() == "")
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
                    default:
                        break;
                }
            }
        }

        private void regTenant_Click(object sender, EventArgs e)
        {
            try
            {
                if (rgx.IsMatch(firstNBox.Text)
                    && rgx.IsMatch(lastNBox.Text)
                    && firstNBox.Text.Trim() != ""
                    && lastNBox.Text.Trim() != "")
                {
                    tenantsTableAdapter.Register(firstNBox.Text, lastNBox.Text);
                    tenantsTableAdapter.Fill(falloutShelterDBDataSet.Tenants);
                }
                else
                    throw new Exception("Invalid Name(s)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                firstNBox.Clear();
                lastNBox.Clear();
            }
        }

        private void delTenButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (editTenIdBox.Text != "")
                    if (MessageBox.Show("Are you sure?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        assignmentsTableAdapter.removeTenant(int.Parse(editTenIdBox.Text));
                        tenantsTableAdapter.delete(int.Parse(editTenIdBox.Text));
                        tenantsTableAdapter.Fill(falloutShelterDBDataSet.Tenants);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            tenantsTableAdapter.Update(falloutShelterDBDataSet);
            Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Confirm update and reset", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tenantsTableAdapter.update();
                    tenantsTableAdapter.reset();
                    tenantsTableAdapter.Fill(falloutShelterDBDataSet.Tenants);
                }
            }
            catch
            {
            }
        }
    }
}
