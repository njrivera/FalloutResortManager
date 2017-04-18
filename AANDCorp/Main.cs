namespace AANDCorp
{
    using System;
    using System.Data;
    using System.Windows.Forms;

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                FalloutShelterDBDataSet.UsersDataTable userTable = new FalloutShelterDBDataSet.UsersDataTable();
                usersTableAdapter.GetUser(userTable, userBox.Text, passwordBox.Text);
                DataRow user = userTable.Rows[0];
                string role = user[userTable.RoleColumn].ToString().Trim();
                if (role == "admin")
                {
                    AdminView av = new AdminView(user[userTable.UsernameColumn].ToString());
                    av.ShowDialog();
                }
                else
                {
                    Entries en = new Entries();
                    en.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Invalid User Name or Password");
                userBox.Text = string.Empty;
                passwordBox.Text = string.Empty;
            }
            finally
            {
                userBox.Clear();
                passwordBox.Clear();
            }
        }
    }
}
