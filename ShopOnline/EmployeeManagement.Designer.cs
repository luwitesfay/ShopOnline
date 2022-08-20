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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeIDtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.deletebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.employeeupdatebutton = new System.Windows.Forms.Button();
            this.empoyeeaddbutton = new System.Windows.Forms.Button();
            this.employeeagetextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.employeesocialsecuritytextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.employeeaddresstextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.employeePhonetextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.employeenametextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.employeeDataGridView);
            this.panel1.Controls.Add(this.EmployeeIDtextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.deletebutton);
            this.panel1.Controls.Add(this.clearbutton);
            this.panel1.Controls.Add(this.employeeupdatebutton);
            this.panel1.Controls.Add(this.empoyeeaddbutton);
            this.panel1.Controls.Add(this.employeeagetextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.employeesocialsecuritytextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.employeeaddresstextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.employeePhonetextBox);
            this.panel1.Controls.Add(this.label4);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            // EmployeeIDtextBox
            // 
            this.EmployeeIDtextBox.Location = new System.Drawing.Point(1256, 297);
            this.EmployeeIDtextBox.Name = "EmployeeIDtextBox";
            this.EmployeeIDtextBox.Size = new System.Drawing.Size(200, 39);
            this.EmployeeIDtextBox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1138, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 32);
            this.label8.TabIndex = 22;
            this.label8.Text = "label8";
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
            // employeeagetextBox
            // 
            this.employeeagetextBox.Location = new System.Drawing.Point(361, 301);
            this.employeeagetextBox.Name = "employeeagetextBox";
            this.employeeagetextBox.Size = new System.Drawing.Size(200, 39);
            this.employeeagetextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "label7";
            // 
            // employeesocialsecuritytextBox
            // 
            this.employeesocialsecuritytextBox.Location = new System.Drawing.Point(862, 304);
            this.employeesocialsecuritytextBox.Name = "employeesocialsecuritytextBox";
            this.employeesocialsecuritytextBox.Size = new System.Drawing.Size(200, 39);
            this.employeesocialsecuritytextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(717, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // employeeaddresstextBox
            // 
            this.employeeaddresstextBox.Location = new System.Drawing.Point(618, 200);
            this.employeeaddresstextBox.Name = "employeeaddresstextBox";
            this.employeeaddresstextBox.Size = new System.Drawing.Size(200, 39);
            this.employeeaddresstextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // employeePhonetextBox
            // 
            this.employeePhonetextBox.Location = new System.Drawing.Point(1016, 203);
            this.employeePhonetextBox.Name = "employeePhonetextBox";
            this.employeePhonetextBox.Size = new System.Drawing.Size(200, 39);
            this.employeePhonetextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(903, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // employeenametextBox
            // 
            this.employeenametextBox.Location = new System.Drawing.Point(207, 196);
            this.employeenametextBox.Name = "employeenametextBox";
            this.employeenametextBox.Size = new System.Drawing.Size(200, 39);
            this.employeenametextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 69);
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
        private TextBox employeeagetextBox;
        private Label label7;
        private TextBox employeesocialsecuritytextBox;
        private Label label6;
        private TextBox employeeaddresstextBox;
        private Label label5;
        private TextBox employeePhonetextBox;
        private Label label4;
        private TextBox employeenametextBox;
        private Label label3;
        private Button deletebutton;
        private Button clearbutton;
        private Button employeeupdatebutton;
        private Button empoyeeaddbutton;
        private TextBox EmployeeIDtextBox;
        private Label label8;
        private DataGridView employeeDataGridView;
    }
}