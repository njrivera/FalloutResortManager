namespace AANDCorp
{
    partial class Tenants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tenants));
            this.tenantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.falloutShelterDBDataSet = new AANDCorp.FalloutShelterDBDataSet();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchByBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.editTenIdBox = new System.Windows.Forms.TextBox();
            this.delTenButton = new System.Windows.Forms.Button();
            this.regTenant = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lastNBox = new System.Windows.Forms.TextBox();
            this.firstNBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.editTenLBox = new System.Windows.Forms.TextBox();
            this.editTenFBox = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.resetButton = new System.Windows.Forms.Button();
            this.tidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalRationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyRationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.falloutShelterDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tenantsTableAdapter = new AANDCorp.FalloutShelterDBDataSetTableAdapters.TenantsTableAdapter();
            this.usersTableAdapter = new AANDCorp.FalloutShelterDBDataSetTableAdapters.UsersTableAdapter();
            this.assignmentsTableAdapter = new AANDCorp.FalloutShelterDBDataSetTableAdapters.AssignmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tenantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloutShelterDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloutShelterDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tenantsBindingSource
            // 
            this.tenantsBindingSource.DataMember = "Tenants";
            this.tenantsBindingSource.DataSource = this.falloutShelterDBDataSetBindingSource;
            // 
            // falloutShelterDBDataSet
            // 
            this.falloutShelterDBDataSet.DataSetName = "FalloutShelterDBDataSet";
            this.falloutShelterDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(146, 22);
            this.searchBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Location = new System.Drawing.Point(164, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 27);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchByBox
            // 
            this.searchByBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByBox.FormattingEnabled = true;
            this.searchByBox.Items.AddRange(new object[] {
            "Tenant Id",
            "First Name",
            "Last Name"});
            this.searchByBox.Location = new System.Drawing.Point(275, 12);
            this.searchByBox.Name = "searchByBox";
            this.searchByBox.Size = new System.Drawing.Size(121, 24);
            this.searchByBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tenant Id:";
            // 
            // editTenIdBox
            // 
            this.editTenIdBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tenantsBindingSource, "Tid", true));
            this.editTenIdBox.Location = new System.Drawing.Point(686, 211);
            this.editTenIdBox.Name = "editTenIdBox";
            this.editTenIdBox.ReadOnly = true;
            this.editTenIdBox.Size = new System.Drawing.Size(87, 22);
            this.editTenIdBox.TabIndex = 14;
            this.editTenIdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // delTenButton
            // 
            this.delTenButton.AutoSize = true;
            this.delTenButton.Location = new System.Drawing.Point(660, 295);
            this.delTenButton.Name = "delTenButton";
            this.delTenButton.Size = new System.Drawing.Size(96, 27);
            this.delTenButton.TabIndex = 13;
            this.delTenButton.Text = "Delete";
            this.delTenButton.UseVisualStyleBackColor = true;
            this.delTenButton.Click += new System.EventHandler(this.delTenButton_Click);
            // 
            // regTenant
            // 
            this.regTenant.AutoSize = true;
            this.regTenant.Location = new System.Drawing.Point(660, 132);
            this.regTenant.Name = "regTenant";
            this.regTenant.Size = new System.Drawing.Size(96, 27);
            this.regTenant.TabIndex = 12;
            this.regTenant.Text = "Register";
            this.regTenant.UseVisualStyleBackColor = true;
            this.regTenant.Click += new System.EventHandler(this.regTenant_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(673, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(673, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "First Name";
            // 
            // lastNBox
            // 
            this.lastNBox.Location = new System.Drawing.Point(638, 104);
            this.lastNBox.Name = "lastNBox";
            this.lastNBox.Size = new System.Drawing.Size(139, 22);
            this.lastNBox.TabIndex = 9;
            // 
            // firstNBox
            // 
            this.firstNBox.Location = new System.Drawing.Point(638, 59);
            this.firstNBox.Name = "firstNBox";
            this.firstNBox.Size = new System.Drawing.Size(139, 22);
            this.firstNBox.TabIndex = 8;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Location = new System.Drawing.Point(735, 392);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(96, 27);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(600, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "First Name:";
            // 
            // editTenLBox
            // 
            this.editTenLBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tenantsBindingSource, "Lastname", true));
            this.editTenLBox.Location = new System.Drawing.Point(686, 267);
            this.editTenLBox.Name = "editTenLBox";
            this.editTenLBox.ReadOnly = true;
            this.editTenLBox.Size = new System.Drawing.Size(139, 22);
            this.editTenLBox.TabIndex = 20;
            this.editTenLBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editTenFBox
            // 
            this.editTenFBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tenantsBindingSource, "Firstname", true));
            this.editTenFBox.Location = new System.Drawing.Point(686, 239);
            this.editTenFBox.Name = "editTenFBox";
            this.editTenFBox.ReadOnly = true;
            this.editTenFBox.Size = new System.Drawing.Size(139, 22);
            this.editTenFBox.TabIndex = 19;
            this.editTenFBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tidDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.totalRationsDataGridViewTextBoxColumn,
            this.dailyRationsDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tenantsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(578, 377);
            this.dataGridView2.TabIndex = 23;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(596, 368);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(133, 52);
            this.resetButton.TabIndex = 36;
            this.resetButton.Text = "Transfer Daily to Total";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // tidDataGridViewTextBoxColumn
            // 
            this.tidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tidDataGridViewTextBoxColumn.DataPropertyName = "Tid";
            this.tidDataGridViewTextBoxColumn.HeaderText = "Tid";
            this.tidDataGridViewTextBoxColumn.Name = "tidDataGridViewTextBoxColumn";
            this.tidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // totalRationsDataGridViewTextBoxColumn
            // 
            this.totalRationsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalRationsDataGridViewTextBoxColumn.DataPropertyName = "TotalRations";
            this.totalRationsDataGridViewTextBoxColumn.HeaderText = "TotalRations";
            this.totalRationsDataGridViewTextBoxColumn.Name = "totalRationsDataGridViewTextBoxColumn";
            // 
            // dailyRationsDataGridViewTextBoxColumn
            // 
            this.dailyRationsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dailyRationsDataGridViewTextBoxColumn.DataPropertyName = "DailyRations";
            this.dailyRationsDataGridViewTextBoxColumn.HeaderText = "DailyRations";
            this.dailyRationsDataGridViewTextBoxColumn.Name = "dailyRationsDataGridViewTextBoxColumn";
            // 
            // falloutShelterDBDataSetBindingSource
            // 
            this.falloutShelterDBDataSetBindingSource.DataSource = this.falloutShelterDBDataSet;
            this.falloutShelterDBDataSetBindingSource.Position = 0;
            // 
            // tenantsTableAdapter
            // 
            this.tenantsTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // assignmentsTableAdapter
            // 
            this.assignmentsTableAdapter.ClearBeforeFill = true;
            // 
            // Tenants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 432);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.editTenLBox);
            this.Controls.Add(this.editTenFBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editTenIdBox);
            this.Controls.Add(this.delTenButton);
            this.Controls.Add(this.regTenant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastNBox);
            this.Controls.Add(this.firstNBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchByBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tenants";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Tenants";
            this.Load += new System.EventHandler(this.Tenants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tenantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloutShelterDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloutShelterDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FalloutShelterDBDataSet falloutShelterDBDataSet;
        private System.Windows.Forms.BindingSource falloutShelterDBDataSetBindingSource;
        private FalloutShelterDBDataSetTableAdapters.TenantsTableAdapter tenantsTableAdapter;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox searchByBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tenantsBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox editTenIdBox;
        private System.Windows.Forms.Button delTenButton;
        private System.Windows.Forms.Button regTenant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastNBox;
        private System.Windows.Forms.TextBox firstNBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox editTenLBox;
        private System.Windows.Forms.TextBox editTenFBox;
        private FalloutShelterDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalRationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyRationsDataGridViewTextBoxColumn;
        private FalloutShelterDBDataSetTableAdapters.AssignmentsTableAdapter assignmentsTableAdapter;
        private System.Windows.Forms.Button resetButton;
    }
}