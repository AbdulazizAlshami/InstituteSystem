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
    public partial class actedit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");
        public actedit()
        {
            InitializeComponent();
        }

        private void actedit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"update activity set Name='" + comboBox1.SelectedItem.ToString() + "', Quantity='" + textBox4.Text + "', Price='" + textBox8.Text + "', Record='" + textBox7.Text + "' where (Name = '" + comboBox1.SelectedItem.ToString() + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated succesfully");
                //show();
                con.Close();
            }
            catch { MessageBox.Show("an error occured ^_^"); }
        }
    }
}
