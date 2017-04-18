namespace AANDCorp
{
    using System;
    using System.Windows.Forms;

    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            datePLabel.Text = dateWLabel.Text = dateRLabel.Text = DateTime.Today.ToShortDateString();
            if (waterTableAdapter.getWater(dateWLabel.Text) != 0)
                saveWater.Enabled = false;
            if (powerTableAdapter.getPower(datePLabel.Text) != 0)
                savePower.Enabled = false;
            if (rationsTableAdapter.getRations(dateRLabel.Text) != 0)
                saveRations.Enabled = false;
            getExDefWater();
            getExDefPower();
            getExDefWater();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'falloutShelterDBDataSet.Rations' table. You can move, or remove it, as needed.
            this.rationsTableAdapter.Fill(this.falloutShelterDBDataSet.Rations);
            // TODO: This line of code loads data into the 'falloutShelterDBDataSet.Power' table. You can move, or remove it, as needed.
            this.powerTableAdapter.Fill(this.falloutShelterDBDataSet.Power);
            // TODO: This line of code loads data into the 'falloutShelterDBDataSet.Water' table. You can move, or remove it, as needed.
            this.waterTableAdapter.Fill(this.falloutShelterDBDataSet.Water);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            waterTableAdapter.Update(falloutShelterDBDataSet);
            powerTableAdapter.Update(falloutShelterDBDataSet);
            rationsTableAdapter.Update(falloutShelterDBDataSet);
            Close();
        }

        private void saveWater_Click(object sender, EventArgs e)
        {
            try
            {
                waterTableAdapter.saveWater(dateWLabel.Text, float.Parse(waterBox.Text));
                saveWater.Enabled = false;
                getExDefWater();
                waterTableAdapter.Fill(falloutShelterDBDataSet.Water);
            }
            catch
            {
                MessageBox.Show("Invalid Entry");
            }
            finally
            {
                waterBox.Clear();
            }
        }

        private void savePower_Click(object sender, EventArgs e)
        {
            try
            {
                powerTableAdapter.savePower(datePLabel.Text, float.Parse(powerBox.Text));
                savePower.Enabled = false;
                getExDefPower();
                powerTableAdapter.Fill(falloutShelterDBDataSet.Power);
            }
            catch
            {
                MessageBox.Show("Invalid Entry");
            }
            finally
            {
                powerBox.Clear();
            }
        }

        private void saveRations_Click(object sender, EventArgs e)
        {
            try
            {
                rationsTableAdapter.saveRations(dateRLabel.Text, int.Parse(rationBox.Text));
                saveRations.Enabled = false;
                getExDefRations();
                rationsTableAdapter.Fill(falloutShelterDBDataSet.Rations);
            }
            catch
            {
                MessageBox.Show("Invalid Entry");
            }
            finally
            {
                rationBox.Clear();
            }
        }

        private void getExDefWater()
        {
            if (waterTableAdapter.getCount() > 1)
                try
                {
                    float w = (float)(waterTableAdapter.getWaterSum() - (waterTableAdapter.getLiterFirst() - waterTableAdapter.getLiterLast()));
                    if (w > 0)
                        exDefWater.Text = '+' + Math.Round(w, 3).ToString();
                    else
                        exDefWater.Text = w.ToString();
                }
                catch
                {
                    exDefWater.Text = string.Empty;
                }
        }

        private void getExDefPower()
        {
            if (powerTableAdapter.getCount() > 1)
                try
                {
                    float p = (float)(powerTableAdapter.getPowerSum() - (powerTableAdapter.getkWhFirst() - powerTableAdapter.getkWhLast()));
                    if (p > 0)
                        exDefPower.Text = '+' + Math.Round(p, 3).ToString();
                    else
                        exDefPower.Text = p.ToString();
                }
                catch
                {
                    exDefPower.Text = string.Empty;
                }
        }

        private void getExDefRations()
        {
            if (rationsTableAdapter.getCount() > 1)
                try
                {
                    int r = (int)(rationsTableAdapter.getFoodSum() - (rationsTableAdapter.getRationsFirst() - rationsTableAdapter.getRationsLast()));
                    if (r > 0)
                        exDefRations.Text = '+' + r.ToString();
                    else
                        exDefRations.Text = r.ToString();
                }
                catch
                {
                    exDefRations.Text = string.Empty;
                }
        }

        private void delWButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    waterTableAdapter.deleteWater(delWDateBox.Text);
                getExDefWater();
                waterTableAdapter.Fill(falloutShelterDBDataSet.Water);
                if (waterTableAdapter.getCount() < 2)
                    exDefWater.Text = string.Empty;
                if (waterTableAdapter.getWater(dateWLabel.Text) == 0)
                    saveWater.Enabled = true;
            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    powerTableAdapter.deletePower(delPDateBox.Text);
                getExDefPower();
                powerTableAdapter.Fill(falloutShelterDBDataSet.Power);
                if (powerTableAdapter.getCount() < 2)
                    exDefPower.Text = string.Empty;
                if (powerTableAdapter.getPower(datePLabel.Text) == 0)
                    savePower.Enabled = true;
            }
            catch
            {
            }
        }

        private void delRButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    rationsTableAdapter.deleteRations(delRDateBox.Text);
                getExDefRations();
                rationsTableAdapter.Fill(falloutShelterDBDataSet.Rations);
                if (rationsTableAdapter.getCount() < 2)
                    exDefRations.Text = string.Empty;
                if (rationsTableAdapter.getRations(dateRLabel.Text) == 0)
                    saveRations.Enabled = true;
            }
            catch
            {
            }
        }
    }
}
