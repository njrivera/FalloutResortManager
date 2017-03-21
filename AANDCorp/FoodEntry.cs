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
    public partial class FoodEntry : Form
    {
        private FalloutShelterDBDataSetTableAdapters.RationsTableAdapter RationsTA;

        public FoodEntry(int user)
        {
            InitializeComponent();
            RationsTA = new FalloutShelterDBDataSetTableAdapters.RationsTableAdapter();
        }

        private void entryButton_Click(object sender, EventArgs e)
        {
            try
            {
                RationsTA.daily(int.Parse(foodBox.Text), int.Parse(tenantBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                foodBox.Text = tenantBox.Text = "";
            }
        }
    }
}
