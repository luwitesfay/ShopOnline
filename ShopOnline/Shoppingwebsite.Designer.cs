namespace ShopOnline
{
    partial class Shoppingwebsite
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shoppingwebsite));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LogOutLabel = new System.Windows.Forms.Label();
            this.ItemPriceTextBox = new System.Windows.Forms.TextBox();
            this.Removebutton = new System.Windows.Forms.Button();
            this.Reciptbutton = new System.Windows.Forms.Button();
            this.totalAmountLB = new System.Windows.Forms.Label();
            this.ItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.CartDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.ItemAmountTextBox = new System.Windows.Forms.TextBox();
            this.ShopperNameTextBox = new System.Windows.Forms.TextBox();
            this.CustommerNameTextBox = new System.Windows.Forms.TextBox();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.itemNameTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LogOutLabel);
            this.panel1.Controls.Add(this.ItemPriceTextBox);
            this.panel1.Controls.Add(this.Removebutton);
            this.panel1.Controls.Add(this.Reciptbutton);
            this.panel1.Controls.Add(this.totalAmountLB);
            this.panel1.Controls.Add(this.ItemsDataGridView);
            this.panel1.Controls.Add(this.CartDataGridView);
            this.panel1.Controls.Add(this.AddToCartButton);
            this.panel1.Controls.Add(this.ItemAmountTextBox);
            this.panel1.Controls.Add(this.ShopperNameTextBox);
            this.panel1.Controls.Add(this.CustommerNameTextBox);
            this.panel1.Controls.Add(this.Resetbutton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(102, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1729, 1194);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(1631, 13);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(74, 49);
            this.BackButton.TabIndex = 39;
            this.BackButton.Text = "X";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Enabled = false;
            this.itemNameTextBox.Location = new System.Drawing.Point(1491, 307);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(211, 39);
            this.itemNameTextBox.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1322, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 36);
            this.label6.TabIndex = 37;
            this.label6.Text = "Item Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1322, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 36);
            this.label5.TabIndex = 36;
            this.label5.Text = "Item Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1333, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 36);
            this.label4.TabIndex = 35;
            this.label4.Text = "Amount:";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // LogOutLabel
            // 
            this.LogOutLabel.AutoSize = true;
            this.LogOutLabel.Location = new System.Drawing.Point(1218, 54);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Size = new System.Drawing.Size(0, 32);
            this.LogOutLabel.TabIndex = 34;
            this.LogOutLabel.Click += new System.EventHandler(this.LogOutLabel_Click);
            // 
            // ItemPriceTextBox
            // 
            this.ItemPriceTextBox.Enabled = false;
            this.ItemPriceTextBox.Location = new System.Drawing.Point(1494, 369);
            this.ItemPriceTextBox.Name = "ItemPriceTextBox";
            this.ItemPriceTextBox.Size = new System.Drawing.Size(211, 39);
            this.ItemPriceTextBox.TabIndex = 33;
            // 
            // Removebutton
            // 
            this.Removebutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Removebutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Removebutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Removebutton.Location = new System.Drawing.Point(1322, 988);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(166, 46);
            this.Removebutton.TabIndex = 29;
            this.Removebutton.Text = "REMOVE";
            this.Removebutton.UseVisualStyleBackColor = false;
            this.Removebutton.Click += new System.EventHandler(this.Removebutton_Click);
            // 
            // Reciptbutton
            // 
            this.Reciptbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Reciptbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Reciptbutton.Location = new System.Drawing.Point(1522, 988);
            this.Reciptbutton.Name = "Reciptbutton";
            this.Reciptbutton.Size = new System.Drawing.Size(150, 46);
            this.Reciptbutton.TabIndex = 28;
            this.Reciptbutton.Text = "RECIPT";
            this.Reciptbutton.UseVisualStyleBackColor = false;
            this.Reciptbutton.Click += new System.EventHandler(this.Reciptbutton_Click);
            // 
            // totalAmountLB
            // 
            this.totalAmountLB.AutoSize = true;
            this.totalAmountLB.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalAmountLB.Location = new System.Drawing.Point(1467, 887);
            this.totalAmountLB.Name = "totalAmountLB";
            this.totalAmountLB.Size = new System.Drawing.Size(91, 42);
            this.totalAmountLB.TabIndex = 27;
            this.totalAmountLB.Text = "Total";
            this.totalAmountLB.Click += new System.EventHandler(this.label4_Click);
            // 
            // ItemsDataGridView
            // 
            this.ItemsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGridView.Location = new System.Drawing.Point(69, 277);
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ItemsDataGridView.RowTemplate.Height = 41;
            this.ItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsDataGridView.Size = new System.Drawing.Size(1227, 403);
            this.ItemsDataGridView.TabIndex = 26;
            this.ItemsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsDataGridView_CellContentClick);
            // 
            // CartDataGridView
            // 
            this.CartDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CartDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.CartDataGridView.Location = new System.Drawing.Point(104, 780);
            this.CartDataGridView.Name = "CartDataGridView";
            this.CartDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.CartDataGridView.RowTemplate.Height = 41;
            this.CartDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartDataGridView.Size = new System.Drawing.Size(1212, 342);
            this.CartDataGridView.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 225;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 225;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Item Price";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Amount";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.Width = 250;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddToCartButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddToCartButton.Location = new System.Drawing.Point(1338, 513);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(150, 46);
            this.AddToCartButton.TabIndex = 10;
            this.AddToCartButton.Text = "ADD";
            this.AddToCartButton.UseVisualStyleBackColor = false;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // ItemAmountTextBox
            // 
            this.ItemAmountTextBox.Location = new System.Drawing.Point(1494, 428);
            this.ItemAmountTextBox.Name = "ItemAmountTextBox";
            this.ItemAmountTextBox.Size = new System.Drawing.Size(211, 39);
            this.ItemAmountTextBox.TabIndex = 9;
            this.ItemAmountTextBox.TextChanged += new System.EventHandler(this.ItemAmountTextBox_TextChanged);
            // 
            // ShopperNameTextBox
            // 
            this.ShopperNameTextBox.Location = new System.Drawing.Point(332, 152);
            this.ShopperNameTextBox.Name = "ShopperNameTextBox";
            this.ShopperNameTextBox.Size = new System.Drawing.Size(234, 39);
            this.ShopperNameTextBox.TabIndex = 8;
            // 
            // CustommerNameTextBox
            // 
            this.CustommerNameTextBox.Location = new System.Drawing.Point(968, 149);
            this.CustommerNameTextBox.Name = "CustommerNameTextBox";
            this.CustommerNameTextBox.Size = new System.Drawing.Size(200, 39);
            this.CustommerNameTextBox.TabIndex = 7;
            // 
            // Resetbutton
            // 
            this.Resetbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Resetbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Resetbutton.Location = new System.Drawing.Point(1544, 513);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(150, 46);
            this.Resetbutton.TabIndex = 5;
            this.Resetbutton.Text = "CLEAR";
            this.Resetbutton.UseVisualStyleBackColor = false;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(625, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(69, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(645, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grocery Shopping";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(1055, 215);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(200, 39);
            this.searchTextBox.TabIndex = 40;
            // 
            // Shoppingwebsite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1303);
            this.Controls.Add(this.panel1);
            this.Name = "Shoppingwebsite";
            this.Text = "Shoppingwebsite";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView ItemsDataGridView;
        public DataGridView CartDataGridView;
        private Button AddToCartButton;
        private TextBox ItemAmountTextBox;
        private Button Resetbutton;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Reciptbutton;
        private Label totalAmountLB;
        private Button Removebutton;
        private TextBox ItemPriceTextBox;
        private Label LogOutLabel;
        private Label label5;
        private Label label4;
        private TextBox itemNameTextBox;
        private Label label6;
        private Button BackButton;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        public TextBox CustommerNameTextBox;
        public TextBox ShopperNameTextBox;
        public TextBox searchTextBox;
        private BindingSource bindingSource1;
    }
}