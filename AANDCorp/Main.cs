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

                switch (user[userTable.RoleColumn].ToString().Trim())
                {
                    case "admin":
                        AdminView av = new AdminView();
                        av.ShowDialog();
                        break;
                    case "watch":
                        RoomEntry re = new RoomEntry((int)user[userTable.EidColumn]);
                        re.ShowDialog();
                        break;
                    case "fsa":
                        FoodEntry fe = new FoodEntry((int)user[userTable.EidColumn]);
                        fe.ShowDialog();
                        break;
                    default:
                        break;
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
                userBox.Text = "";
                passwordBox.Text = "";
            }
        }
    }
}
