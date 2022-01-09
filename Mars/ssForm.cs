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
    public partial class ssForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");
        public ssForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"update paying set course='"+comboBox1.SelectedItem.ToString()+"' ,page='" + textBox3.Text + "', payment1='" + textBox4.Text + "', payment2='" + textBox5.Text + "', page2='" + textBox2.Text + "' where (id = '" + textBox1.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Student succesfully");
                //show();
                con.Close();
            }
           catch { MessageBox.Show("an error occured ^_^"); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
