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
    public partial class supplyEdit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");
        public supplyEdit()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"update supply set month='" + textBox8.Text + "', rent='" + textBox7.Text + "', elect='" + textBox9.Text + "', water='" + textBox1.Text + "' , another_1='" + textBox2.Text + "', another_2='" + textBox3.Text + "', another_3='" + textBox4.Text + "', another_4='" + textBox5.Text + "', another_5='" + textBox6.Text + "' where (month = '" + textBox8.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated succesfully");
                //show();
                con.Close();
            }
            catch { MessageBox.Show("an error occured ^_^"); }
        }
    }
}
