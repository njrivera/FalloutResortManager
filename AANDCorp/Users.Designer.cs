namespace AANDCorp
{
    partial class Users
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
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.falloutShelterDBDataSet = new AANDCorp.FalloutShelterDBDataSet();
            this.usersTableAdapter = new AANDCorp.FalloutShelterDBDataSetTableAdapters.UsersTableAdapter();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.crtUserBox = new System.Windows.Forms.TextBox();
            this.crtPassBox = new System.Windows.Forms.TextBox();
            this.confPassBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.crtEidBox = new System.Windows.Forms.TextBox();
            this.crtRoleBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.createUserButton = new System.Windows.Forms.Button();
            this.delUserButton = new System.Windows.Forms.Button();
            this.delUserBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.delEidBox = new System.Windows.Forms.TextBox();
            this.delRoleBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.tenantsTableAdapter = new AANDCorp.FalloutShelterDBDataSetTableAdapters.TenantsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.searchByBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
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
            this.usernameDataGridViewTextBoxColumn,
            this.eidDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(341, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // eidDataGridViewTextBoxColumn
            // 
            this.eidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eidDataGridViewTextBoxColumn.DataPropertyName = "Eid";
            this.eidDataGridViewTextBoxColumn.HeaderText = "Eid";
            this.eidDataGridViewTextBoxColumn.Name = "eidDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.falloutShelterDBDataSet;
            // 
            // falloutShelterDBDataSet
            // 
            this.falloutShelterDBDataSet.DataSetName = "FalloutShelterDBDataSet";
            this.falloutShelterDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Location = new System.Drawing.Point(164, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 27);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(146, 22);
            this.searchBox.TabIndex = 5;
            // 
            // crtUserBox
            // 
            this.crtUserBox.Location = new System.Drawing.Point(384, 108);
            this.crtUserBox.Name = "crtUserBox";
            this.crtUserBox.Size = new System.Drawing.Size(146, 22);
            this.crtUserBox.TabIndex = 9;
            // 
            // crtPassBox
            // 
            this.crtPassBox.Location = new System.Drawing.Point(384, 153);
            this.crtPassBox.Name = "crtPassBox";
            this.crtPassBox.Size = new System.Drawing.Size(146, 22);
            this.crtPassBox.TabIndex = 10;
            // 
            // confPassBox
            // 
            this.confPassBox.Location = new System.Drawing.Point(384, 198);
            this.confPassBox.Name = "confPassBox";
            this.confPassBox.Size = new System.Drawing.Size(146, 22);
            this.confPassBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Confirm Password";
            // 
            // crtEidBox
            // 
            this.crtEidBox.Location = new System.Drawing.Point(412, 63);
            this.crtEidBox.Name = "crtEidBox";
            this.crtEidBox.Size = new System.Drawing.Size(88, 22);
            this.crtEidBox.TabIndex = 33;
            // 
            // crtRoleBox
            // 
            this.crtRoleBox.Location = new System.Drawing.Point(412, 243);
            this.crtRoleBox.Name = "crtRoleBox";
            this.crtRoleBox.Size = new System.Drawing.Size(88, 22);
            this.crtRoleBox.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Employee Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Role";
            // 
            // createUserButton
            // 
            this.createUserButton.AutoSize = true;
            this.createUserButton.Location = new System.Drawing.Point(408, 283);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(94, 27);
            this.createUserButton.TabIndex = 37;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // delUserButton
            // 
            this.delUserButton.AutoSize = true;
            this.delUserButton.Location = new System.Drawing.Point(408, 398);
            this.delUserButton.Name = "delUserButton";
            this.delUserButton.Size = new System.Drawing.Size(94, 27);
            this.delUserButton.TabIndex = 38;
            this.delUserButton.Text = "Delete User";
            this.delUserButton.UseVisualStyleBackColor = true;
            this.delUserButton.Click += new System.EventHandler(this.delUserButton_Click);
            // 
            // delUserBox
            // 
            this.delUserBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.delUserBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Username", true));
            this.delUserBox.Location = new System.Drawing.Point(454, 324);
            this.delUserBox.Name = "delUserBox";
            this.delUserBox.ReadOnly = true;
            this.delUserBox.Size = new System.Drawing.Size(100, 15);
            this.delUserBox.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Employee Id:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Username:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Role:";
            // 
            // delEidBox
            // 
            this.delEidBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.delEidBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Eid", true));
            this.delEidBox.Location = new System.Drawing.Point(454, 345);
            this.delEidBox.Name = "delEidBox";
            this.delEidBox.ReadOnly = true;
            this.delEidBox.Size = new System.Drawing.Size(100, 15);
            this.delEidBox.TabIndex = 43;
            // 
            // delRoleBox
            // 
            this.delRoleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.delRoleBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Role", true));
            this.delRoleBox.Location = new System.Drawing.Point(454, 366);
            this.delRoleBox.Name = "delRoleBox";
            this.delRoleBox.ReadOnly = true;
            this.delRoleBox.Size = new System.Drawing.Size(100, 15);
            this.delRoleBox.TabIndex = 44;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Location = new System.Drawing.Point(239, 431);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(94, 27);
            this.closeButton.TabIndex = 45;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // tenantsTableAdapter
            // 
            this.tenantsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "By";
            // 
            // searchByBox
            // 
            this.searchByBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByBox.FormattingEnabled = true;
            this.searchByBox.Items.AddRange(new object[] {
            "Username",
            "Employee Id"});
            this.searchByBox.Location = new System.Drawing.Point(275, 12);
            this.searchByBox.Name = "searchByBox";
            this.searchByBox.Size = new System.Drawing.Size(110, 24);
            this.searchByBox.TabIndex = 46;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchByBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.delRoleBox);
            this.Controls.Add(this.delEidBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.delUserBox);
            this.Controls.Add(this.delUserButton);
            this.Controls.Add(this.createUserButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.crtRoleBox);
            this.Controls.Add(this.crtEidBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confPassBox);
            this.Controls.Add(this.crtPassBox);
            this.Controls.Add(this.crtUserBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloutShelterDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FalloutShelterDBDataSet falloutShelterDBDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private FalloutShelterDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TextBox crtUserBox;
        private System.Windows.Forms.TextBox crtPassBox;
        private System.Windows.Forms.TextBox confPassBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox crtEidBox;
        private System.Windows.Forms.TextBox crtRoleBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Button delUserButton;
        private System.Windows.Forms.TextBox delUserBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox delEidBox;
        private System.Windows.Forms.TextBox delRoleBox;
        private System.Windows.Forms.Button closeButton;
        private FalloutShelterDBDataSetTableAdapters.TenantsTableAdapter tenantsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searchByBox;
    }
}