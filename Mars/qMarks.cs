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
    public partial class qMarks : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mars - Copy\Mars\Database1.mdf;Integrated Security=True");
        public qMarks()
        {
            InitializeComponent();
        }

        private void qMarks_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            string sql = "select info.name, Marks.course, Marks.quiz1, Marks.quiz2, Marks.quiz3, Marks.attend, Marks.story, Marks.part, Marks.song, Marks.final, Marks.grade, Marks.result from info inner join Marks on info.id = Marks.id where Marks.id='" + textBox3.Text + "' And Marks.course='" + comboBox2.SelectedItem.ToString()  + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
