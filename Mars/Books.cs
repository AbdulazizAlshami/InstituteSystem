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

// Abdulaziz ALshami
// dev.abdulaziz.alshami@gmail.com

namespace Mars
{
    public partial class Books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");
        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cm = new SqlCommand("insert into books values ('" + comboBox1.SelectedItem.ToString() + "','" + textBox4.Text + "','" + textBox8.Text + "','" + textBox7.Text + "')", con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Added successfully");
                con.Close();
            }
            catch {MessageBox.Show("An error occured"); }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cm = new SqlCommand("insert into activity values ('" + comboBox2.SelectedItem.ToString() + "','" + textBox9.Text + "','" + textBox6.Text + "','" + textBox5.Text + "')", con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Added successfully");
                con.Close();
            }
            catch { MessageBox.Show("An error occured"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cm = new SqlCommand("insert into story values ('" + comboBox3.SelectedItem.ToString() + "','" + textBox11.Text + "','" + textBox2.Text + "','" + textBox1.Text + "')", con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Added successfully");
                con.Close();
            }
            catch { MessageBox.Show("An error occured"); }
        }
    }
}
