using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float preco;
        int quantidade;
        double totalDolar;
        double totalReal;

        private void btnConverter_Click(object sender, EventArgs e)
        {
            preco = float.Parse(txtValor.Text);
            quantidade = int.Parse(txtQuant.Text);

            totalDolar = (preco * quantidade);
            totalReal = totalDolar * 5.29;

            lblTotalPagoUS.Text = $"US$ {totalDolar.ToString()}";
            lblTotalPago.Text = $"R$ {totalReal.ToString()}";
        }

    }
}
