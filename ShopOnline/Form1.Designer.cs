namespace ShopOnline
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminLogInLabel = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.adminLogInLabel);
            this.panel1.Controls.Add(this.loginbutton);
            this.panel1.Controls.Add(this.passwordtextBox);
            this.panel1.Controls.Add(this.usernametextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(384, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 661);
            this.panel1.TabIndex = 0;
            // 
            // adminLogInLabel
            // 
            this.adminLogInLabel.AutoSize = true;
            this.adminLogInLabel.Location = new System.Drawing.Point(400, 518);
            this.adminLogInLabel.Name = "adminLogInLabel";
            this.adminLogInLabel.Size = new System.Drawing.Size(78, 32);
            this.adminLogInLabel.TabIndex = 6;
            this.adminLogInLabel.Text = "label4";
            this.adminLogInLabel.Click += new System.EventHandler(this.adminLogInLabel_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(472, 425);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(150, 46);
            this.loginbutton.TabIndex = 5;
            this.loginbutton.Text = "button1";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(267, 293);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(200, 39);
            this.passwordtextBox.TabIndex = 4;
            // 
            // usernametextBox
            // 
            this.usernametextBox.Location = new System.Drawing.Point(267, 183);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(200, 39);
            this.usernametextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(839, 27);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 46);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "button1";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1860, 1062);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button loginbutton;
        private TextBox passwordtextBox;
        private TextBox usernametextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label adminLogInLabel;
        private Button exitButton;
    }
}