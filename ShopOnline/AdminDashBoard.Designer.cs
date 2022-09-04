namespace ShopOnline
{
    partial class AdminDashBoard
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
            this.EmployeePage = new System.Windows.Forms.Button();
            this.ItemsPage = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(532, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Admin DashBoard Page";
            // 
            // EmployeePage
            // 
            this.EmployeePage.BackColor = System.Drawing.Color.Lime;
            this.EmployeePage.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmployeePage.ForeColor = System.Drawing.Color.Teal;
            this.EmployeePage.Location = new System.Drawing.Point(467, 310);
            this.EmployeePage.Name = "EmployeePage";
            this.EmployeePage.Size = new System.Drawing.Size(741, 100);
            this.EmployeePage.TabIndex = 1;
            this.EmployeePage.Text = "Go to Employee Management Page";
            this.EmployeePage.UseVisualStyleBackColor = false;
            this.EmployeePage.Click += new System.EventHandler(this.EmployeePage_Click);
            // 
            // ItemsPage
            // 
            this.ItemsPage.BackColor = System.Drawing.Color.Lime;
            this.ItemsPage.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemsPage.ForeColor = System.Drawing.Color.Teal;
            this.ItemsPage.Location = new System.Drawing.Point(467, 493);
            this.ItemsPage.Name = "ItemsPage";
            this.ItemsPage.Size = new System.Drawing.Size(741, 100);
            this.ItemsPage.TabIndex = 2;
            this.ItemsPage.Text = "Go to Items Management Page";
            this.ItemsPage.UseVisualStyleBackColor = false;
            this.ItemsPage.Click += new System.EventHandler(this.ItemsPage_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(491, 60);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Go Back to Dashboard Page";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1674, 1014);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ItemsPage);
            this.Controls.Add(this.EmployeePage);
            this.Controls.Add(this.label1);
            this.Name = "AdminDashBoard";
            this.Text = "AdminDashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button EmployeePage;
        private Button ItemsPage;
        private Button BackButton;
    }
}