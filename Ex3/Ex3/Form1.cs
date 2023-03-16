using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int anos;
        int meses;
        int dias;
        int total;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            anos = int.Parse(txtAno.Text);
            meses = int.Parse(txtMeses.Text);
            dias = int.Parse(txtDias.Text);

            total = (anos * 365) + (meses * 30) + dias;

            lblResultado.Text = $"{total.ToString()} Dias";
        }
    }
}
