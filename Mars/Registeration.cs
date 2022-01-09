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
    public partial class Registeration : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");
        public Registeration()
        {
            InitializeComponent();

            textBox3.MaxLength = 9;
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            //button1.Text = ofd.FileName;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //pdf.src = ofd.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Tinfo values('"+textBox1.Text+"','"+textBox2.Text+"', '"+date.Text+"', '"+textBox3.Text+"','"+textBox5.Text+"')", con);
                cmd.ExecuteNonQuery();
                //saveFile.(button1.Text);
                MessageBox.Show("New Teacher Inserted");
                con.Close();
            }
            catch { MessageBox.Show("An Error Occured"); }
        }
        private void saveFile(string filepath)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = "";
                }
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"delete from Tpayment where Id ='" + textBox1.Text + "'", con);
                SqlCommand cmd2 = new SqlCommand(@"delete from Tinfo where Id ='" + textBox1.Text + "'", con);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Deleted ");
                con.Close();
            }
            catch { MessageBox.Show("An error occured"); }
        }

        private void Registeration_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            // TODO: This line of code loads data into the 'database1DataSet12.Tinfo' table. You can move, or remove it, as needed.
            this.tinfoTableAdapter.Fill(this.database1DataSet12.Tinfo);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd2 = new SqlCommand("select Id,Name,Date,phone,address from Tinfo", con);
                cmd2.CommandType = CommandType.Text;
                SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                sda2.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();
            }
            catch { MessageBox.Show("an error occured"); }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EditTeacher sf = new EditTeacher();
            sf.textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            sf.textBox2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            sf.date.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            sf.textBox3.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            sf.textBox5.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            //sf.textBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            sf.ShowDialog();
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            label11.Text = textBox3.Text.Length.ToString();
        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("Spaces are not allowed !!");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

