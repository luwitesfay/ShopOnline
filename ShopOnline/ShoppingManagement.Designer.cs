namespace ShopOnline
{
    partial class ShoppingManagement
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
            this.AddButton = new System.Windows.Forms.Button();
            this.CategoriescomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.ItemPriceTextBox = new System.Windows.Forms.TextBox();
            this.ItemAmountTextBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BackButton = new System.Windows.Forms.Button();
            this.SearchTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.LimeGreen;
            this.AddButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(47, 578);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(155, 70);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CategoriescomboBox
            // 
            this.CategoriescomboBox.FormattingEnabled = true;
            this.CategoriescomboBox.Items.AddRange(new object[] {
            "Coffee",
            "Cookies",
            "Donuts",
            "Soft Drinks",
            "Tea",
            ""});
            this.CategoriescomboBox.Location = new System.Drawing.Point(285, 181);
            this.CategoriescomboBox.Name = "CategoriescomboBox";
            this.CategoriescomboBox.Size = new System.Drawing.Size(242, 40);
            this.CategoriescomboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(690, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Items Management Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item Catagory:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(47, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Item Price:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(47, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "Item Amount:";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(285, 255);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(242, 39);
            this.itemNameTextBox.TabIndex = 8;
            // 
            // ItemPriceTextBox
            // 
            this.ItemPriceTextBox.Location = new System.Drawing.Point(285, 329);
            this.ItemPriceTextBox.Name = "ItemPriceTextBox";
            this.ItemPriceTextBox.Size = new System.Drawing.Size(242, 39);
            this.ItemPriceTextBox.TabIndex = 9;
            this.ItemPriceTextBox.TextChanged += new System.EventHandler(this.ItemPriceTextBox_TextChanged);
            // 
            // ItemAmountTextBox
            // 
            this.ItemAmountTextBox.Location = new System.Drawing.Point(285, 407);
            this.ItemAmountTextBox.Name = "ItemAmountTextBox";
            this.ItemAmountTextBox.Size = new System.Drawing.Size(242, 39);
            this.ItemAmountTextBox.TabIndex = 10;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Gold;
            this.UpdateButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.Location = new System.Drawing.Point(266, 578);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(170, 70);
            this.UpdateButton.TabIndex = 11;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.Location = new System.Drawing.Point(504, 578);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(175, 70);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ItemsDataGridView
            // 
            this.ItemsDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGridView.Location = new System.Drawing.Point(587, 181);
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ItemsDataGridView.RowTemplate.Height = 41;
            this.ItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsDataGridView.Size = new System.Drawing.Size(1292, 384);
            this.ItemsDataGridView.TabIndex = 25;
            this.ItemsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsDataGridView_CellContentClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 992);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1879, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 12);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(1793, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(74, 49);
            this.BackButton.TabIndex = 30;
            this.BackButton.Text = "X";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SearchTB
            // 
            this.SearchTB.Location = new System.Drawing.Point(1548, 117);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(242, 39);
            this.SearchTB.TabIndex = 31;
            // 
            // ShoppingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1879, 1014);
            this.Controls.Add(this.SearchTB);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ItemsDataGridView);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ItemAmountTextBox);
            this.Controls.Add(this.ItemPriceTextBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoriescomboBox);
            this.Controls.Add(this.AddButton);
            this.Name = "ShoppingManagement";
            this.Text = "ShoppingManagement";
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddButton;
        private ComboBox CategoriescomboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox itemNameTextBox;
        private TextBox ItemPriceTextBox;
        private Button UpdateButton;
        private Button DeleteButton;
        private DataGridView ItemsDataGridView;
        public TextBox ItemAmountTextBox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button BackButton;
        private TextBox SearchTB;
    }
}