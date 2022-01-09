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
    public partial class Finalfrom : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");

        public Finalfrom()
        {
            InitializeComponent();
        }

        private void Finalfrom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet15.accounting' table. You can move, or remove it, as needed.
            this.accountingTableAdapter.Fill(this.database1DataSet15.accounting);
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();//
                string sql = "select accounting.month, accounting.students, accounting.teachers, accounting.supply from accounting where accounting.month='" + textBox1.Text + "'";
                //sql += " inner join course on info.id = course.std_id ";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch { MessageBox.Show("An error occured"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();//
                string sql = "select accounting.month, accounting.students, accounting.teachers, accounting.supply from accounting";
                //sql += " inner join course on info.id = course.std_id ";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch { MessageBox.Show("An error occured"); }
        }
    }
}
