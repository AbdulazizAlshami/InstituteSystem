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
    public partial class squery : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");
        public squery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();//
                string sql = "select info.name, paying.course, info.phone, info.address, info.date, paying.payment1,paying.page , paying.payment2, paying.page2 from info inner join paying on info.id = paying.id where info.id='" + textBox3.Text + "'";
                //sql += " inner join course on info.id = course.std_id ";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch { MessageBox.Show("An error occured"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();//
                string sql = "select info.name, paying.course, info.phone, info.address, info.date, paying.payment1,paying.page , paying.payment2, paying.page2 from info inner join paying on info.id = paying.id";
                //sql += " inner join course on info.id = course.std_id ";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);

                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch { MessageBox.Show("An error occured"); }
        }

        private void squery_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}
