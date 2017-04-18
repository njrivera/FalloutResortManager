namespace AANDCorp
{
    using System;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Radiation : Form
    {
        public Radiation()
        {
            InitializeComponent();
            updateLabels();
        }

        private void Radiation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'falloutShelterDBDataSet.Radiation' table. You can move, or remove it, as needed.
            this.radiationTableAdapter.Fill(this.falloutShelterDBDataSet.Radiation);
        }

        private void updateLabels()
        {
            if (radiationTableAdapter.getCount() > 1)
            {
                System.Data.DataTable readingTable = radiationTableAdapter.getReadings();
                List<float> readings = new List<float>();
                for (int i = 0; i < readingTable.Rows.Count; i++)
                    readings.Add((float)readingTable.Rows[i][1]);
                for (int i = readings.Count - 1; i >= 1; i--)
                    readings[i] = readings[i] - readings[i - 1];
                readings.RemoveAt(0);
                float avg = (float)Math.Round(readings.Average(), 3);
                float daily = (float)Math.Round(readings[readings.Count - 1], 3);
                
                if (daily > 0)
                    dailyLabel.Text = "+" + daily.ToString();
                else
                    dailyLabel.Text = daily.ToString();
                if (avg > 0)
                    avgLabel.Text = "+" + avg.ToString();
                else
                    avgLabel.Text = avg.ToString();
            }
            else
                dailyLabel.Text = avgLabel.Text = string.Empty;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            radiationTableAdapter.Update(falloutShelterDBDataSet);
            Close();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                radiationTableAdapter.Delete(DateTime.Parse(delDateBox.Text), float.Parse(delRoentgenBox.Text));
                updateLabels();
                radiationTableAdapter.Fill(falloutShelterDBDataSet.Radiation);
            }
        }
    }
}
