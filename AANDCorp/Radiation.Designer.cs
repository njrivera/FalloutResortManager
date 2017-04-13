namespace AANDCorp
{
    partial class Radiation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Radiation));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roentgenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radiationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.falloutShelterDBDataSet = new AANDCorp.FalloutShelterDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.dailyLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.avgLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.radiationTableAdapter = new AANDCorp.FalloutShelterDBDataSetTableAdapters.RadiationTableAdapter();
            this.delButton = new System.Windows.Forms.Button();
            this.delRoentgenBox = new System.Windows.Forms.Label();
            this.delDateBox = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloutShelterDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.roentgenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.radiationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(298, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // roentgenDataGridViewTextBoxColumn
            // 
            this.roentgenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roentgenDataGridViewTextBoxColumn.DataPropertyName = "Roentgen";
            this.roentgenDataGridViewTextBoxColumn.HeaderText = "Roentgen";
            this.roentgenDataGridViewTextBoxColumn.Name = "roentgenDataGridViewTextBoxColumn";
            // 
            // radiationBindingSource
            // 
            this.radiationBindingSource.DataMember = "Radiation";
            this.radiationBindingSource.DataSource = this.falloutShelterDBDataSet;
            // 
            // falloutShelterDBDataSet
            // 
            this.falloutShelterDBDataSet.DataSetName = "FalloutShelterDBDataSet";
            this.falloutShelterDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Daily Difference";
            // 
            // dailyLabel
            // 
            this.dailyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dailyLabel.Location = new System.Drawing.Point(357, 39);
            this.dailyLabel.Name = "dailyLabel";
            this.dailyLabel.Size = new System.Drawing.Size(108, 23);
            this.dailyLabel.TabIndex = 2;
            this.dailyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Average Change";
            // 
            // avgLabel
            // 
            this.avgLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.avgLabel.Location = new System.Drawing.Point(357, 103);
            this.avgLabel.Name = "avgLabel";
            this.avgLabel.Size = new System.Drawing.Size(108, 23);
            this.avgLabel.TabIndex = 4;
            this.avgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Location = new System.Drawing.Point(355, 252);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 27);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // radiationTableAdapter
            // 
            this.radiationTableAdapter.ClearBeforeFill = true;
            // 
            // delButton
            // 
            this.delButton.AutoSize = true;
            this.delButton.Location = new System.Drawing.Point(412, 203);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(75, 27);
            this.delButton.TabIndex = 19;
            this.delButton.Text = "Delete";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // delRoentgenBox
            // 
            this.delRoentgenBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.delRoentgenBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radiationBindingSource, "Roentgen", true));
            this.delRoentgenBox.Location = new System.Drawing.Point(400, 177);
            this.delRoentgenBox.Name = "delRoentgenBox";
            this.delRoentgenBox.Size = new System.Drawing.Size(100, 23);
            this.delRoentgenBox.TabIndex = 28;
            this.delRoentgenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // delDateBox
            // 
            this.delDateBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.delDateBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radiationBindingSource, "Date", true));
            this.delDateBox.Location = new System.Drawing.Point(400, 149);
            this.delDateBox.Name = "delDateBox";
            this.delDateBox.Size = new System.Drawing.Size(100, 23);
            this.delDateBox.TabIndex = 27;
            this.delDateBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Roentgen:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Date:";
            // 
            // Radiation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 282);
            this.Controls.Add(this.delRoentgenBox);
            this.Controls.Add(this.delDateBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.avgLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dailyLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Radiation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radiation";
            this.Load += new System.EventHandler(this.Radiation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloutShelterDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FalloutShelterDBDataSet falloutShelterDBDataSet;
        private System.Windows.Forms.BindingSource radiationBindingSource;
        private FalloutShelterDBDataSetTableAdapters.RadiationTableAdapter radiationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roentgenDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dailyLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label avgLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Label delRoentgenBox;
        private System.Windows.Forms.Label delDateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}