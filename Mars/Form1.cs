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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //if(e.KeyValue == Keys.Enter)
                //{

                //}
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Login where username='" + textBox2.Text + "'and password='" + textBox1.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Main ma = new Main();
                    ma.Show();
                }
                else
                {
                    MessageBox.Show("Please re-enter your username and your password");
                }
            }

            catch { MessageBox.Show("A mistake occured"); }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            students st = new students();
            st.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main ma = new Main();
            ma.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Login where username='" + textBox2.Text + "'and password='" + textBox1.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Main ma = new Main();
                    ma.Show();
                }
                else
                {
                    MessageBox.Show("Please re-enter your username and your password");
                }
            }

            catch { MessageBox.Show("A mistake occured"); }
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Main ma = new Main();
            ma.Show();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            //if(textBox2.Text == "USERNAME")
            //{
            //    textBox2.Text = "";
            //    textBox2.ForeColor = Color.Black;
            //}
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            //if (textBox2.Text == "")
            //{
            //    textBox2.Text = "USERNAME";
            //    textBox2.ForeColor = Color.Silver;
            //}
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //if (textBox1.Text == "")
            //{
            //    textBox1.Text = "PASSWORD";
            //    textBox1.ForeColor = Color.Silver;
            //}
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            //if (textBox1.Text == "PASSWORD")
            //{
            //    textBox1.Text = "";
            //    textBox1.ForeColor = Color.Black;
            //}
        }
    }
}
