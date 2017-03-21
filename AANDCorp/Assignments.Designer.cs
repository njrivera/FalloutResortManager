namespace AANDCorp
{
    partial class Assignments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.remRoomButton = new System.Windows.Forms.Button();
            this.remTenButton = new System.Windows.Forms.Button();
            this.remRoomBox = new System.Windows.Forms.TextBox();
            this.assignmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.falloutShelterDBDataSet = new AANDCorp.FalloutShelterDBDataSet();
            this.remTenBox = new System.Windows.Forms.TextBox();
            this.assignButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roomAssignBox = new System.Windows.Forms.TextBox();
            this.tidAssignBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tenantsTableAdapter = new AANDCorp.FalloutShelterDBDataSetTableAdapters.TenantsTableAdapter();
            this.assignmentsTableAdapter = new AANDCorp.FalloutShelterDBDataSetTableAdapters.AssignmentsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.searchByBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.roomsTableAdapter = new AANDCorp.FalloutShelterDBDataSetTableAdapters.RoomsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloutShelterDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Room";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tenant ID";
            // 
            // remRoomButton
            // 
            this.remRoomButton.Location = new System.Drawing.Point(377, 220);
            this.remRoomButton.Name = "remRoomButton";
            this.remRoomButton.Size = new System.Drawing.Size(119, 47);
            this.remRoomButton.TabIndex = 26;
            this.remRoomButton.Text = "Remove All Tenants";
            this.remRoomButton.UseVisualStyleBackColor = true;
            this.remRoomButton.Click += new System.EventHandler(this.remRoomButton_Click);
            // 
            // remTenButton
            // 
            this.remTenButton.AutoSize = true;
            this.remTenButton.Location = new System.Drawing.Point(377, 175);
            this.remTenButton.Name = "remTenButton";
            this.remTenButton.Size = new System.Drawing.Size(119, 27);
            this.remTenButton.TabIndex = 25;
            this.remTenButton.Text = "Remove Tenant";
            this.remTenButton.UseVisualStyleBackColor = true;
            this.remTenButton.Click += new System.EventHandler(this.remTenButton_Click);
            // 
            // remRoomBox
            // 
            this.remRoomBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.remRoomBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignmentsBindingSource, "RoomNum", true));
            this.remRoomBox.Location = new System.Drawing.Point(284, 235);
            this.remRoomBox.Name = "remRoomBox";
            this.remRoomBox.ReadOnly = true;
            this.remRoomBox.Size = new System.Drawing.Size(87, 15);
            this.remRoomBox.TabIndex = 24;
            // 
            // assignmentsBindingSource
            // 
            this.assignmentsBindingSource.DataMember = "Assignments";
            this.assignmentsBindingSource.DataSource = this.falloutShelterDBDataSet;
            // 
            // falloutShelterDBDataSet
            // 
            this.falloutShelterDBDataSet.DataSetName = "FalloutShelterDBDataSet";
            this.falloutShelterDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // remTenBox
            // 
            this.remTenBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.remTenBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignmentsBindingSource, "Tid", true));
            this.remTenBox.Location = new System.Drawing.Point(284, 180);
            this.remTenBox.Name = "remTenBox";
            this.remTenBox.ReadOnly = true;
            this.remTenBox.Size = new System.Drawing.Size(87, 15);
            this.remTenBox.TabIndex = 23;
            // 
            // assignButton
            // 
            this.assignButton.AutoSize = true;
            this.assignButton.Location = new System.Drawing.Point(337, 104);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(75, 27);
            this.assignButton.TabIndex = 22;
            this.assignButton.Text = "Assign";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tenant ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Room";
            // 
            // roomAssignBox
            // 
            this.roomAssignBox.Location = new System.Drawing.Point(377, 76);
            this.roomAssignBox.Name = "roomAssignBox";
            this.roomAssignBox.Size = new System.Drawing.Size(87, 22);
            this.roomAssignBox.TabIndex = 20;
            // 
            // tidAssignBox
            // 
            this.tidAssignBox.Location = new System.Drawing.Point(284, 76);
            this.tidAssignBox.Name = "tidAssignBox";
            this.tidAssignBox.Size = new System.Drawing.Size(87, 22);
            this.tidAssignBox.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumDataGridViewTextBoxColumn,
            this.tidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.assignmentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 290);
            this.dataGridView1.TabIndex = 29;
            // 
            // roomNumDataGridViewTextBoxColumn
            // 
            this.roomNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roomNumDataGridViewTextBoxColumn.DataPropertyName = "RoomNum";
            this.roomNumDataGridViewTextBoxColumn.HeaderText = "Room";
            this.roomNumDataGridViewTextBoxColumn.Name = "roomNumDataGridViewTextBoxColumn";
            // 
            // tidDataGridViewTextBoxColumn
            // 
            this.tidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tidDataGridViewTextBoxColumn.DataPropertyName = "Tid";
            this.tidDataGridViewTextBoxColumn.HeaderText = "Tenant";
            this.tidDataGridViewTextBoxColumn.Name = "tidDataGridViewTextBoxColumn";
            // 
            // tenantsBindingSource
            // 
            this.tenantsBindingSource.DataMember = "Tenants";
            this.tenantsBindingSource.DataSource = this.falloutShelterDBDataSet;
            // 
            // tenantsTableAdapter
            // 
            this.tenantsTableAdapter.ClearBeforeFill = true;
            // 
            // assignmentsTableAdapter
            // 
            this.assignmentsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "By";
            // 
            // searchByBox
            // 
            this.searchByBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByBox.FormattingEnabled = true;
            this.searchByBox.Items.AddRange(new object[] {
            "Tenant Id",
            "Room Number"});
            this.searchByBox.Location = new System.Drawing.Point(217, 12);
            this.searchByBox.Name = "searchByBox";
            this.searchByBox.Size = new System.Drawing.Size(110, 24);
            this.searchByBox.TabIndex = 32;
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Location = new System.Drawing.Point(106, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 27);
            this.searchButton.TabIndex = 31;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(88, 22);
            this.searchBox.TabIndex = 30;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Location = new System.Drawing.Point(337, 306);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 27);
            this.closeButton.TabIndex = 34;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // Assignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 347);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchByBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.remRoomButton);
            this.Controls.Add(this.remTenButton);
            this.Controls.Add(this.remRoomBox);
            this.Controls.Add(this.remTenBox);
            this.Controls.Add(this.assignButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.roomAssignBox);
            this.Controls.Add(this.tidAssignBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Assignments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignments";
            this.Load += new System.EventHandler(this.Assignments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloutShelterDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button remRoomButton;
        private System.Windows.Forms.Button remTenButton;
        private System.Windows.Forms.TextBox remRoomBox;
        private System.Windows.Forms.TextBox remTenBox;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox roomAssignBox;
        private System.Windows.Forms.TextBox tidAssignBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FalloutShelterDBDataSet falloutShelterDBDataSet;
        private System.Windows.Forms.BindingSource tenantsBindingSource;
        private FalloutShelterDBDataSetTableAdapters.TenantsTableAdapter tenantsTableAdapter;
        private System.Windows.Forms.BindingSource assignmentsBindingSource;
        private FalloutShelterDBDataSetTableAdapters.AssignmentsTableAdapter assignmentsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searchByBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button closeButton;
        private FalloutShelterDBDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tidDataGridViewTextBoxColumn;
    }
}