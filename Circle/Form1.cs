using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double radius, Circumference;

            try
            {
                radius = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show(textBox1.Text + "this is not a number!");
                radius = 0.0;
            }


            double area = 2.0 * Math.PI * radius;
            label1.Text = "Area =" + area;

            Circumference = Math.PI * (radius * radius);
            label2.Text = "Circumference =" + Circumference;

        }
    }
}
