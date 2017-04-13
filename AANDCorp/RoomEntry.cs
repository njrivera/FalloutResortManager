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
                float water = (float)Math.Round(decimal.Parse(waterBox.Text), 3);
                float power = (float)Math.Round(decimal.Parse(powerBox.Text), 3);
                roomsTableAdapter.daily(water, power, int.Parse(roomBox.Text));
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
