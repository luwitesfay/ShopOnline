namespace ShopOnline
{
    partial class AdminLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.AdminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.AdminLoginbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // AdminPasswordTextBox
            // 
            this.AdminPasswordTextBox.Location = new System.Drawing.Point(227, 140);
            this.AdminPasswordTextBox.Name = "AdminPasswordTextBox";
            this.AdminPasswordTextBox.Size = new System.Drawing.Size(200, 39);
            this.AdminPasswordTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AdminLoginbutton);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AdminPasswordTextBox);
            this.panel1.Location = new System.Drawing.Point(403, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 293);
            this.panel1.TabIndex = 2;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(331, 19);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(150, 46);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "button1";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // AdminLoginbutton
            // 
            this.AdminLoginbutton.Location = new System.Drawing.Point(203, 227);
            this.AdminLoginbutton.Name = "AdminLoginbutton";
            this.AdminLoginbutton.Size = new System.Drawing.Size(150, 46);
            this.AdminLoginbutton.TabIndex = 9;
            this.AdminLoginbutton.Text = "button1";
            this.AdminLoginbutton.UseVisualStyleBackColor = true;
            this.AdminLoginbutton.Click += new System.EventHandler(this.AdminLoginbutton_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 862);
            this.Controls.Add(this.panel1);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox AdminPasswordTextBox;
        private Panel panel1;
        private Button AdminLoginbutton;
        private Button BackButton;
    }
}