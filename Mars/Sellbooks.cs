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
    public partial class Sellbooks : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");
        public Sellbooks()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cm = new SqlCommand("update books set Quantity = Quantity - '" + Convert.ToInt32(textBox4.Text) + "' where (Name = '" + comboBox1.SelectedItem.ToString() + "')", con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Done ");
                con.Close();
            }
            catch { MessageBox.Show("Done !");}
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cm = new SqlCommand("update activity set Quantity = Quantity - '" + Convert.ToInt32(textBox1.Text) + "' where (Name = '" + comboBox2.SelectedItem.ToString() + "')", con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Done ");
                con.Close();
            }
            catch { MessageBox.Show("Done !"); }
        }

        private void Sellbooks_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cm = new SqlCommand("update story set Quantity = Quantity - '" + Convert.ToInt32(textBox5.Text) + "' where (Name = '" + comboBox3.SelectedItem.ToString() + "')", con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Done ");
                con.Close();
            }
            catch { MessageBox.Show("Done !"); }
        }
    }
}
