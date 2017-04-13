namespace AANDCorp
{
    partial class Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            this.delRoomButton = new System.Windows.Forms.Button();
            this.delRoomBox = new System.Windows.Forms.TextBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.falloutShelterDBDataSet = new AANDCorp.FalloutShelterDBDataSet();
            this.regRoomButton = new System.Windows.Forms.Button();
            this.regRoomBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalWater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyWaterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyPowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.regTypeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delTypeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roomsTableAdapter = new AANDCorp.FalloutShelterDBDataSetTableAdapters.RoomsTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.searchByBox = new System.Windows.Forms.ComboBox();
            this.assignmentsTableAdapter = new AANDCorp.FalloutShelterDBDataSetTableAdapters.AssignmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloutShelterDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // delRoomButton
            // 
            this.delRoomButton.AutoSize = true;
            this.delRoomButton.Location = new System.Drawing.Point(639, 199);
            this.delRoomButton.Name = "delRoomButton";
            this.delRoomButton.Size = new System.Drawing.Size(112, 27);
            this.delRoomButton.TabIndex = 30;
            this.delRoomButton.Text = "Delete Room";
            this.delRoomButton.UseVisualStyleBackColor = true;
            this.delRoomButton.Click += new System.EventHandler(this.delRoomButton_Click);
            // 
            // delRoomBox
            // 
            this.delRoomBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "RoomNum", true));
            this.delRoomBox.Location = new System.Drawing.Point(680, 143);
            this.delRoomBox.Name = "delRoomBox";
            this.delRoomBox.ReadOnly = true;
            this.delRoomBox.Size = new System.Drawing.Size(87, 22);
            this.delRoomBox.TabIndex = 29;
            this.delRoomBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.falloutShelterDBDataSet;
            // 
            // falloutShelterDBDataSet
            // 
            this.falloutShelterDBDataSet.DataSetName = "FalloutShelterDBDataSet";
            this.falloutShelterDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regRoomButton
            // 
            this.regRoomButton.AutoSize = true;
            this.regRoomButton.Location = new System.Drawing.Point(639, 99);
            this.regRoomButton.Name = "regRoomButton";
            this.regRoomButton.Size = new System.Drawing.Size(112, 27);
            this.regRoomButton.TabIndex = 27;
            this.regRoomButton.Text = "Register Room";
            this.regRoomButton.UseVisualStyleBackColor = true;
            this.regRoomButton.Click += new System.EventHandler(this.regRoomButton_Click);
            // 
            // regRoomBox
            // 
            this.regRoomBox.Location = new System.Drawing.Point(680, 43);
            this.regRoomBox.Name = "regRoomBox";
            this.regRoomBox.Size = new System.Drawing.Size(87, 22);
            this.regRoomBox.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(571, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Room Number:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumDataGridViewTextBoxColumn,
            this.Type,
            this.TotalWater,
            this.TotalPower,
            this.dailyWaterDataGridViewTextBoxColumn,
            this.dailyPowerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roomsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(544, 252);
            this.dataGridView1.TabIndex = 31;
            // 
            // roomNumDataGridViewTextBoxColumn
            // 
            this.roomNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roomNumDataGridViewTextBoxColumn.DataPropertyName = "RoomNum";
            this.roomNumDataGridViewTextBoxColumn.HeaderText = "RoomNum";
            this.roomNumDataGridViewTextBoxColumn.Name = "roomNumDataGridViewTextBoxColumn";
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // TotalWater
            // 
            this.TotalWater.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalWater.DataPropertyName = "TotalWater";
            this.TotalWater.HeaderText = "TotalWater";
            this.TotalWater.Name = "TotalWater";
            // 
            // TotalPower
            // 
            this.TotalPower.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPower.DataPropertyName = "TotalPower";
            this.TotalPower.HeaderText = "TotalPower";
            this.TotalPower.Name = "TotalPower";
            // 
            // dailyWaterDataGridViewTextBoxColumn
            // 
            this.dailyWaterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dailyWaterDataGridViewTextBoxColumn.DataPropertyName = "DailyWater";
            this.dailyWaterDataGridViewTextBoxColumn.HeaderText = "DailyWater";
            this.dailyWaterDataGridViewTextBoxColumn.Name = "dailyWaterDataGridViewTextBoxColumn";
            // 
            // dailyPowerDataGridViewTextBoxColumn
            // 
            this.dailyPowerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dailyPowerDataGridViewTextBoxColumn.DataPropertyName = "DailyPower";
            this.dailyPowerDataGridViewTextBoxColumn.HeaderText = "DailyPower";
            this.dailyPowerDataGridViewTextBoxColumn.Name = "dailyPowerDataGridViewTextBoxColumn";
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Location = new System.Drawing.Point(106, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 27);
            this.searchButton.TabIndex = 33;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(88, 22);
            this.searchBox.TabIndex = 32;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Location = new System.Drawing.Point(701, 268);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 27);
            this.closeButton.TabIndex = 34;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(562, 243);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(133, 52);
            this.resetButton.TabIndex = 35;
            this.resetButton.Text = "Transfer Daily to Total";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // regTypeBox
            // 
            this.regTypeBox.Location = new System.Drawing.Point(621, 71);
            this.regTypeBox.Name = "regTypeBox";
            this.regTypeBox.Size = new System.Drawing.Size(146, 22);
            this.regTypeBox.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Type:";
            // 
            // delTypeBox
            // 
            this.delTypeBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Type", true));
            this.delTypeBox.Location = new System.Drawing.Point(621, 171);
            this.delTypeBox.Name = "delTypeBox";
            this.delTypeBox.ReadOnly = true;
            this.delTypeBox.Size = new System.Drawing.Size(146, 22);
            this.delTypeBox.TabIndex = 39;
            this.delTypeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Room Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Type:";
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "By";
            // 
            // searchByBox
            // 
            this.searchByBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByBox.FormattingEnabled = true;
            this.searchByBox.Items.AddRange(new object[] {
            "Room Number",
            "Type"});
            this.searchByBox.Location = new System.Drawing.Point(217, 12);
            this.searchByBox.Name = "searchByBox";
            this.searchByBox.Size = new System.Drawing.Size(121, 24);
            this.searchByBox.TabIndex = 42;
            // 
            // assignmentsTableAdapter
            // 
            this.assignmentsTableAdapter.ClearBeforeFill = true;
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 309);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchByBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delTypeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regTypeBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delRoomButton);
            this.Controls.Add(this.delRoomBox);
            this.Controls.Add(this.regRoomButton);
            this.Controls.Add(this.regRoomBox);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloutShelterDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delRoomButton;
        private System.Windows.Forms.TextBox delRoomBox;
        private System.Windows.Forms.Button regRoomButton;
        private System.Windows.Forms.TextBox regRoomBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FalloutShelterDBDataSet falloutShelterDBDataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private FalloutShelterDBDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox regTypeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox delTypeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalWater;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPower;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyWaterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyPowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox searchByBox;
        private FalloutShelterDBDataSetTableAdapters.AssignmentsTableAdapter assignmentsTableAdapter;
    }
}