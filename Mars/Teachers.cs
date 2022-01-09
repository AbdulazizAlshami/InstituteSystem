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
    public partial class Teachers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");

        public Teachers()
        {
            InitializeComponent();
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            // TODO: This line of code loads data into the 'database1DataSet2.Tpayment' table. You can move, or remove it, as needed.
            this.tpaymentTableAdapter.Fill(this.database1DataSet2.Tpayment);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Tpayment values('"+textBox1.Text+"','"+comboBox1.SelectedItem.ToString()+"','"+date.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox2.Text+"')",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The money have been taken successfully ");
                con.Close();
            //}
            //catch { MessageBox.Show("An Error Occured"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "delete from Tpayment where Id='" + textBox1.Text + "' And level='" + comboBox1.SelectedItem.ToString() + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted");
                con.Close();
            }
            catch { MessageBox.Show("An error occred"); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sForm sf = new sForm();
            sf.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            sf.comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            date.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            sf.textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            sf.textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            sf.textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            sf.textBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //sf.textBox2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            sf.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //try
            //{
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Tpayment", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            //}
            //catch { MessageBox.Show("an error occured"); }
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //string q = "select SUM (take)";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                label10.Text = "0";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    label10.Text = Convert.ToString(double.Parse(label10.Text) + double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()));
                }
                //MessageBox.Show("Done");
            }
            catch { MessageBox.Show("Done"); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                label8.Text = "0";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    label8.Text = Convert.ToString(double.Parse(label8.Text) + double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()));
                }
                //MessageBox.Show("Done");
            }
            catch { MessageBox.Show("Done"); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                label12.Text = "0";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    label12.Text = Convert.ToString(double.Parse(label12.Text) + double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()));
                }
                //MessageBox.Show("Done");
            }
            catch { MessageBox.Show("Done"); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                label13.Text = "0";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    label13.Text = Convert.ToString(double.Parse(label13.Text) + double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()));
                }
                //MessageBox.Show("Done");
            }
            catch { MessageBox.Show("Done"); }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {

                //label14.Text = "0";
                //for (int i = 0; i < dataGridView1.Rows.Count; i++)
                //{
                //    label14.Text = Convert.ToString(double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) + double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()) + double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()) + double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()));
                //}
            }
            catch { MessageBox.Show("Done !");}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                label9.Text = Convert.ToString(0);
                label9.Text += Convert.ToInt64(double.Parse(label10.Text) + double.Parse(label12.Text) + double.Parse(label13.Text) + double.Parse(label8.Text));
                //MessageBox.Show(label9.ToString());
                con.Open();
                string q = "insert into accounting (month,teachers) values('" + textBox6.Text + "','" + label9.Text + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch { MessageBox.Show("An error occured");}
        }
    }
}
