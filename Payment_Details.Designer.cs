namespace Practical_9
{
    partial class Payment_Details
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
            this.lb_CustFName = new System.Windows.Forms.Label();
            this.lb_CustLName = new System.Windows.Forms.Label();
            this.tb_CustFName = new System.Windows.Forms.TextBox();
            this.tb_CustLName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_CustPNO = new System.Windows.Forms.TextBox();
            this.lb_CustAdd = new System.Windows.Forms.Label();
            this.tb_CustAdd = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Items = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lb_totalCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_MOP_Cash = new System.Windows.Forms.CheckBox();
            this.cb_MOP_Online = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cb_COD = new System.Windows.Forms.CheckBox();
            this.cb_Parcel = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_OID = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_CustFName
            // 
            this.lb_CustFName.AutoSize = true;
            this.lb_CustFName.Location = new System.Drawing.Point(82, 61);
            this.lb_CustFName.Name = "lb_CustFName";
            this.lb_CustFName.Size = new System.Drawing.Size(142, 23);
            this.lb_CustFName.TabIndex = 0;
            this.lb_CustFName.Text = "First Name :";
            // 
            // lb_CustLName
            // 
            this.lb_CustLName.AutoSize = true;
            this.lb_CustLName.Location = new System.Drawing.Point(93, 109);
            this.lb_CustLName.Name = "lb_CustLName";
            this.lb_CustLName.Size = new System.Drawing.Size(131, 23);
            this.lb_CustLName.TabIndex = 1;
            this.lb_CustLName.Text = "Last Name :";
            // 
            // tb_CustFName
            // 
            this.tb_CustFName.Location = new System.Drawing.Point(278, 58);
            this.tb_CustFName.Name = "tb_CustFName";
            this.tb_CustFName.Size = new System.Drawing.Size(127, 31);
            this.tb_CustFName.TabIndex = 2;
            // 
            // tb_CustLName
            // 
            this.tb_CustLName.Location = new System.Drawing.Point(278, 106);
            this.tb_CustLName.Name = "tb_CustLName";
            this.tb_CustLName.Size = new System.Drawing.Size(127, 31);
            this.tb_CustLName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phone Number :";
            // 
            // tb_CustPNO
            // 
            this.tb_CustPNO.Location = new System.Drawing.Point(278, 157);
            this.tb_CustPNO.Name = "tb_CustPNO";
            this.tb_CustPNO.Size = new System.Drawing.Size(127, 31);
            this.tb_CustPNO.TabIndex = 5;
            // 
            // lb_CustAdd
            // 
            this.lb_CustAdd.AutoSize = true;
            this.lb_CustAdd.Location = new System.Drawing.Point(115, 38);
            this.lb_CustAdd.Name = "lb_CustAdd";
            this.lb_CustAdd.Size = new System.Drawing.Size(109, 23);
            this.lb_CustAdd.TabIndex = 6;
            this.lb_CustAdd.Text = "Address :";
            // 
            // tb_CustAdd
            // 
            this.tb_CustAdd.Location = new System.Drawing.Point(278, 30);
            this.tb_CustAdd.Name = "tb_CustAdd";
            this.tb_CustAdd.Size = new System.Drawing.Size(127, 31);
            this.tb_CustAdd.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Items,
            this.Quantity,
            this.Cost});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(64, 188);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(356, 380);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Items
            // 
            this.Items.Text = "Items";
            this.Items.Width = 92;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 85;
            // 
            // Cost
            // 
            this.Cost.Text = "Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 623);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total :";
            // 
            // lb_totalCost
            // 
            this.lb_totalCost.AutoSize = true;
            this.lb_totalCost.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalCost.Location = new System.Drawing.Point(238, 626);
            this.lb_totalCost.Name = "lb_totalCost";
            this.lb_totalCost.Size = new System.Drawing.Size(73, 27);
            this.lb_totalCost.TabIndex = 10;
            this.lb_totalCost.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mode Of Payment :";
            // 
            // cb_MOP_Cash
            // 
            this.cb_MOP_Cash.AutoSize = true;
            this.cb_MOP_Cash.Location = new System.Drawing.Point(278, 52);
            this.cb_MOP_Cash.Name = "cb_MOP_Cash";
            this.cb_MOP_Cash.Size = new System.Drawing.Size(80, 27);
            this.cb_MOP_Cash.TabIndex = 12;
            this.cb_MOP_Cash.Text = "Cash";
            this.cb_MOP_Cash.UseVisualStyleBackColor = true;
            // 
            // cb_MOP_Online
            // 
            this.cb_MOP_Online.AutoSize = true;
            this.cb_MOP_Online.Location = new System.Drawing.Point(389, 52);
            this.cb_MOP_Online.Name = "cb_MOP_Online";
            this.cb_MOP_Online.Size = new System.Drawing.Size(102, 27);
            this.cb_MOP_Online.TabIndex = 13;
            this.cb_MOP_Online.Text = "Online";
            this.cb_MOP_Online.UseVisualStyleBackColor = true;
            this.cb_MOP_Online.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Wallet :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "Proceed Payment";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_CustFName);
            this.groupBox1.Controls.Add(this.tb_CustFName);
            this.groupBox1.Controls.Add(this.lb_CustLName);
            this.groupBox1.Controls.Add(this.tb_CustLName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_CustPNO);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(86, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 225);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cb_MOP_Cash);
            this.groupBox2.Controls.Add(this.cb_MOP_Online);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(86, 464);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 286);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(238, 107);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 162);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Online";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(32, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 162);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cash";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 44);
            this.button2.TabIndex = 19;
            this.button2.Text = "Paid";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cb_COD);
            this.groupBox5.Controls.Add(this.tb_CustAdd);
            this.groupBox5.Controls.Add(this.lb_CustAdd);
            this.groupBox5.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(86, 289);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(526, 139);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Delivery";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // cb_COD
            // 
            this.cb_COD.AutoSize = true;
            this.cb_COD.Location = new System.Drawing.Point(144, 88);
            this.cb_COD.Name = "cb_COD";
            this.cb_COD.Size = new System.Drawing.Size(212, 27);
            this.cb_COD.TabIndex = 22;
            this.cb_COD.Text = "Cash On Delivery";
            this.cb_COD.UseVisualStyleBackColor = true;
            // 
            // cb_Parcel
            // 
            this.cb_Parcel.AutoSize = true;
            this.cb_Parcel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cb_Parcel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Parcel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cb_Parcel.Location = new System.Drawing.Point(191, 126);
            this.cb_Parcel.Name = "cb_Parcel";
            this.cb_Parcel.Size = new System.Drawing.Size(92, 29);
            this.cb_Parcel.TabIndex = 20;
            this.cb_Parcel.Text = "Parcel";
            this.cb_Parcel.UseVisualStyleBackColor = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lb_OID);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.listView1);
            this.groupBox6.Controls.Add(this.cb_Parcel);
            this.groupBox6.Controls.Add(this.lb_totalCost);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(722, 37);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(488, 713);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Order Details";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(404, 805);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 46);
            this.button3.TabIndex = 22;
            this.button3.Text = "Done";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(722, 805);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(265, 46);
            this.button4.TabIndex = 23;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Order ID : ";
            // 
            // lb_OID
            // 
            this.lb_OID.AutoSize = true;
            this.lb_OID.Location = new System.Drawing.Point(239, 59);
            this.lb_OID.Name = "lb_OID";
            this.lb_OID.Size = new System.Drawing.Size(70, 22);
            this.lb_OID.TabIndex = 24;
            this.lb_OID.Text = "label6";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Google Pay",
            "Paytm",
            "PayPal",
            "Bhim",
            "PhonePe",
            "AmazonPay",
            "Mobikwik",
            "Yono SBI"});
            this.comboBox1.Location = new System.Drawing.Point(151, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 31);
            this.comboBox1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 805);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 32);
            this.label6.TabIndex = 24;
            this.label6.Text = "Github ID : hetsuthar028";
            // 
            // Payment_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1306, 876);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Payment_Details";
            this.Text = "Payment_Details";
            this.Load += new System.EventHandler(this.Payment_Details_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_CustFName;
        private System.Windows.Forms.Label lb_CustLName;
        private System.Windows.Forms.TextBox tb_CustFName;
        private System.Windows.Forms.TextBox tb_CustLName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_CustPNO;
        private System.Windows.Forms.Label lb_CustAdd;
        private System.Windows.Forms.TextBox tb_CustAdd;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Items;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_totalCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cb_MOP_Cash;
        private System.Windows.Forms.CheckBox cb_MOP_Online;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cb_COD;
        private System.Windows.Forms.CheckBox cb_Parcel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_OID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
    }
}