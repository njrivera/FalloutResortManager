namespace AANDCorp
{
    using System;
    using System.Windows.Forms;

    public partial class AdminView : Form
    {
        private string user;

        public AdminView(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tenants t = new Tenants();
            t.ShowDialog();
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            Assignments a = new Assignments();
            a.ShowDialog();
        }

        private void roomsButton_Click(object sender, EventArgs e)
        {
            Rooms r = new Rooms();
            r.ShowDialog();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            Users u = new Users(user);
            u.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resourceButton_Click(object sender, EventArgs e)
        {
            Inventory i = new Inventory();
            i.ShowDialog();
        }

        private void radButton_Click(object sender, EventArgs e)
        {
            Radiation ra = new Radiation();
            ra.ShowDialog();
        }
    }
}
