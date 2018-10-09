using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Surface_Area_and_Volume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double R = Convert.ToDouble(txtBxRadius.Text);

            double T = 4 * Math.PI * R * R;

            lblAnswer.Text = "Surface Area = " + T.ToString("0.00");

            double V = Convert.ToDouble(textBoxRadiusV.Text);

            double VT = 4/3 * Math.PI * R * R * R;

            lblAnswer.Text = "Surface Area = " + VT.ToString("0.00");

        }
    }
}
