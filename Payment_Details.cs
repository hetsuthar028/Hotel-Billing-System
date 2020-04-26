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
    public partial class Payment_Details : Form
    {
        string f="";
        string amt = "";
        string items = "";
        string quantity = "";
        string OID = "";
        public Payment_Details(string s,string tCost)
        {
            f = s;
            amt = tCost;
            InitializeComponent();
        }

        private void Payment_Details_Load(object sender, EventArgs e)
        {
            
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Het Suthar\source\repos\Practical_9\Orders.mdf';Integrated Security=True");
            sc.Open();
            string query = "select OrderID from OID";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                OID = dr.GetValue(0).ToString();
            }
            lb_OID.Text = OID;
            string k = "";
            int m = 0;
            int cnt = 0;
            for (int i = 0; i < f.Length;i++)
            {
                if(f[i]=='#')
                {
                    cnt++;
                }
            }
            char[] seperator = {'-','#'};
            String[] strlist = f.Split(seperator);
           
            int h = 0;
            for(int i=0;i<cnt;i++)
            {
                for(int j=0;j<3;j++)
                {
                    
                    if(j==0)
                    {
                        items += strlist[h]+",";
                        listView1.Items.Add(strlist[h].ToString());
                    }
                    else
                    {
                        if(j==2)
                        {
                            quantity += strlist[h].ToString() + ",";
                        }
                        listView1.Items[i].SubItems.Add(strlist[h]);
                    }
                    h++;
                }
            }
            lb_totalCost.Text = amt;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Payment_Details.ActiveForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Het Suthar\source\repos\Practical_9\Orders.mdf';Integrated Security=True");
            sc.Open();
            DateTime dt = DateTime.Now;
            string MOP = "";
            string COD="No";
            string parcel = "No";
            if(cb_MOP_Cash.Checked)
            {
                MOP = "Cash";
            }
            else if(cb_MOP_Online.Checked)
            {
                MOP = "Online";
            }
            if(cb_COD.Checked)
            {
                COD = "Yes";
            }
            if(cb_Parcel.Checked)
            {
                parcel = "Yes";
            }
            string query = "insert into order_data values('"+ OID + "','"+dt+"','"+tb_CustFName.Text+"','"+tb_CustLName.Text+"','"+tb_CustPNO.Text+"','"+tb_CustAdd.Text+"','"+MOP+"','"+comboBox1.SelectedItem.ToString()+"','"+parcel+"','"+items+"','"+quantity+"','"+lb_totalCost.Text+"','Done')";
            SqlCommand cmd = new SqlCommand(query, sc);
            cmd.ExecuteNonQuery();
            int OID_Up = Convert.ToInt32(OID) + 1;
            query = "update OID set OrderID='"+OID_Up+"'";
            SqlCommand cmd1 = new SqlCommand(query, sc);
            cmd1.ExecuteNonQuery();

            sc.Close();
            MessageBox.Show("Data Inserted");
            Payment_Details.ActiveForm.Close();


        }
    }
}
