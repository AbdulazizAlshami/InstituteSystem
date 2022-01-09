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
    public partial class supply : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");
        public supply()
        {
            InitializeComponent();
        }

        private void supply_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet13.supply' table. You can move, or remove it, as needed.
            this.supplyTableAdapter.Fill(this.database1DataSet13.supply);
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //for(int i=0; i<Data)
            //{

            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into supply values ('" + textBox8.Text + "','" + textBox7.Text + "','" + textBox9.Text + "','" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("added succesfully");
                con.Close();
            }

            catch { MessageBox.Show("an error occured"); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            supplyEdit sf = new supplyEdit();
            sf.textBox8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            sf.textBox7.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            sf.textBox9.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            sf.textBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            sf.textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            sf.textBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            sf.textBox4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            sf.textBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            sf.textBox6.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            sf.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd2 = new SqlCommand("select month,rent, elect, water, another_1,another_2,another_3,another_4,another_5 from supply", con);
                cmd2.CommandType = CommandType.Text;
                SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                sda2.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Updated");
                con.Close();
            }
            catch { MessageBox.Show("an error occured"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //if(accoun){
                label11.Text = "0";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    label11.Text = Convert.ToString(double.Parse(label11.Text) + double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
                }
                //MessageBox.Show("Done");
            }
            catch
            {
                try
                {
                    label12.Text = "0";
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        label12.Text = Convert.ToString(double.Parse(label12.Text) + double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
                    }
                    //MessageBox.Show("Done");
                }
                catch
                {
                    try
                    {
                        label13.Text = "0";
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            label13.Text = Convert.ToString(double.Parse(label13.Text) + double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()));
                        }
                        //MessageBox.Show("Done");
                    }

                    catch
                    {
                        try
                        {
                            label14.Text = "0";
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                label14.Text = Convert.ToString(double.Parse(label14.Text) + double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()));
                            }
                            //MessageBox.Show("Done");
                        }
                        catch
                        {
                            try
                            {
                                label15.Text = "0";
                                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                {
                                    label15.Text = Convert.ToString(double.Parse(label15.Text) + double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()));
                                }
                                //MessageBox.Show("Done");
                            }
                            catch
                            {
                                try
                                {
                                    label16.Text = "0";
                                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                    {
                                        label16.Text = Convert.ToString(double.Parse(label16.Text) + double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()));
                                    }
                                    //MessageBox.Show("Done");
                                }
                                catch
                                {
                                    try
                                    {
                                        label17.Text = "0";
                                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                        {
                                            label17.Text = Convert.ToString(double.Parse(label17.Text) + double.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString()));
                                        }
                                        //MessageBox.Show("Done");
                                    }
                                    catch
                                    {
                                        try
                                        {
                                            label18.Text = "0";
                                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                            {
                                                label18.Text = Convert.ToString(double.Parse(label18.Text) + double.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString()));
                                            }
                                            //MessageBox.Show("Done");
                                        }
                                        catch { }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                label10.Text = Convert.ToString(0);
                label10.Text += Convert.ToInt64(double.Parse(label11.Text) + double.Parse(label12.Text) + double.Parse(label13.Text) + double.Parse(label14.Text) + double.Parse(label15.Text) + double.Parse(label16.Text) + double.Parse(label17.Text) + double.Parse(label18.Text));
                //MessageBox.Show(label9.ToString());
                con.Open();
                string q = "insert into accounting (month,supply) values('" + textBox8.Text + "','" + label10.Text + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch { MessageBox.Show("An error occured"); }
        }
    }
}
