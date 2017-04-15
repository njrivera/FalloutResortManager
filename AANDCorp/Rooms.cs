namespace AANDCorp
{
    using System;
    using System.Windows.Forms;

    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
            searchByBox.SelectedIndex = 0;
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'falloutShelterDBDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.falloutShelterDBDataSet.Rooms);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int room;
            if (searchBox.Text.Trim() == string.Empty)
                roomsTableAdapter.Fill(falloutShelterDBDataSet.Rooms);
            else if (searchByBox.SelectedItem.ToString() == "Room Number")
            {
                if (int.TryParse(searchBox.Text, out room))
                    roomsTableAdapter.SearchRoomByNum(falloutShelterDBDataSet.Rooms, room);
            }
            else
                roomsTableAdapter.SearchRoomByType(falloutShelterDBDataSet.Rooms, searchBox.Text);
        }

        private void regRoomButton_Click(object sender, EventArgs e)
        {
            try
            {
                int room;
                if (!int.TryParse(regRoomBox.Text, out room))
                    throw new Exception("Invalid Room Number");
                else if (roomsTableAdapter.getRoom(room) != 0)
                    throw new Exception("Room Already Exists");
                else if (regTypeBox.Text.Trim() == string.Empty)
                    throw new Exception("Requires Type");
                else
                {
                    roomsTableAdapter.register(room, regTypeBox.Text);
                    roomsTableAdapter.Fill(falloutShelterDBDataSet.Rooms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                regRoomBox.Clear();
                regTypeBox.Clear();
            }
        }

        private void delRoomButton_Click(object sender, EventArgs e)
        {
            int room;
            if (int.TryParse(delRoomBox.Text, out room))
            {
                if (MessageBox.Show("Are you sure?", "Confirm deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    assignmentsTableAdapter.removeRoom(room);
                    roomsTableAdapter.delete(room);
                    roomsTableAdapter.Fill(falloutShelterDBDataSet.Rooms);
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            roomsTableAdapter.Update(falloutShelterDBDataSet);
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
