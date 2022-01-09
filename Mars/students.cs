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
using System.Configuration;

namespace Mars
{
    public partial class students : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");
        public students()
        {
            InitializeComponent();

            textBox5.MaxLength = 9;    
        }

        private void students_Load(object sender, EventArgs e)
        {
            //gettingserial();
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            // TODO: This line of code loads data into the 'database1DataSet9.info' table. You can move, or remove it, as needed.
            this.infoTableAdapter.Fill(this.database1DataSet9.info);
            //DialogResult dia = MessageBox.Show("Do you really want to exit ?!", "Exit", MessageBoxButtons.YesNo);
            //if (dia == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            //else if (dia == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("Spaces are not allowed !!");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            label11.Text = textBox5.Text.Length.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into info values ('" + textBox3.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + date.Text + "', '" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox3.Text + "')", con);
                SqlCommand cmd2 = new SqlCommand("insert into course values ('" + textBox3.Text + "','" + comboBox1.SelectedItem.ToString() + "')", con);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                
                MessageBox.Show("New Student added succesfully");
                con.Close();
            }

            catch { MessageBox.Show("an error occured"); }
        }
        public void gettingserial()
        {
            //string autoid;
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select serial from info", con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    int id = int.Parse(dr[0].ToString() + 50);
            //    autoid = id.ToString("00000");
            //}
            //else
            //{
            //    autoid = ("00066");
            //}
            //con.Close();
            //textBox1.Text = autoid.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
       {
        //    string q = "select * from Table,info,course";
        //    SqlCommand cmd = new SqlCommand(q,con);
        //    con.Open();
        //    cmd.ExecuteNonQuery();
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //    con.Close();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value=(e.RowIndex + 1).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();//
                string sql = "select info.id,  info.name, course.cou, info.date, info.phone, info.address from info inner join course on info.id = course.std_id ";
                //sql += " inner join course on info.id = course.std_id ";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch { MessageBox.Show("An error occured"); }

                //SqlCommand cmd2 = new SqlCommand("select id,name,date,phone,address from info", con);
                //cmd2.CommandType = CommandType.Text;
                //SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                //DataTable dt = new DataTable();
                //sda2.Fill(dt);
                //dataGridView1.DataSource = dt;
 
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"delete from course where std_id ='" + textBox3.Text + "'", con);
                SqlCommand cmd3 = new SqlCommand(@"delete from paying where id ='" + textBox3.Text + "'", con);
                SqlCommand cmd2 = new SqlCommand(@"delete from info where id ='" + textBox3.Text + "'", con);
                cmd.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Deleted ");
                con.Close();
            }
            catch { MessageBox.Show("An error occured"); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            studentsEdit sf = new studentsEdit();
            sf.textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            sf.textBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            sf.comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            sf.date.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            sf.textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            sf.textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //sf.textBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            sf.ShowDialog();
        }
    }
}


