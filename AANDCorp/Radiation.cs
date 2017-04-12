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
    public partial class Radiation : Form
    {
        public Radiation()
        {
            InitializeComponent();
            if (radiationTableAdapter.getCount() > 1)
            {
                float daily = (float)(radiationTableAdapter.getLastReading() - radiationTableAdapter.getSecondReading());
                float avg = (float)(radiationTableAdapter.getLastReading() - radiationTableAdapter.getAverage());
                if (daily > 0)
                    dailyLabel.Text = "+" + daily.ToString();
                else
                    dailyLabel.Text = daily.ToString();
                if (avg > 0)
                    avgLabel.Text = "+" + avg.ToString();
                else
                    avgLabel.Text = avg.ToString();
            }
        }

        private void Radiation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'falloutShelterDBDataSet.Radiation' table. You can move, or remove it, as needed.
            this.radiationTableAdapter.Fill(this.falloutShelterDBDataSet.Radiation);

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            radiationTableAdapter.Update(falloutShelterDBDataSet);
            Close();
        }
    }
}
