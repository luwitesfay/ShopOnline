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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ItemPriceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.Removebutton = new System.Windows.Forms.Button();
            this.Reciptbutton = new System.Windows.Forms.Button();
            this.labeltotal = new System.Windows.Forms.Label();
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
            this.TotalLabel = new System.Windows.Forms.Label();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ItemPriceTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.itemNameTextBox);
            this.panel1.Controls.Add(this.Removebutton);
            this.panel1.Controls.Add(this.Reciptbutton);
            this.panel1.Controls.Add(this.labeltotal);
            this.panel1.Controls.Add(this.ItemsDataGridView);
            this.panel1.Controls.Add(this.CartDataGridView);
            this.panel1.Controls.Add(this.AddToCartButton);
            this.panel1.Controls.Add(this.ItemAmountTextBox);
            this.panel1.Controls.Add(this.ShopperNameTextBox);
            this.panel1.Controls.Add(this.CustommerNameTextBox);
            this.panel1.Controls.Add(this.TotalLabel);
            this.panel1.Controls.Add(this.Resetbutton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(304, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1383, 1245);
            this.panel1.TabIndex = 1;
            // 
            // ItemPriceTextBox
            // 
            this.ItemPriceTextBox.Location = new System.Drawing.Point(453, 773);
            this.ItemPriceTextBox.Name = "ItemPriceTextBox";
            this.ItemPriceTextBox.Size = new System.Drawing.Size(200, 39);
            this.ItemPriceTextBox.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 773);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 32);
            this.label4.TabIndex = 32;
            this.label4.Text = "label4";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Enabled = false;
            this.itemNameTextBox.Location = new System.Drawing.Point(181, 773);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(200, 39);
            this.itemNameTextBox.TabIndex = 31;
            // 
            // Removebutton
            // 
            this.Removebutton.Location = new System.Drawing.Point(1168, 1058);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(150, 46);
            this.Removebutton.TabIndex = 29;
            this.Removebutton.Text = "button2";
            this.Removebutton.UseVisualStyleBackColor = true;
            // 
            // Reciptbutton
            // 
            this.Reciptbutton.Location = new System.Drawing.Point(1179, 1124);
            this.Reciptbutton.Name = "Reciptbutton";
            this.Reciptbutton.Size = new System.Drawing.Size(150, 46);
            this.Reciptbutton.TabIndex = 28;
            this.Reciptbutton.Text = "button2";
            this.Reciptbutton.UseVisualStyleBackColor = true;
            this.Reciptbutton.Click += new System.EventHandler(this.Reciptbutton_Click);
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.Location = new System.Drawing.Point(1190, 979);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(78, 32);
            this.labeltotal.TabIndex = 27;
            this.labeltotal.Text = "label4";
            this.labeltotal.Click += new System.EventHandler(this.label4_Click);
            // 
            // ItemsDataGridView
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGridView.Location = new System.Drawing.Point(34, 334);
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ItemsDataGridView.RowTemplate.Height = 41;
            this.ItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsDataGridView.Size = new System.Drawing.Size(1100, 403);
            this.ItemsDataGridView.TabIndex = 26;
            this.ItemsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsDataGridView_CellContentClick);
            // 
            // CartDataGridView
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CartDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.CartDataGridView.Location = new System.Drawing.Point(34, 882);
            this.CartDataGridView.Name = "CartDataGridView";
            this.CartDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.CartDataGridView.RowTemplate.Height = 41;
            this.CartDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartDataGridView.Size = new System.Drawing.Size(1100, 342);
            this.CartDataGridView.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Item Price";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Amount";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Location = new System.Drawing.Point(1146, 517);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(150, 46);
            this.AddToCartButton.TabIndex = 10;
            this.AddToCartButton.Text = "button2";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // ItemAmountTextBox
            // 
            this.ItemAmountTextBox.Location = new System.Drawing.Point(873, 766);
            this.ItemAmountTextBox.Name = "ItemAmountTextBox";
            this.ItemAmountTextBox.Size = new System.Drawing.Size(200, 39);
            this.ItemAmountTextBox.TabIndex = 9;
            // 
            // ShopperNameTextBox
            // 
            this.ShopperNameTextBox.Location = new System.Drawing.Point(234, 221);
            this.ShopperNameTextBox.Name = "ShopperNameTextBox";
            this.ShopperNameTextBox.Size = new System.Drawing.Size(200, 39);
            this.ShopperNameTextBox.TabIndex = 8;
            // 
            // CustommerNameTextBox
            // 
            this.CustommerNameTextBox.Location = new System.Drawing.Point(639, 228);
            this.CustommerNameTextBox.Name = "CustommerNameTextBox";
            this.CustommerNameTextBox.Size = new System.Drawing.Size(200, 39);
            this.CustommerNameTextBox.TabIndex = 7;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(734, 766);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(78, 32);
            this.TotalLabel.TabIndex = 6;
            this.TotalLabel.Text = "label4";
            // 
            // Resetbutton
            // 
            this.Resetbutton.Location = new System.Drawing.Point(1158, 621);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(150, 46);
            this.Resetbutton.TabIndex = 5;
            this.Resetbutton.Text = "button2";
            this.Resetbutton.UseVisualStyleBackColor = true;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
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
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView ItemsDataGridView;
        public DataGridView CartDataGridView;
        private Button AddToCartButton;
        private TextBox ItemAmountTextBox;
        private TextBox ShopperNameTextBox;
        private TextBox CustommerNameTextBox;
        private Label TotalLabel;
        private Button Resetbutton;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Reciptbutton;
        private Label labeltotal;
        private Button Removebutton;
        private TextBox itemNameTextBox;
        private Label label4;
        private TextBox ItemPriceTextBox;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}