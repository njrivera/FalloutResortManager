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
                if(role == "admin")
                {
                    AdminView av = new AdminView();
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
                userBox.Text = "";
                passwordBox.Text = "";
            }
            finally
            {
                userBox.Clear();
                passwordBox.Clear();
            }
        }
    }
}
