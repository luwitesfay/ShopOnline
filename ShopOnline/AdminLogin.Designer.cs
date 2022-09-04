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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.AdminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminLoginbutton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Passoword";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdminPasswordTextBox
            // 
            this.AdminPasswordTextBox.Location = new System.Drawing.Point(353, 129);
            this.AdminPasswordTextBox.Name = "AdminPasswordTextBox";
            this.AdminPasswordTextBox.Size = new System.Drawing.Size(235, 39);
            this.AdminPasswordTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.AdminLoginbutton);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AdminPasswordTextBox);
            this.panel1.Location = new System.Drawing.Point(492, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 339);
            this.panel1.TabIndex = 2;
            // 
            // AdminLoginbutton
            // 
            this.AdminLoginbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.AdminLoginbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdminLoginbutton.Location = new System.Drawing.Point(245, 206);
            this.AdminLoginbutton.Name = "AdminLoginbutton";
            this.AdminLoginbutton.Size = new System.Drawing.Size(199, 79);
            this.AdminLoginbutton.TabIndex = 9;
            this.AdminLoginbutton.Text = "Login";
            this.AdminLoginbutton.UseVisualStyleBackColor = false;
            this.AdminLoginbutton.Click += new System.EventHandler(this.AdminLoginbutton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(535, 15);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(74, 49);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "X";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1674, 1014);
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