using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mars
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormBorderStyle.Maximized;
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //students st = new students();
            //st.Show();
        }

        private void registerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            students st = new students();
            st.Show();
        }

        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registerationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Teachers tc = new Teachers();
            tc.Show();
        }

        private void resgisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registeration rg = new Registeration();
            rg.Show();
        }

        private void queryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            qteacher qt = new qteacher();
            qt.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spayments sp = new Spayments();
            sp.Show();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books bk = new Books();
            bk.Show();
        }

        private void queryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Query q = new Query();
            q.Show();
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sellbooks sl = new Sellbooks();
            //sl.Show();
        }

        private void marksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            preview pv = new preview();
            pv.Show();
        }

        private void marksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Marks mk = new Marks();
            mk.Show();
        }

        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            squery sq = new squery();
            sq.Show();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void financeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void queryToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            qMarks am =new qMarks();
            am.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cpass cp = new cpass();
            cp.Show();
        }

        private void supplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supply sp = new supply();
            sp.Show();
        }

        private void finalSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Finalfrom ff = new Finalfrom();
            ff.Show();
        }
    }
}
