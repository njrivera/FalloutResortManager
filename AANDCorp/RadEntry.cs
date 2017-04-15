namespace AANDCorp
{
    using System;
    using System.Windows.Forms;

    public partial class RadEntry : Form
    {
        public RadEntry()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Today.ToShortDateString();
            if (radiationTableAdapter.getReading(dateLabel.Text) != 0)
                saveButton.Enabled = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            float ren;
            if (float.TryParse(radBox.Text, out ren))
            {
                radiationTableAdapter.saveRad(dateLabel.Text, ren);
                saveButton.Enabled = false;
            }
            else
                MessageBox.Show("Invalid Entry");
            radBox.Clear();
        }
    }
}
