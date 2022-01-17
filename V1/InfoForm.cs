using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V1
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void InfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuForm.mf.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MenuForm.mf.Show();
            this.Hide();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            //label5.ForeColor = Color.Red;
            Cursor = Cursors.Hand;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            //label5.ForeColor = Color.Black;
            Cursor = Cursors.Arrow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm.mf.Show();
            this.Hide();
        }
    }
}
