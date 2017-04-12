namespace AANDCorp
{
    partial class AdminView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminView));
            this.button2 = new System.Windows.Forms.Button();
            this.assignButton = new System.Windows.Forms.Button();
            this.roomsButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.resourceButton = new System.Windows.Forms.Button();
            this.radButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(28, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "Tenants";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // assignButton
            // 
            this.assignButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.assignButton.AutoSize = true;
            this.assignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignButton.Location = new System.Drawing.Point(28, 66);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(211, 41);
            this.assignButton.TabIndex = 7;
            this.assignButton.Text = "Assignments";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // roomsButton
            // 
            this.roomsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roomsButton.AutoSize = true;
            this.roomsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsButton.Location = new System.Drawing.Point(28, 113);
            this.roomsButton.Name = "roomsButton";
            this.roomsButton.Size = new System.Drawing.Size(211, 41);
            this.roomsButton.TabIndex = 8;
            this.roomsButton.Text = "Rooms";
            this.roomsButton.UseVisualStyleBackColor = true;
            this.roomsButton.Click += new System.EventHandler(this.roomsButton_Click);
            // 
            // userButton
            // 
            this.userButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userButton.AutoSize = true;
            this.userButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userButton.Location = new System.Drawing.Point(28, 160);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(211, 41);
            this.userButton.TabIndex = 10;
            this.userButton.Text = "Users";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoutButton.AutoSize = true;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(28, 301);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(211, 41);
            this.logoutButton.TabIndex = 11;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // resourceButton
            // 
            this.resourceButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resourceButton.AutoSize = true;
            this.resourceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourceButton.Location = new System.Drawing.Point(28, 207);
            this.resourceButton.Name = "resourceButton";
            this.resourceButton.Size = new System.Drawing.Size(211, 41);
            this.resourceButton.TabIndex = 12;
            this.resourceButton.Text = "Inventory";
            this.resourceButton.UseVisualStyleBackColor = true;
            this.resourceButton.Click += new System.EventHandler(this.resourceButton_Click);
            // 
            // radButton
            // 
            this.radButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radButton.AutoSize = true;
            this.radButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton.Location = new System.Drawing.Point(28, 254);
            this.radButton.Name = "radButton";
            this.radButton.Size = new System.Drawing.Size(211, 41);
            this.radButton.TabIndex = 13;
            this.radButton.Text = "Radiation";
            this.radButton.UseVisualStyleBackColor = true;
            this.radButton.Click += new System.EventHandler(this.radButton_Click);
            // 
            // AdminView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(266, 356);
            this.Controls.Add(this.radButton);
            this.Controls.Add(this.resourceButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.roomsButton);
            this.Controls.Add(this.assignButton);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.Button roomsButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button resourceButton;
        private System.Windows.Forms.Button radButton;
    }
}