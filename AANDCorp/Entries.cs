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
    public partial class Entries : Form
    {
        public Entries()
        {
            InitializeComponent();
        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            RoomEntry r = new RoomEntry();
            r.ShowDialog();
        }

        private void rationsButton_Click(object sender, EventArgs e)
        {
            FoodEntry f = new FoodEntry();
            f.ShowDialog();
        }

        private void radiationButton_Click(object sender, EventArgs e)
        {
            RadEntry rd = new RadEntry();
            rd.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
