namespace AANDCorp
{
    partial class RoomEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomEntry));
            this.roomBox = new System.Windows.Forms.TextBox();
            this.waterBox = new System.Windows.Forms.TextBox();
            this.powerBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.roomsTableAdapter = new AANDCorp.FalloutShelterDBDataSetTableAdapters.RoomsTableAdapter();
            this.SuspendLayout();
            // 
            // roomBox
            // 
            this.roomBox.Location = new System.Drawing.Point(10, 50);
            this.roomBox.Name = "roomBox";
            this.roomBox.Size = new System.Drawing.Size(100, 22);
            this.roomBox.TabIndex = 0;
            // 
            // waterBox
            // 
            this.waterBox.Location = new System.Drawing.Point(116, 50);
            this.waterBox.Name = "waterBox";
            this.waterBox.Size = new System.Drawing.Size(100, 22);
            this.waterBox.TabIndex = 1;
            // 
            // powerBox
            // 
            this.powerBox.Location = new System.Drawing.Point(222, 50);
            this.powerBox.Name = "powerBox";
            this.powerBox.Size = new System.Drawing.Size(100, 22);
            this.powerBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Room Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Water (Liters)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Power (kWh)";
            // 
            // inputButton
            // 
            this.inputButton.AutoSize = true;
            this.inputButton.Location = new System.Drawing.Point(78, 95);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(87, 27);
            this.inputButton.TabIndex = 6;
            this.inputButton.Text = "Save Entry";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Location = new System.Drawing.Point(171, 95);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(87, 27);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // RoomEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 146);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.powerBox);
            this.Controls.Add(this.waterBox);
            this.Controls.Add(this.roomBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RoomEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox roomBox;
        private System.Windows.Forms.TextBox waterBox;
        private System.Windows.Forms.TextBox powerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button inputButton;
        private FalloutShelterDBDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.Button closeButton;
    }
}