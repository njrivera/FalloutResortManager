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
    public partial class RoomEntry : Form
    {
        public RoomEntry()
        {
            InitializeComponent();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            try
            {
                roomsTableAdapter.daily(float.Parse(waterBox.Text), float.Parse(powerBox.Text), int.Parse(roomBox.Text));
            }
            catch
            {
                MessageBox.Show("Invalid Input");
            }
            finally
            {
                waterBox.Clear();
                powerBox.Clear();
                roomBox.Clear();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
