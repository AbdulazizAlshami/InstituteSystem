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
    public partial class qteacher : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");
        public qteacher()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                string sql = "select Tinfo.Id, Tinfo.Name, Tpayment.level, Tpayment.Date, Tpayment.take1, Tpayment.take2, Tpayment.take3, Tpayment.take4 from Tinfo inner join Tpayment on Tinfo.id = Tpayment.id where Tinfo.id='" + textBox1.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch { MessageBox.Show("An error accured"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select Tinfo.Id, Tinfo.Name, Tpayment.level, Tpayment.Date, Tpayment.take1, Tpayment.take2, Tpayment.take3, Tpayment.take4 from Tinfo inner join Tpayment on Tinfo.id = Tpayment.id ";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch { MessageBox.Show("An error accured"); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void qteacher_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}
