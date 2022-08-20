namespace ShopOnline
{
    partial class Password
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminpasswordtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adminloginbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.adminloginbutton);
            this.panel1.Controls.Add(this.adminpasswordtextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(301, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 354);
            this.panel1.TabIndex = 0;
            // 
            // adminpasswordtextBox
            // 
            this.adminpasswordtextBox.Location = new System.Drawing.Point(579, 158);
            this.adminpasswordtextBox.Name = "adminpasswordtextBox";
            this.adminpasswordtextBox.Size = new System.Drawing.Size(200, 39);
            this.adminpasswordtextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // adminloginbutton
            // 
            this.adminloginbutton.Location = new System.Drawing.Point(532, 251);
            this.adminloginbutton.Name = "adminloginbutton";
            this.adminloginbutton.Size = new System.Drawing.Size(150, 46);
            this.adminloginbutton.TabIndex = 7;
            this.adminloginbutton.Text = "button1";
            this.adminloginbutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1116, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 1246);
            this.Controls.Add(this.panel1);
            this.Name = "Password";
            this.Text = "Password";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox adminpasswordtextBox;
        private Label label2;
        private Label label1;
        private Button adminloginbutton;
    }
}