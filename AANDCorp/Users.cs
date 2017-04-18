namespace AANDCorp
{
    using System;
    using System.Windows.Forms;

    public partial class Users : Form
    {
        private string user;

        public Users(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'falloutShelterDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.falloutShelterDBDataSet.Users);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text.Trim() == string.Empty)
                usersTableAdapter.Fill(falloutShelterDBDataSet.Users);
            else
                usersTableAdapter.SearchUser(falloutShelterDBDataSet.Users, searchBox.Text);
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (crtUserBox.Text.Trim() == string.Empty)
                    throw new Exception("Requires Username");
                else if (crtPassBox.Text != confPassBox.Text)
                    throw new Exception("Passwords don't match");
                else if (crtRoleBox.Text != "admin" && crtRoleBox.Text != "employee")
                    throw new Exception("Role does not exist");
                else
                {
                    usersTableAdapter.create(crtRoleBox.Text, crtUserBox.Text, crtPassBox.Text);
                    usersTableAdapter.Fill(falloutShelterDBDataSet.Users);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                resetBoxes();
            }
        }

        private void resetBoxes()
        {
            crtUserBox.Clear();
            crtPassBox.Clear();
            confPassBox.Clear();
            crtRoleBox.Clear();
        }

        private void delUserButton_Click(object sender, EventArgs e)
        {
            if (delUserBox.Text != string.Empty)
            {
                if (MessageBox.Show("Are you sure?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (delUserBox.Text == user)
                        MessageBox.Show("Can't delete current user!");
                    else
                    {
                        usersTableAdapter.delete(delUserBox.Text);
                        usersTableAdapter.Fill(falloutShelterDBDataSet.Users);
                    }
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            usersTableAdapter.Update(falloutShelterDBDataSet);
            Close();
        }
    }
}
