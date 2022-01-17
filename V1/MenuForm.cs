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
    public partial class MenuForm : Form
    {
        public static MenuForm mf = new MenuForm();
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartDataForm dsf = new StartDataForm();
            dsf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TheoryForm tf = new TheoryForm();
            tf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoForm iff = new InfoForm();
            iff.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResultsForm rf = new ResultsForm();
            rf.Show();
            this.Hide();
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //label1.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
