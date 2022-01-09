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
    public partial class EditTeacher : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");
        public EditTeacher()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"update Tinfo set Id='" + textBox1.Text + "', Name='" + textBox2.Text + "', Date='" + date.Text + "', phone='" + textBox3.Text + "' , address='" + textBox5.Text + "' where (Id = '" + textBox1.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Teacher succesfully");
                //show();
                con.Close();
            }
            catch { MessageBox.Show("an error occured ^_^"); }
        }
    }
}
