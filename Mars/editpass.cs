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
    public partial class editpass : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");
        public editpass()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"update Login set password='" + textBox4.Text + "', privilage='" + textBox5.Text + "' where (username='" + textBox3.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated password succesfully");
                con.Close();
            }
            catch { MessageBox.Show("An error occured"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {try{
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Login values ('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("saved");
            con.Close();
                        }
            catch { MessageBox.Show("An error occured"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try{
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Login where username='" + textBox3.Text + "' ", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted");
            con.Close();
            }
            catch { MessageBox.Show("An error occured"); }
        }
    }
}
