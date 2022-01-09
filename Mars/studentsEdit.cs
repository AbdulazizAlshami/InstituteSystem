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
    public partial class studentsEdit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");
        public studentsEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"update info set id='" + textBox3.Text + "', name='" + textBox4.Text + "', date='" + date.Text + "', phone='" + textBox5.Text + "', address='" + textBox6.Text + "' where (id = '" + textBox3.Text + "')", con);
                SqlCommand cmd2 = new SqlCommand(@"update course set cou='" + comboBox1.SelectedItem.ToString() + "' where (std_id = '" + textBox3.Text + "')", con);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Updated Student succesfully");
                //show();
                con.Close();
            }
            catch {MessageBox.Show("An error occured"); }
        }
    }
}

