using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PtAssignment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Form1.photo;
            label8.Text = Form1.formdata[0];
            label9.Text= Form1.formdata[1];
            label10.Text = Form1.formdata[2];
            label11.Text = Form1.formdata[3];
            label12.Text = Form1.formdata[4];
            label13.Text = Form1.formdata[5];
            label14.Text = Form1.formdata[6];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
