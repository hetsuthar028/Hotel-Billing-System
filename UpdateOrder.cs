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
    public partial class UpdateOrder : Form
    {
        public UpdateOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Het Suthar\source\repos\Practical_9\Orders.mdf';Integrated Security=True");
            sc.Open();
            string query = "update Order_data set OrderStatus = 'Done' where OrderID = '"+textBox1.Text+"'";
            SqlCommand cmd = new SqlCommand(query, sc);
            cmd.ExecuteNonQuery();
            sc.Close();
        }
    }
}
