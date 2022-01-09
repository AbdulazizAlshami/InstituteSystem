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
    public partial class Query : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");

        public Query()
        {
            InitializeComponent();
        }

        private void Query_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            // TODO: This line of code loads data into the 'database1DataSet11.story' table. You can move, or remove it, as needed.
            this.storyTableAdapter.Fill(this.database1DataSet11.story);
            // TODO: This line of code loads data into the 'database1DataSet10.activity' table. You can move, or remove it, as needed.
            this.activityTableAdapter.Fill(this.database1DataSet10.activity);
            // TODO: This line of code loads data into the 'database1DataSet4.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.database1DataSet4.books);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from books", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                }
                MessageBox.Show(sum.ToString());
                con.Close();
            }
            catch { MessageBox.Show("an error occured"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from activity", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;

                int sum = 0;
                for (int i = 0; i < dataGridView3.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);
                }
                MessageBox.Show(sum.ToString());
                con.Close();
            }
            catch { MessageBox.Show("an error occured"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from story", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView3.DataSource = dt;

                int sum = 0;
                for (int i = 0; i < dataGridView3.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dataGridView3.Rows[i].Cells[1].Value);
                }
                MessageBox.Show(sum.ToString());
                con.Close();
            }
            catch { MessageBox.Show("an error occured"); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            actedit sf = new actedit();
            sf.comboBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            sf.textBox4.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            sf.textBox8.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            sf.textBox7.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            //sf.textBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            sf.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            editbook sf = new editbook();
            sf.comboBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            sf.textBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            sf.textBox8.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            sf.textBox7.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //sf.textBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            sf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = "0";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    label4.Text = Convert.ToString(double.Parse(label4.Text) + double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
                }
            }
            catch { MessageBox.Show("Done"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                label6.Text = "0";
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    label6.Text = Convert.ToString(double.Parse(label6.Text) + double.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString()));
                }
            }
            catch { MessageBox.Show("Done"); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = "0";
                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {
                    label2.Text = Convert.ToString(double.Parse(label2.Text) + double.Parse(dataGridView3.Rows[i].Cells[2].Value.ToString()));
                }
            }
            catch { MessageBox.Show("Done"); }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            storyedit sf = new storyedit();
            sf.comboBox1.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            sf.textBox4.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            sf.textBox8.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            sf.textBox7.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            //sf.textBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            sf.ShowDialog();
        }
    }
}
