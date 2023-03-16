using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int hora = 0;
        int minuto = 0;
        int segundo = 0;

        int calculo = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            hora = int.Parse(txtHour.Text);
            minuto = int.Parse(txtMin.Text);
            segundo = int.Parse(txtSec.Text);

            calculo = (hora * 3600) + (minuto * 60) + segundo;

            lblRes.Text = calculo.ToString() + "s";
        }
    }
}
