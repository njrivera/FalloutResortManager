namespace AANDCorp
{
    partial class Entries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entries));
            this.radiationButton = new System.Windows.Forms.Button();
            this.rationsButton = new System.Windows.Forms.Button();
            this.roomButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radiationButton
            // 
            this.radiationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radiationButton.AutoSize = true;
            this.radiationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiationButton.Location = new System.Drawing.Point(29, 106);
            this.radiationButton.Name = "radiationButton";
            this.radiationButton.Size = new System.Drawing.Size(215, 45);
            this.radiationButton.TabIndex = 11;
            this.radiationButton.Text = "Radiation";
            this.radiationButton.UseVisualStyleBackColor = true;
            this.radiationButton.Click += new System.EventHandler(this.radiationButton_Click);
            // 
            // rationsButton
            // 
            this.rationsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rationsButton.AutoSize = true;
            this.rationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rationsButton.Location = new System.Drawing.Point(29, 59);
            this.rationsButton.Name = "rationsButton";
            this.rationsButton.Size = new System.Drawing.Size(215, 45);
            this.rationsButton.TabIndex = 10;
            this.rationsButton.Text = "Rations";
            this.rationsButton.UseVisualStyleBackColor = true;
            this.rationsButton.Click += new System.EventHandler(this.rationsButton_Click);
            // 
            // roomButton
            // 
            this.roomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomButton.AutoSize = true;
            this.roomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomButton.Location = new System.Drawing.Point(29, 12);
            this.roomButton.Name = "roomButton";
            this.roomButton.Size = new System.Drawing.Size(215, 45);
            this.roomButton.TabIndex = 9;
            this.roomButton.Text = "Rooms";
            this.roomButton.UseVisualStyleBackColor = true;
            this.roomButton.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.AutoSize = true;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(29, 153);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(215, 45);
            this.logoutButton.TabIndex = 12;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // Entries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 205);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.radiationButton);
            this.Controls.Add(this.rationsButton);
            this.Controls.Add(this.roomButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Entries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entries Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button radiationButton;
        private System.Windows.Forms.Button rationsButton;
        private System.Windows.Forms.Button roomButton;
        private System.Windows.Forms.Button logoutButton;
    }
}