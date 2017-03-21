namespace AANDCorp
{
    partial class FoodEntry
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
            this.tenantBox = new System.Windows.Forms.TextBox();
            this.foodBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.entryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tenantBox
            // 
            this.tenantBox.Location = new System.Drawing.Point(12, 50);
            this.tenantBox.Name = "tenantBox";
            this.tenantBox.Size = new System.Drawing.Size(100, 22);
            this.tenantBox.TabIndex = 0;
            // 
            // foodBox
            // 
            this.foodBox.Location = new System.Drawing.Point(118, 50);
            this.foodBox.Name = "foodBox";
            this.foodBox.Size = new System.Drawing.Size(100, 22);
            this.foodBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tenant ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rations";
            // 
            // entryButton
            // 
            this.entryButton.AutoSize = true;
            this.entryButton.Location = new System.Drawing.Point(69, 87);
            this.entryButton.Name = "entryButton";
            this.entryButton.Size = new System.Drawing.Size(88, 27);
            this.entryButton.TabIndex = 4;
            this.entryButton.Text = "Save Entry";
            this.entryButton.UseVisualStyleBackColor = true;
            this.entryButton.Click += new System.EventHandler(this.entryButton_Click);
            // 
            // FoodEntry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(229, 141);
            this.Controls.Add(this.entryButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.foodBox);
            this.Controls.Add(this.tenantBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FoodEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tenantBox;
        private System.Windows.Forms.TextBox foodBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button entryButton;
    }
}