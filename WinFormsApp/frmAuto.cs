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
    public partial class frmAuto : Form
    {
        public frmAuto()
        {
            InitializeComponent();
        }
        public frmAuto(string name)
        {
            Text = "Hello "+name;
            InitializeComponent();
        }

        private void frmAuto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAuto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void addText_btn_Click(object sender, EventArgs e)
        {
            int num = (int)numText.Value;
            for(int i = 0; i < num; i++)
            {
                Label lb = new Label();
                lb.Text = $"Enter text {i+1}";
                lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                lb.Location = new System.Drawing.Point(188, 74 + (i*50));
                lb.Size = new System.Drawing.Size(76, 19);

                TextBox t = new TextBox();
                t.Location = new System.Drawing.Point(274, 70 + (i*50));
                t.Size = new System.Drawing.Size(269, 23);

                this.Controls.Add(lb);
                this.Controls.Add(t);
            }
        }
    }
}
