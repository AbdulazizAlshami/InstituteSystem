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
    public partial class Spayments : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");
        public Spayments()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try{
                con.Open();
                SqlCommand cm = new SqlCommand("insert into paying values ('" + textBox2.Text + "','" + textBox7.Text + "','" + textBox9.Text + "','" + textBox8.Text + "','" + textBox1.Text + "', '"+comboBox1.SelectedItem.ToString()+"')", con);
                cm.ExecuteNonQuery();

                MessageBox.Show("New Student added succesfully");
                con.Close();
            }

            catch { MessageBox.Show("an error occured"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd2 = new SqlCommand("select id,payment1,page,payment2,page2,course from paying", con); 
                cmd2.CommandType = CommandType.Text;
                SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                sda2.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch { MessageBox.Show("an error occured"); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ssForm sf = new ssForm();
                sf.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sf.comboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                sf.textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                sf.textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                sf.textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                sf.textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();


                sf.ShowDialog();
            }
            catch { MessageBox.Show("An error occured"); }
        }

        private void Spayments_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            // TODO: This line of code loads data into the 'database1DataSet8.paying' table. You can move, or remove it, as needed.
            this.payingTableAdapter2.Fill(this.database1DataSet8.paying);
            // TODO: This line of code loads data into the 'database1DataSet7.paying' table. You can move, or remove it, as needed.
            //this.payingTableAdapter1.Fill(this.database1DataSet7.paying);
            // TODO: This line of code loads data into the 'database1DataSet6.paying' table. You can move, or remove it, as needed.
            //this.payingTableAdapter.Fill(this.database1DataSet6.paying);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = "0";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    label4.Text = Convert.ToString(double.Parse(label4.Text) + double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
                }



            }
            catch {                // con.Open();
                //try{
                //string q = "insert into accounting(month,students) values('"+textBox3.Text+"','"+label4.Text+"')";
                //SqlCommand cmd = new SqlCommand(q,con);
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("Ok");
                //con.Close();
                //    }
                //catch { 
                    MessageBox.Show("OK"); //}
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                label6.Text = "0";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    label6.Text = Convert.ToString(double.Parse(label6.Text) + double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()));
                }
                //MessageBox.Show("Done");
            }
            //catch {
                //try
                //{
                //    con.Open();
                //    string q = "insert into accounting(month,studnts2) values('" + textBox3.Text + "','" + label6.Text + "')";
                //    SqlCommand cmd = new SqlCommand(q, con);
                //    cmd.ExecuteNonQuery();
                //    MessageBox.Show("Ok");
                //    con.Close();
                //}
                catch { MessageBox.Show("OK"); }//}
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "delete from paying where id='" + textBox2.Text + "' And course='" + comboBox1.SelectedItem.ToString() + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted");
                con.Close();
            }
            catch { MessageBox.Show("An error occred"); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label10.Text = Convert.ToString(0);
            label10.Text += Convert.ToInt64(double.Parse(label4.Text) + double.Parse(label6.Text));
            //MessageBox.Show(label10.ToString());
            try
            {
                con.Open();
                string q = "insert into accounting (month,students) values('" + textBox3.Text + "','" + label10.Text + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch { MessageBox.Show("An Error occured"); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
