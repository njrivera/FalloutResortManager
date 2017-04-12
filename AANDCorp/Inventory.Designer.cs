namespace AANDCorp
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.litersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.falloutShelterDBDataSet = new AANDCorp.FalloutShelterDBDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kWhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delWBox = new System.Windows.Forms.Label();
            this.delWDateBox = new System.Windows.Forms.Label();
            this.exDefWater = new System.Windows.Forms.Label();
            this.delWButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveWater = new System.Windows.Forms.Button();
            this.dateWLabel = new System.Windows.Forms.Label();
            this.waterBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delPBox = new System.Windows.Forms.Label();
            this.exDefPower = new System.Windows.Forms.Label();
            this.delPDateBox = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.savePower = new System.Windows.Forms.Button();
            this.datePLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.powerBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.delRBox = new System.Windows.Forms.Label();
            this.rationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exDefRations = new System.Windows.Forms.Label();
            this.delRDateBox = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.delRButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveRations = new System.Windows.Forms.Button();
            this.dateRLabel = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rationBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.waterTableAdapter = new AANDCorp.FalloutShelterDBDataSetTableAdapters.WaterTableAdapter();
            this.powerTableAdapter = new AANDCorp.FalloutShelterDBDataSetTableAdapters.PowerTableAdapter();
            this.rationsTableAdapter = new AANDCorp.FalloutShelterDBDataSetTableAdapters.RationsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloutShelterDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.litersDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.waterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(315, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // litersDataGridViewTextBoxColumn
            // 
            this.litersDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.litersDataGridViewTextBoxColumn.DataPropertyName = "Liters";
            this.litersDataGridViewTextBoxColumn.HeaderText = "Liters";
            this.litersDataGridViewTextBoxColumn.Name = "litersDataGridViewTextBoxColumn";
            // 
            // waterBindingSource
            // 
            this.waterBindingSource.DataMember = "Water";
            this.waterBindingSource.DataSource = this.falloutShelterDBDataSet;
            // 
            // falloutShelterDBDataSet
            // 
            this.falloutShelterDBDataSet.DataSetName = "FalloutShelterDBDataSet";
            this.falloutShelterDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn1,
            this.kWhDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.powerBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(16, 31);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(315, 192);
            this.dataGridView2.TabIndex = 1;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            // 
            // kWhDataGridViewTextBoxColumn
            // 
            this.kWhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kWhDataGridViewTextBoxColumn.DataPropertyName = "kWh";
            this.kWhDataGridViewTextBoxColumn.HeaderText = "kWh";
            this.kWhDataGridViewTextBoxColumn.Name = "kWhDataGridViewTextBoxColumn";
            // 
            // powerBindingSource
            // 
            this.powerBindingSource.DataMember = "Power";
            this.powerBindingSource.DataSource = this.falloutShelterDBDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delWBox);
            this.groupBox1.Controls.Add(this.delWDateBox);
            this.groupBox1.Controls.Add(this.exDefWater);
            this.groupBox1.Controls.Add(this.delWButton);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.saveWater);
            this.groupBox1.Controls.Add(this.dateWLabel);
            this.groupBox1.Controls.Add(this.waterBox);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 240);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Water";
            // 
            // delWBox
            // 
            this.delWBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.delWBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.waterBindingSource, "Liters", true));
            this.delWBox.Location = new System.Drawing.Point(423, 156);
            this.delWBox.Name = "delWBox";
            this.delWBox.Size = new System.Drawing.Size(100, 23);
            this.delWBox.TabIndex = 24;
            // 
            // delWDateBox
            // 
            this.delWDateBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.delWDateBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.waterBindingSource, "Date", true));
            this.delWDateBox.Location = new System.Drawing.Point(423, 128);
            this.delWDateBox.Name = "delWDateBox";
            this.delWDateBox.Size = new System.Drawing.Size(100, 23);
            this.delWDateBox.TabIndex = 23;
            // 
            // exDefWater
            // 
            this.exDefWater.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exDefWater.Location = new System.Drawing.Point(561, 96);
            this.exDefWater.Name = "exDefWater";
            this.exDefWater.Size = new System.Drawing.Size(92, 23);
            this.exDefWater.TabIndex = 22;
            // 
            // delWButton
            // 
            this.delWButton.AutoSize = true;
            this.delWButton.Location = new System.Drawing.Point(435, 182);
            this.delWButton.Name = "delWButton";
            this.delWButton.Size = new System.Drawing.Size(75, 27);
            this.delWButton.TabIndex = 18;
            this.delWButton.Text = "Delete";
            this.delWButton.UseVisualStyleBackColor = true;
            this.delWButton.Click += new System.EventHandler(this.delWButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(560, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Excess/Deficit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Liters:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Date:";
            // 
            // saveWater
            // 
            this.saveWater.AutoSize = true;
            this.saveWater.Location = new System.Drawing.Point(435, 60);
            this.saveWater.Name = "saveWater";
            this.saveWater.Size = new System.Drawing.Size(75, 27);
            this.saveWater.TabIndex = 5;
            this.saveWater.Text = "Save";
            this.saveWater.UseVisualStyleBackColor = true;
            this.saveWater.Click += new System.EventHandler(this.saveWater_Click);
            // 
            // dateWLabel
            // 
            this.dateWLabel.AutoSize = true;
            this.dateWLabel.Location = new System.Drawing.Point(339, 35);
            this.dateWLabel.Name = "dateWLabel";
            this.dateWLabel.Size = new System.Drawing.Size(0, 17);
            this.dateWLabel.TabIndex = 4;
            // 
            // waterBox
            // 
            this.waterBox.Location = new System.Drawing.Point(423, 32);
            this.waterBox.Name = "waterBox";
            this.waterBox.Size = new System.Drawing.Size(100, 22);
            this.waterBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.delPBox);
            this.groupBox2.Controls.Add(this.exDefPower);
            this.groupBox2.Controls.Add(this.delPDateBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.savePower);
            this.groupBox2.Controls.Add(this.datePLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.powerBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 243);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Power";
            // 
            // delPBox
            // 
            this.delPBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.delPBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.powerBindingSource, "kWh", true));
            this.delPBox.Location = new System.Drawing.Point(423, 155);
            this.delPBox.Name = "delPBox";
            this.delPBox.Size = new System.Drawing.Size(100, 23);
            this.delPBox.TabIndex = 26;
            // 
            // exDefPower
            // 
            this.exDefPower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exDefPower.Location = new System.Drawing.Point(561, 98);
            this.exDefPower.Name = "exDefPower";
            this.exDefPower.Size = new System.Drawing.Size(92, 23);
            this.exDefPower.TabIndex = 20;
            // 
            // delPDateBox
            // 
            this.delPDateBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.delPDateBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.powerBindingSource, "Date", true));
            this.delPDateBox.Location = new System.Drawing.Point(423, 127);
            this.delPDateBox.Name = "delPDateBox";
            this.delPDateBox.Size = new System.Drawing.Size(100, 23);
            this.delPDateBox.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(560, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Excess/Deficit";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(435, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 14;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(472, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // savePower
            // 
            this.savePower.AutoSize = true;
            this.savePower.Location = new System.Drawing.Point(435, 59);
            this.savePower.Name = "savePower";
            this.savePower.Size = new System.Drawing.Size(75, 27);
            this.savePower.TabIndex = 6;
            this.savePower.Text = "Save";
            this.savePower.UseVisualStyleBackColor = true;
            this.savePower.Click += new System.EventHandler(this.savePower_Click);
            // 
            // datePLabel
            // 
            this.datePLabel.AutoSize = true;
            this.datePLabel.Location = new System.Drawing.Point(339, 34);
            this.datePLabel.Name = "datePLabel";
            this.datePLabel.Size = new System.Drawing.Size(0, 17);
            this.datePLabel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "kWh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date:";
            // 
            // powerBox
            // 
            this.powerBox.Location = new System.Drawing.Point(423, 31);
            this.powerBox.Name = "powerBox";
            this.powerBox.Size = new System.Drawing.Size(100, 22);
            this.powerBox.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.delRBox);
            this.groupBox3.Controls.Add(this.exDefRations);
            this.groupBox3.Controls.Add(this.delRDateBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.delRButton);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.saveRations);
            this.groupBox3.Controls.Add(this.dateRLabel);
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Controls.Add(this.rationBox);
            this.groupBox3.Location = new System.Drawing.Point(13, 508);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 240);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Food";
            // 
            // delRBox
            // 
            this.delRBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.delRBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rationsBindingSource, "Rations", true));
            this.delRBox.Location = new System.Drawing.Point(423, 157);
            this.delRBox.Name = "delRBox";
            this.delRBox.Size = new System.Drawing.Size(100, 23);
            this.delRBox.TabIndex = 28;
            // 
            // rationsBindingSource
            // 
            this.rationsBindingSource.DataMember = "Rations";
            this.rationsBindingSource.DataSource = this.falloutShelterDBDataSet;
            // 
            // exDefRations
            // 
            this.exDefRations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exDefRations.Location = new System.Drawing.Point(561, 100);
            this.exDefRations.Name = "exDefRations";
            this.exDefRations.Size = new System.Drawing.Size(92, 23);
            this.exDefRations.TabIndex = 22;
            // 
            // delRDateBox
            // 
            this.delRDateBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.delRDateBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rationsBindingSource, "Date", true));
            this.delRDateBox.Location = new System.Drawing.Point(423, 129);
            this.delRDateBox.Name = "delRDateBox";
            this.delRDateBox.Size = new System.Drawing.Size(100, 23);
            this.delRDateBox.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(560, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Excess/Deficit";
            // 
            // delRButton
            // 
            this.delRButton.AutoSize = true;
            this.delRButton.Location = new System.Drawing.Point(435, 183);
            this.delRButton.Name = "delRButton";
            this.delRButton.Size = new System.Drawing.Size(75, 27);
            this.delRButton.TabIndex = 13;
            this.delRButton.Text = "Delete";
            this.delRButton.UseVisualStyleBackColor = true;
            this.delRButton.Click += new System.EventHandler(this.delRButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rations:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Date:";
            // 
            // saveRations
            // 
            this.saveRations.AutoSize = true;
            this.saveRations.Location = new System.Drawing.Point(435, 61);
            this.saveRations.Name = "saveRations";
            this.saveRations.Size = new System.Drawing.Size(75, 27);
            this.saveRations.TabIndex = 7;
            this.saveRations.Text = "Save";
            this.saveRations.UseVisualStyleBackColor = true;
            this.saveRations.Click += new System.EventHandler(this.saveRations_Click);
            // 
            // dateRLabel
            // 
            this.dateRLabel.AutoSize = true;
            this.dateRLabel.Location = new System.Drawing.Point(339, 36);
            this.dateRLabel.Name = "dateRLabel";
            this.dateRLabel.Size = new System.Drawing.Size(0, 17);
            this.dateRLabel.TabIndex = 8;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn2,
            this.rationsDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.rationsBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(16, 33);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(315, 192);
            this.dataGridView3.TabIndex = 0;
            // 
            // dateDataGridViewTextBoxColumn2
            // 
            this.dateDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn2.Name = "dateDataGridViewTextBoxColumn2";
            // 
            // rationsDataGridViewTextBoxColumn
            // 
            this.rationsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rationsDataGridViewTextBoxColumn.DataPropertyName = "Rations";
            this.rationsDataGridViewTextBoxColumn.HeaderText = "Rations";
            this.rationsDataGridViewTextBoxColumn.Name = "rationsDataGridViewTextBoxColumn";
            // 
            // rationBox
            // 
            this.rationBox.Location = new System.Drawing.Point(423, 33);
            this.rationBox.Name = "rationBox";
            this.rationBox.Size = new System.Drawing.Size(100, 22);
            this.rationBox.TabIndex = 7;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Location = new System.Drawing.Point(287, 754);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(110, 27);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // waterTableAdapter
            // 
            this.waterTableAdapter.ClearBeforeFill = true;
            // 
            // powerTableAdapter
            // 
            this.powerTableAdapter.ClearBeforeFill = true;
            // 
            // rationsTableAdapter
            // 
            this.rationsTableAdapter.ClearBeforeFill = true;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 790);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloutShelterDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FalloutShelterDBDataSet falloutShelterDBDataSet;
        private System.Windows.Forms.BindingSource waterBindingSource;
        private FalloutShelterDBDataSetTableAdapters.WaterTableAdapter waterTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource powerBindingSource;
        private FalloutShelterDBDataSetTableAdapters.PowerTableAdapter powerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn litersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kWhDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label dateWLabel;
        private System.Windows.Forms.TextBox waterBox;
        private System.Windows.Forms.Label datePLabel;
        private System.Windows.Forms.TextBox powerBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource rationsBindingSource;
        private FalloutShelterDBDataSetTableAdapters.RationsTableAdapter rationsTableAdapter;
        private System.Windows.Forms.Label dateRLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox rationBox;
        private System.Windows.Forms.Button delWButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveWater;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button savePower;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delRButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveRations;
        private System.Windows.Forms.Label delWBox;
        private System.Windows.Forms.Label delWDateBox;
        private System.Windows.Forms.Label exDefWater;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label delPBox;
        private System.Windows.Forms.Label exDefPower;
        private System.Windows.Forms.Label delPDateBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label delRBox;
        private System.Windows.Forms.Label exDefRations;
        private System.Windows.Forms.Label delRDateBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button closeButton;
    }
}