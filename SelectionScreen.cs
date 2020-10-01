using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18001996_Task1
{
    public partial class SelelectionScreen : Form
    {
        public SelelectionScreen()
        {
            InitializeComponent();
        }

        private void lblReplacingBooks_Click(object sender, EventArgs e)
        {
            Instructions ins = new Instructions();
            this.Hide();
            ins.Show();
            /*ReplacingBooks f1 = new ReplacingBooks();
            f1.Show();
            this.Hide();*/
        }
    }
}
