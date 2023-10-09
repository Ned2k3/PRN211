using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int count = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {
                timer1.Stop();
                string name = txtName.Text;
                frmAuto f = new frmAuto(name);
                f.Show();
                this.Hide();
            }
            this.time_label.Text = count.ToString();
        }
    }
}
