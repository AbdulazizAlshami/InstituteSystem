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

namespace Mars
{
    public partial class sForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");
        public sForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"update Tpayment set level='" + comboBox1.SelectedItem.ToString() + "',Date='"+date.Text+"', take1='" + textBox3.Text + "', take2='" + textBox4.Text + "', take3='" + textBox5.Text + "', take4='" + textBox2.Text + "' where (Id = '" + textBox1.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Student succesfully");
                //show();
                con.Close();
            }
            catch { MessageBox.Show("an error occured ^_^"); }
        }

        private void show()
        {

            Teachers st = new Teachers();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Tpayment ", con);
            //cmd.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            st.dataGridView1.DataSource = dt;
        }
    }
}
