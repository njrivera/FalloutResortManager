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
            this.delRoomButton = new System.Windows.Forms.Button();
            this.delRoomBox = new System.Windows.Forms.TextBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.falloutShelterDBDataSet = new AANDCorp.FalloutShelterDBDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.regRoomButton = new System.Windows.Forms.Button();
            this.regRoomBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyWaterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyPowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsTableAdapter = new AANDCorp.FalloutShelterDBDataSetTableAdapters.RoomsTableAdapter();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloutShelterDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // delRoomButton
            // 
            this.delRoomButton.AutoSize = true;
            this.delRoomButton.Location = new System.Drawing.Point(666, 177);
            this.delRoomButton.Name = "delRoomButton";
            this.delRoomButton.Size = new System.Drawing.Size(112, 27);
            this.delRoomButton.TabIndex = 30;
            this.delRoomButton.Text = "Delete Room";
            this.delRoomButton.UseVisualStyleBackColor = true;
            this.delRoomButton.Click += new System.EventHandler(this.delRoomButton_Click);
            // 
            // delRoomBox
            // 
            this.delRoomBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.delRoomBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "RoomNum", true));
            this.delRoomBox.Location = new System.Drawing.Point(573, 182);
            this.delRoomBox.Name = "delRoomBox";
            this.delRoomBox.ReadOnly = true;
            this.delRoomBox.Size = new System.Drawing.Size(87, 15);
            this.delRoomBox.TabIndex = 29;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(593, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Room";
            // 
            // regRoomButton
            // 
            this.regRoomButton.AutoSize = true;
            this.regRoomButton.Location = new System.Drawing.Point(599, 97);
            this.regRoomButton.Name = "regRoomButton";
            this.regRoomButton.Size = new System.Drawing.Size(112, 27);
            this.regRoomButton.TabIndex = 27;
            this.regRoomButton.Text = "Register Room";
            this.regRoomButton.UseVisualStyleBackColor = true;
            this.regRoomButton.Click += new System.EventHandler(this.regRoomButton_Click);
            // 
            // regRoomBox
            // 
            this.regRoomBox.Location = new System.Drawing.Point(612, 69);
            this.regRoomBox.Name = "regRoomBox";
            this.regRoomBox.Size = new System.Drawing.Size(87, 22);
            this.regRoomBox.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(633, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Room";
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
            this.waterDataGridViewTextBoxColumn,
            this.powerDataGridViewTextBoxColumn,
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
            // waterDataGridViewTextBoxColumn
            // 
            this.waterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.waterDataGridViewTextBoxColumn.DataPropertyName = "Water";
            this.waterDataGridViewTextBoxColumn.HeaderText = "Water";
            this.waterDataGridViewTextBoxColumn.Name = "waterDataGridViewTextBoxColumn";
            // 
            // powerDataGridViewTextBoxColumn
            // 
            this.powerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.powerDataGridViewTextBoxColumn.DataPropertyName = "Power";
            this.powerDataGridViewTextBoxColumn.HeaderText = "Power";
            this.powerDataGridViewTextBoxColumn.Name = "powerDataGridViewTextBoxColumn";
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
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
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
            this.closeButton.Location = new System.Drawing.Point(703, 272);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
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
            this.resetButton.Text = "Update && Reset Daily Values";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 309);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delRoomButton);
            this.Controls.Add(this.delRoomBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.regRoomButton);
            this.Controls.Add(this.regRoomBox);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyWaterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyPowerDataGridViewTextBoxColumn;
    }
}