using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4Pag15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt1.Text);
            double num2 = double.Parse(txt2.Text);
            double num3 = double.Parse(txt3.Text);

            double[] ordem = new double[3] {num1, num2, num3};

            Array.Sort(ordem);

            foreach(double i in ordem)
            {
                lblOrdem.Text += " " + i;
            }

            Array.Reverse(ordem);

            foreach (double i in ordem)
            {
                lblOrdemReverse.Text += " " + i;
            }

        }
    }
}
