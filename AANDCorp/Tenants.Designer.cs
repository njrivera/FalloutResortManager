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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.falloutShelterDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.falloutShelterDBDataSet = new AANDCorp.FalloutShelterDBDataSet();
            this.tenantsTableAdapter = new AANDCorp.FalloutShelterDBDataSetTableAdapters.TenantsTableAdapter();
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
            this.rationsTableAdapter = new AANDCorp.FalloutShelterDBDataSetTableAdapters.RationsTableAdapter();
            this.editButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.editTenLBox = new System.Windows.Forms.TextBox();
            this.editTenFBox = new System.Windows.Forms.TextBox();
            this.usersTableAdapter = new AANDCorp.FalloutShelterDBDataSetTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloutShelterDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloutShelterDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tenantsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(510, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tid";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tenant Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenantsBindingSource
            // 
            this.tenantsBindingSource.DataMember = "Tenants";
            this.tenantsBindingSource.DataSource = this.falloutShelterDBDataSetBindingSource;
            // 
            // falloutShelterDBDataSetBindingSource
            // 
            this.falloutShelterDBDataSetBindingSource.DataSource = this.falloutShelterDBDataSet;
            this.falloutShelterDBDataSetBindingSource.Position = 0;
            // 
            // falloutShelterDBDataSet
            // 
            this.falloutShelterDBDataSet.DataSetName = "FalloutShelterDBDataSet";
            this.falloutShelterDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tenantsTableAdapter
            // 
            this.tenantsTableAdapter.ClearBeforeFill = true;
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
            "Last Name",
            "Room"});
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
            this.label3.Location = new System.Drawing.Point(540, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tenant Id:";
            // 
            // editTenIdBox
            // 
            this.editTenIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editTenIdBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tenantsBindingSource, "Tid", true));
            this.editTenIdBox.Location = new System.Drawing.Point(618, 229);
            this.editTenIdBox.Name = "editTenIdBox";
            this.editTenIdBox.ReadOnly = true;
            this.editTenIdBox.Size = new System.Drawing.Size(87, 15);
            this.editTenIdBox.TabIndex = 14;
            // 
            // delTenButton
            // 
            this.delTenButton.AutoSize = true;
            this.delTenButton.Location = new System.Drawing.Point(644, 304);
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
            this.regTenant.Location = new System.Drawing.Point(596, 147);
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
            this.label2.Location = new System.Drawing.Point(609, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(609, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "First Name";
            // 
            // lastNBox
            // 
            this.lastNBox.Location = new System.Drawing.Point(574, 119);
            this.lastNBox.Name = "lastNBox";
            this.lastNBox.Size = new System.Drawing.Size(139, 22);
            this.lastNBox.TabIndex = 9;
            // 
            // firstNBox
            // 
            this.firstNBox.Location = new System.Drawing.Point(574, 74);
            this.firstNBox.Name = "firstNBox";
            this.firstNBox.Size = new System.Drawing.Size(139, 22);
            this.firstNBox.TabIndex = 8;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Location = new System.Drawing.Point(588, 393);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(120, 27);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // rationsTableAdapter
            // 
            this.rationsTableAdapter.ClearBeforeFill = true;
            // 
            // editButton
            // 
            this.editButton.AutoSize = true;
            this.editButton.Location = new System.Drawing.Point(542, 304);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(96, 27);
            this.editButton.TabIndex = 18;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "First Name:";
            // 
            // editTenLBox
            // 
            this.editTenLBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editTenLBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tenantsBindingSource, "Lastname", true));
            this.editTenLBox.Location = new System.Drawing.Point(618, 271);
            this.editTenLBox.Name = "editTenLBox";
            this.editTenLBox.ReadOnly = true;
            this.editTenLBox.Size = new System.Drawing.Size(139, 15);
            this.editTenLBox.TabIndex = 20;
            // 
            // editTenFBox
            // 
            this.editTenFBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editTenFBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tenantsBindingSource, "Firstname", true));
            this.editTenFBox.Location = new System.Drawing.Point(618, 250);
            this.editTenFBox.Name = "editTenFBox";
            this.editTenFBox.ReadOnly = true;
            this.editTenFBox.Size = new System.Drawing.Size(139, 15);
            this.editTenFBox.TabIndex = 19;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // Tenants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 432);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.editTenLBox);
            this.Controls.Add(this.editTenFBox);
            this.Controls.Add(this.editButton);
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
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Tenants";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Tenants";
            this.Load += new System.EventHandler(this.Tenants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloutShelterDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloutShelterDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FalloutShelterDBDataSet falloutShelterDBDataSet;
        private System.Windows.Forms.BindingSource falloutShelterDBDataSetBindingSource;
        private FalloutShelterDBDataSetTableAdapters.TenantsTableAdapter tenantsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tidDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox searchByBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantIDDataGridViewTextBoxColumn;
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
        private FalloutShelterDBDataSetTableAdapters.RationsTableAdapter rationsTableAdapter;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox editTenLBox;
        private System.Windows.Forms.TextBox editTenFBox;
        private FalloutShelterDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
    }
}