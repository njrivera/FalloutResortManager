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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'falloutShelterDBDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.falloutShelterDBDataSet.Rooms);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int room;
            if (int.TryParse(searchBox.Text, out room))
                roomsTableAdapter.SearchRoom(falloutShelterDBDataSet.Rooms, room);
            if (searchBox.Text == "")
                roomsTableAdapter.Fill(falloutShelterDBDataSet.Rooms);
        }

        private void regRoomButton_Click(object sender, EventArgs e)
        {
            int room;
            if (int.TryParse(regRoomBox.Text, out room)
                && roomsTableAdapter.GetRoom(room).Count == 0)
            {
                roomsTableAdapter.register(room);
                roomsTableAdapter.Fill(falloutShelterDBDataSet.Rooms);
            }
        }

        private void delRoomButton_Click(object sender, EventArgs e)
        {
            int room;
            if (int.TryParse(delRoomBox.Text, out room)
                && roomsTableAdapter.GetRoom(room).Count != 0)
            {
                if (MessageBox.Show("Are you sure?", "Confirm deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    roomsTableAdapter.delete(room);
                    roomsTableAdapter.Fill(falloutShelterDBDataSet.Rooms);
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm update and reset", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                roomsTableAdapter.update();
                roomsTableAdapter.reset();
                roomsTableAdapter.Fill(falloutShelterDBDataSet.Rooms);
            }
        }
    }
}
