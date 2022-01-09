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
    public partial class preview : Form
    {
        public preview()
        {
            InitializeComponent();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void preview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet5.Marks' table. You can move, or remove it, as needed.
            this.MarksTableAdapter.Fill(this.Database1DataSet5.Marks);

            //this.reportViewer1.RefreshReport();
        }
    }
}
