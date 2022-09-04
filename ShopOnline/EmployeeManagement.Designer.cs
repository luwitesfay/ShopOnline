namespace ShopOnline
{
    partial class EmployeeManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeePassowordTextBox = new System.Windows.Forms.TextBox();
            this.deletebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.employeeupdatebutton = new System.Windows.Forms.Button();
            this.empoyeeaddbutton = new System.Windows.Forms.Button();
            this.employeeEmailTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.employeeaddresstextBox = new System.Windows.Forms.TextBox();
            this.employeePhonetextBox = new System.Windows.Forms.TextBox();
            this.employeenametextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.employeeDataGridView);
            this.panel1.Controls.Add(this.EmployeePassowordTextBox);
            this.panel1.Controls.Add(this.deletebutton);
            this.panel1.Controls.Add(this.clearbutton);
            this.panel1.Controls.Add(this.employeeupdatebutton);
            this.panel1.Controls.Add(this.empoyeeaddbutton);
            this.panel1.Controls.Add(this.employeeEmailTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.employeeaddresstextBox);
            this.panel1.Controls.Add(this.employeePhonetextBox);
            this.panel1.Controls.Add(this.employeenametextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1855, 1180);
            this.panel1.TabIndex = 0;
            // 
            // employeeDataGridView
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Location = new System.Drawing.Point(7, 753);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.employeeDataGridView.RowTemplate.Height = 41;
            this.employeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeDataGridView.Size = new System.Drawing.Size(1845, 384);
            this.employeeDataGridView.TabIndex = 24;
            this.employeeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDataGridView_CellContentClick);
            // 
            // EmployeePassowordTextBox
            // 
            this.EmployeePassowordTextBox.Location = new System.Drawing.Point(1180, 301);
            this.EmployeePassowordTextBox.Name = "EmployeePassowordTextBox";
            this.EmployeePassowordTextBox.Size = new System.Drawing.Size(297, 39);
            this.EmployeePassowordTextBox.TabIndex = 23;
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(802, 464);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(150, 46);
            this.deletebutton.TabIndex = 20;
            this.deletebutton.Text = "button1";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(1016, 464);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(150, 46);
            this.clearbutton.TabIndex = 19;
            this.clearbutton.Text = "button1";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // employeeupdatebutton
            // 
            this.employeeupdatebutton.Location = new System.Drawing.Point(563, 464);
            this.employeeupdatebutton.Name = "employeeupdatebutton";
            this.employeeupdatebutton.Size = new System.Drawing.Size(150, 46);
            this.employeeupdatebutton.TabIndex = 18;
            this.employeeupdatebutton.Text = "button1";
            this.employeeupdatebutton.UseVisualStyleBackColor = true;
            this.employeeupdatebutton.Click += new System.EventHandler(this.employeeupdatebutton_Click);
            // 
            // empoyeeaddbutton
            // 
            this.empoyeeaddbutton.Location = new System.Drawing.Point(337, 464);
            this.empoyeeaddbutton.Name = "empoyeeaddbutton";
            this.empoyeeaddbutton.Size = new System.Drawing.Size(150, 46);
            this.empoyeeaddbutton.TabIndex = 17;
            this.empoyeeaddbutton.Text = "button1";
            this.empoyeeaddbutton.UseVisualStyleBackColor = true;
            this.empoyeeaddbutton.Click += new System.EventHandler(this.empoyeeaddbutton_Click);
            // 
            // employeeEmailTextBox
            // 
            this.employeeEmailTextBox.Location = new System.Drawing.Point(575, 296);
            this.employeeEmailTextBox.Name = "employeeEmailTextBox";
            this.employeeEmailTextBox.Size = new System.Drawing.Size(358, 39);
            this.employeeEmailTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 32);
            this.label7.TabIndex = 15;
            // 
            // employeeaddresstextBox
            // 
            this.employeeaddresstextBox.Location = new System.Drawing.Point(761, 196);
            this.employeeaddresstextBox.Name = "employeeaddresstextBox";
            this.employeeaddresstextBox.Size = new System.Drawing.Size(327, 39);
            this.employeeaddresstextBox.TabIndex = 12;
            // 
            // employeePhonetextBox
            // 
            this.employeePhonetextBox.Location = new System.Drawing.Point(1437, 198);
            this.employeePhonetextBox.Name = "employeePhonetextBox";
            this.employeePhonetextBox.Size = new System.Drawing.Size(330, 39);
            this.employeePhonetextBox.TabIndex = 10;
            // 
            // employeenametextBox
            // 
            this.employeenametextBox.Location = new System.Drawing.Point(207, 196);
            this.employeenametextBox.Name = "employeenametextBox";
            this.employeenametextBox.Size = new System.Drawing.Size(293, 39);
            this.employeenametextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(91, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(802, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(871, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1016, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 36);
            this.label6.TabIndex = 25;
            this.label6.Text = "Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1202, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 36);
            this.label9.TabIndex = 26;
            this.label9.Text = "Phone Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(618, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 36);
            this.label10.TabIndex = 27;
            this.label10.Text = "Address:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(451, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 36);
            this.label11.TabIndex = 28;
            this.label11.Text = "Email:";
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 1318);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeManagement";
            this.Text = "EmployeeManagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox employeeEmailTextBox;
        private Label label7;
        private TextBox employeeaddresstextBox;
        private TextBox employeePhonetextBox;
        private TextBox employeenametextBox;
        private Label label3;
        private Button deletebutton;
        private Button clearbutton;
        private Button employeeupdatebutton;
        private Button empoyeeaddbutton;
        private TextBox EmployeePassowordTextBox;
        private DataGridView employeeDataGridView;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label6;
    }
}