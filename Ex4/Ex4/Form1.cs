using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double entradaValor;
        int diasAtraso;
        double valorFinal;
        double multa;

        private void btnCal_Click(object sender, EventArgs e)
        {
            entradaValor = Convert.ToDouble(txtEntrada.Text);
            diasAtraso = Convert.ToInt32(txtAtraso.Text);

            multa = diasAtraso * (0.05 / 100);

            valorFinal = entradaValor + (8.49) + multa;

            lblValorFinal.Text = $"Valor Final: {valorFinal}";
        }
    }
}
