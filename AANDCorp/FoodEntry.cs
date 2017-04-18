namespace AANDCorp
{
    using System;
    using System.Windows.Forms;

    public partial class FoodEntry : Form
    {
        public FoodEntry()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(tenantsTableAdapter.getTenant(int.Parse(tenantBox.Text)) == 0)
                    throw new Exception();
                tenantsTableAdapter.daily(int.Parse(foodBox.Text), int.Parse(tenantBox.Text));
            }
            catch
            {
                MessageBox.Show("Invalid Input");
            }
            finally
            {
                foodBox.Clear();
                tenantBox.Clear();
            }
        }
    }
}
