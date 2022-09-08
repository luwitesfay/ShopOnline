namespace ShopOnline
{
    partial class Reecipt
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
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.NameLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Enabled = false;
            this.itemNameTextBox.Location = new System.Drawing.Point(195, 92);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(211, 39);
            this.itemNameTextBox.TabIndex = 42;
            this.itemNameTextBox.TextChanged += new System.EventHandler(this.itemNameTextBox_TextChanged);
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLable.Location = new System.Drawing.Point(26, 95);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(163, 36);
            this.NameLable.TabIndex = 41;
            this.NameLable.Text = "Item Name:";
            // 
            // Reecipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 899);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.NameLable);
            this.Name = "Reecipt";
            this.Text = "Reecipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox itemNameTextBox;
        private Label NameLable;
        private TextBox ItemPriceTextBox;
        private TextBox ShopperNameTextBox;
        public TextBox CustommerNameTextBox;
    }
}