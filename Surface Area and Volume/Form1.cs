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
            try
            {

                double R = Convert.ToDouble(txtBxRadius.Text);

                double T = 4 * Math.PI * R * R;

                lblAnswer.Text = "Surface Area = " + T.ToString("0.00");

                double V = Convert.ToDouble(txtBxRadius.Text);

                double VT = 4 / 3 * Math.PI * R * R * R;

                lblanswer2.Text = "Volume = " + VT.ToString("0.00");
            }
            catch
            {

            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                double R2 = Convert.ToDouble(textBox3.Text);
                double H = Convert.ToDouble(textBox4.Text);

                double C = Math.PI * R2 * (R2 + Math.Sqrt(H * H + R2 * R2));
                double C2 = Math.PI * (R2 * R2) * (H / 3);

                label15.Text = "Surface Area = " + C.ToString("0.00");
                label19.Text = "Volume = " + C2.ToString("0.00");
          
            }
            catch
            {

            }
        }
    }
}
