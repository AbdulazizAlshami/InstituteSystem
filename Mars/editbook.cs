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
    public partial class editbook : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");
        public editbook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"update books set Name='" + comboBox1.SelectedItem.ToString()+ "', Quantity='" + textBox4.Text + "', Price='" + textBox8.Text + "', Record='" + textBox7.Text + "' where (Name = '" + comboBox1.SelectedItem.ToString() + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated succesfully");
                //show();
                con.Close();
            }
            catch { MessageBox.Show("an error occured ^_^"); }
        }

        private void editbook_Load(object sender, EventArgs e)
        {

        }
    }
}
