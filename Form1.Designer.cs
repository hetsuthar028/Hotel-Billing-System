namespace Practical_9
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem145 = new System.Windows.Forms.ListViewItem(new string[] {
            "Pizza",
            "70"}, -1);
            System.Windows.Forms.ListViewItem listViewItem146 = new System.Windows.Forms.ListViewItem(new string[] {
            "Vada Pav",
            "15"}, -1);
            System.Windows.Forms.ListViewItem listViewItem147 = new System.Windows.Forms.ListViewItem(new string[] {
            "McNuggets",
            "70"}, -1);
            System.Windows.Forms.ListViewItem listViewItem148 = new System.Windows.Forms.ListViewItem(new string[] {
            "Aloo Tikki",
            "27"}, -1);
            System.Windows.Forms.ListViewItem listViewItem149 = new System.Windows.Forms.ListViewItem(new string[] {
            "Oreo McFluffy",
            "80"}, -1);
            System.Windows.Forms.ListViewItem listViewItem150 = new System.Windows.Forms.ListViewItem(new string[] {
            "Sub",
            "130"}, -1);
            System.Windows.Forms.ListViewItem listViewItem151 = new System.Windows.Forms.ListViewItem(new string[] {
            "McDouble",
            "200"}, -1);
            System.Windows.Forms.ListViewItem listViewItem152 = new System.Windows.Forms.ListViewItem(new string[] {
            "Sweet Tea",
            "200"}, -1);
            System.Windows.Forms.ListViewItem listViewItem153 = new System.Windows.Forms.ListViewItem(new string[] {
            "McCafe Shakes",
            "80"}, -1);
            this.gb_menuItem = new System.Windows.Forms.GroupBox();
            this.lv_1 = new System.Windows.Forms.ListView();
            this.ch_itemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_2 = new System.Windows.Forms.ListView();
            this.ch_itemName2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_totalCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_quantity = new System.Windows.Forms.GroupBox();
            this.add = new System.Windows.Forms.Button();
            this.nup_1 = new System.Windows.Forms.NumericUpDown();
            this.lb_quantity = new System.Windows.Forms.Label();
            this.gb_order = new System.Windows.Forms.GroupBox();
            this.btn_cancelOrder = new System.Windows.Forms.Button();
            this.lb_totalResult = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.btn_order = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_estTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_menuItem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_quantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_1)).BeginInit();
            this.gb_order.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_menuItem
            // 
            this.gb_menuItem.Controls.Add(this.lv_1);
            this.gb_menuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_menuItem.Location = new System.Drawing.Point(31, 26);
            this.gb_menuItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_menuItem.Name = "gb_menuItem";
            this.gb_menuItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_menuItem.Size = new System.Drawing.Size(354, 375);
            this.gb_menuItem.TabIndex = 0;
            this.gb_menuItem.TabStop = false;
            this.gb_menuItem.Text = "Menu Items";
            // 
            // lv_1
            // 
            this.lv_1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_itemName,
            this.ch_Price});
            this.lv_1.FullRowSelect = true;
            this.lv_1.GridLines = true;
            this.lv_1.HideSelection = false;
            listViewItem145.StateImageIndex = 0;
            this.lv_1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem145,
            listViewItem146,
            listViewItem147,
            listViewItem148,
            listViewItem149,
            listViewItem150,
            listViewItem151,
            listViewItem152,
            listViewItem153});
            this.lv_1.Location = new System.Drawing.Point(26, 29);
            this.lv_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lv_1.Name = "lv_1";
            this.lv_1.Size = new System.Drawing.Size(304, 316);
            this.lv_1.TabIndex = 0;
            this.lv_1.UseCompatibleStateImageBehavior = false;
            this.lv_1.View = System.Windows.Forms.View.Details;
            // 
            // ch_itemName
            // 
            this.ch_itemName.Text = "Item Name";
            this.ch_itemName.Width = 120;
            // 
            // ch_Price
            // 
            this.ch_Price.Text = "Price";
            this.ch_Price.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(416, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(345, 375);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Added Items";
            // 
            // lv_2
            // 
            this.lv_2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_itemName2,
            this.ch_totalCost,
            this.ch_Quantity});
            this.lv_2.FullRowSelect = true;
            this.lv_2.GridLines = true;
            this.lv_2.HideSelection = false;
            this.lv_2.Location = new System.Drawing.Point(24, 29);
            this.lv_2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lv_2.Name = "lv_2";
            this.lv_2.Size = new System.Drawing.Size(296, 316);
            this.lv_2.TabIndex = 0;
            this.lv_2.UseCompatibleStateImageBehavior = false;
            this.lv_2.View = System.Windows.Forms.View.Details;
            // 
            // ch_itemName2
            // 
            this.ch_itemName2.Text = "Item Name";
            this.ch_itemName2.Width = 120;
            // 
            // ch_totalCost
            // 
            this.ch_totalCost.Text = "Total Cost";
            this.ch_totalCost.Width = 80;
            // 
            // ch_Quantity
            // 
            this.ch_Quantity.Text = "Quantity";
            // 
            // gb_quantity
            // 
            this.gb_quantity.Controls.Add(this.add);
            this.gb_quantity.Controls.Add(this.nup_1);
            this.gb_quantity.Controls.Add(this.lb_quantity);
            this.gb_quantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_quantity.Location = new System.Drawing.Point(57, 420);
            this.gb_quantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_quantity.Name = "gb_quantity";
            this.gb_quantity.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_quantity.Size = new System.Drawing.Size(306, 154);
            this.gb_quantity.TabIndex = 2;
            this.gb_quantity.TabStop = false;
            this.gb_quantity.Text = "Quantity";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(84, 101);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(95, 34);
            this.add.TabIndex = 4;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // nup_1
            // 
            this.nup_1.Location = new System.Drawing.Point(96, 46);
            this.nup_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nup_1.Name = "nup_1";
            this.nup_1.Size = new System.Drawing.Size(180, 28);
            this.nup_1.TabIndex = 3;
            // 
            // lb_quantity
            // 
            this.lb_quantity.AutoSize = true;
            this.lb_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quantity.Location = new System.Drawing.Point(9, 52);
            this.lb_quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_quantity.Name = "lb_quantity";
            this.lb_quantity.Size = new System.Drawing.Size(79, 20);
            this.lb_quantity.TabIndex = 0;
            this.lb_quantity.Text = "Quantity";
            // 
            // gb_order
            // 
            this.gb_order.Controls.Add(this.btn_cancelOrder);
            this.gb_order.Controls.Add(this.lb_totalResult);
            this.gb_order.Controls.Add(this.lb_total);
            this.gb_order.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_order.Location = new System.Drawing.Point(440, 420);
            this.gb_order.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_order.Name = "gb_order";
            this.gb_order.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_order.Size = new System.Drawing.Size(298, 154);
            this.gb_order.TabIndex = 3;
            this.gb_order.TabStop = false;
            this.gb_order.Text = "Order";
            // 
            // btn_cancelOrder
            // 
            this.btn_cancelOrder.Location = new System.Drawing.Point(54, 89);
            this.btn_cancelOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancelOrder.Name = "btn_cancelOrder";
            this.btn_cancelOrder.Size = new System.Drawing.Size(180, 35);
            this.btn_cancelOrder.TabIndex = 2;
            this.btn_cancelOrder.Text = "Cancel Item";
            this.btn_cancelOrder.UseVisualStyleBackColor = true;
            this.btn_cancelOrder.Click += new System.EventHandler(this.btn_cancelOrder_Click);
            // 
            // lb_totalResult
            // 
            this.lb_totalResult.AutoSize = true;
            this.lb_totalResult.Location = new System.Drawing.Point(128, 46);
            this.lb_totalResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_totalResult.Name = "lb_totalResult";
            this.lb_totalResult.Size = new System.Drawing.Size(20, 22);
            this.lb_totalResult.TabIndex = 1;
            this.lb_totalResult.Text = "0";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Location = new System.Drawing.Point(28, 46);
            this.lb_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(62, 22);
            this.lb_total.TabIndex = 0;
            this.lb_total.Text = "Total: ";
            // 
            // btn_order
            // 
            this.btn_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.Location = new System.Drawing.Point(251, 600);
            this.btn_order.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(112, 35);
            this.btn_order.TabIndex = 4;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(440, 600);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(117, 37);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_estTime);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(807, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 548);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Waiting Orders";
            // 
            // lb_estTime
            // 
            this.lb_estTime.AutoSize = true;
            this.lb_estTime.Location = new System.Drawing.Point(378, 482);
            this.lb_estTime.Name = "lb_estTime";
            this.lb_estTime.Size = new System.Drawing.Size(14, 19);
            this.lb_estTime.TabIndex = 10;
            this.lb_estTime.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Estimated Time :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(616, 399);
            this.dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1022, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1189, 600);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1510, 108);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 723);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Github ID : hetsuthar028";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1840, 808);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.gb_order);
            this.Controls.Add(this.gb_quantity);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_menuItem);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Hotel Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_menuItem.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gb_quantity.ResumeLayout(false);
            this.gb_quantity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_1)).EndInit();
            this.gb_order.ResumeLayout(false);
            this.gb_order.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_menuItem;
        private System.Windows.Forms.ListView lv_1;
        private System.Windows.Forms.ColumnHeader ch_itemName;
        private System.Windows.Forms.ColumnHeader ch_Price;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lv_2;
        private System.Windows.Forms.ColumnHeader ch_itemName2;
        private System.Windows.Forms.ColumnHeader ch_totalCost;
        private System.Windows.Forms.GroupBox gb_quantity;
        private System.Windows.Forms.NumericUpDown nup_1;
        private System.Windows.Forms.Label lb_quantity;
        private System.Windows.Forms.GroupBox gb_order;
        private System.Windows.Forms.Button btn_cancelOrder;
        private System.Windows.Forms.Label lb_totalResult;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ColumnHeader ch_Quantity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_estTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
    }
}

