using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practical_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal total = 0;
        int a = 0;
        public decimal final_amt = 0;
        public int amt_each = 0;
        private void lv_1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            if(lv_2.Items.Count > 0)
            { 
            string s = "";
            for(int i=0;i<lv_2.Items.Count; i++)
            {
                s += lv_2.Items[i].SubItems[0].Text +"-"+ lv_2.Items[i].SubItems[1].Text +"-" + lv_2.Items[i].SubItems[2].Text +  "#" ;
            }
            string cost = lb_totalResult.Text;
            Payment_Details pd = new Payment_Details(s,cost);
            pd.Show();
            }
        }

        private void btn_cancelOrder_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(lv_2.SelectedItems[0].SubItems[1].Text);
            //MessageBox.Show(lv_2.SelectedItems[0].SubItems[1].Text.ToString());
            lv_2.SelectedItems[0].Remove();
            //a = Convert.ToInt32(nup_1.Value);
            
            total -= a;
            //MessageBox.Show(total.ToString());
            lb_totalResult.Text = total.ToString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(nup_1.Value!=0)
            { 
            string order = lv_1.SelectedItems[0].SubItems[0].Text;
            amt_each = int.Parse(lv_1.SelectedItems[0].SubItems[1].Text);
            decimal no = Convert.ToInt32(nup_1.Value);
            //MessageBox.Show(Convert.ToString(order + " " +  amt_each + " " + no));

            final_amt = no * Convert.ToInt32(amt_each);
            //MessageBox.Show(Convert.ToString( final_amt));
            total += final_amt;
            lv_2.Items.Add(order);
            int i = lv_2.Items.Count - 1;
            lv_2.Items[i].SubItems.Add(Convert.ToString(final_amt));
            lv_2.Items[i].SubItems.Add(Convert.ToString(nup_1.Value));
            lb_totalResult.Text = Convert.ToString(total);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            lv_2.Items.Clear();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Het Suthar\source\repos\Practical_9\Orders.mdf';Integrated Security=True");
            sc.Open();
            string query = "select OrderID, First_Name, Phone_Number, Items, Quantity, TotalCost from Order_data where OrderStatus='Waiting'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            lb_estTime.Text =  dt.Rows.Count.ToString() + " Minute ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateOrder upd = new UpdateOrder();
            upd.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
