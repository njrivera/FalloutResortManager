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
    public partial class Assignments : Form
    {
        public Assignments()
        {
            InitializeComponent();
            searchByBox.SelectedIndex = 0;
        }

        private void Assignments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'falloutShelterDBDataSet.Assignments' table. You can move, or remove it, as needed.
            this.assignmentsTableAdapter.Fill(this.falloutShelterDBDataSet.Assignments);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
                assignmentsTableAdapter.Fill(falloutShelterDBDataSet.Assignments);
            else
            {
                switch (searchByBox.SelectedItem.ToString())
                {
                    case "Tenant Id":
                        int id;
                        if (int.TryParse(searchBox.Text, out id))
                            assignmentsTableAdapter.SearchByTid(falloutShelterDBDataSet.Assignments, id);
                        break;
                    case "Room Number":
                        int room;
                        if (int.TryParse(searchBox.Text, out room))
                            assignmentsTableAdapter.SearchByRoom(falloutShelterDBDataSet.Assignments, room);
                        break;
                    default:
                        break;
                }
            }
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            int id, room;
            if (int.TryParse(tidAssignBox.Text, out id) && int.TryParse(roomAssignBox.Text, out room))
            {
                FalloutShelterDBDataSet.AssignmentsDataTable at = assignmentsTableAdapter.GetAssigned(id);
                if (at.Count == 0
                    && tenantsTableAdapter.GetTenant(id).Count != 0
                    && roomsTableAdapter.GetRoom(room).Count != 0)
                {
                    assignmentsTableAdapter.assign(id, room);
                    assignmentsTableAdapter.Fill(falloutShelterDBDataSet.Assignments);
                }
                else if (at.Count != 0)
                {
                    if (MessageBox.Show("Tenant is already assigned. "
                        + "Would you like to reassign tenant to another room?",
                        "Confirm reassignment", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        assignmentsTableAdapter.removeTenant(id);
                        assignmentsTableAdapter.assign(id, room);
                        assignmentsTableAdapter.Fill(falloutShelterDBDataSet.Assignments);
                    }
                }
                else
                    MessageBox.Show("Invalid Input");
            }
            tidAssignBox.Clear();
            roomAssignBox.Clear();
        }

        private void remTenButton_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(remTenBox.Text, out id))
                if (MessageBox.Show("Are you sure?", "Confirm removal", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    assignmentsTableAdapter.removeTenant(id);
                    assignmentsTableAdapter.Fill(falloutShelterDBDataSet.Assignments);
                }
        }

        private void remRoomButton_Click(object sender, EventArgs e)
        {
            int room;
            if (int.TryParse(remRoomBox.Text, out room))
                if (MessageBox.Show("Are you sure?", "Confirm removal", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    assignmentsTableAdapter.removeRoom(room);
                    assignmentsTableAdapter.Fill(falloutShelterDBDataSet.Assignments);
                }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
