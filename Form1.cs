using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjeto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl_calcular Calculadora = new cl_calcular();
            int preco_inicial = Convert.ToInt32(caixa_texto.Text);
            int tipo_produto = 0;

            if (btn_mais5.Checked)
                tipo_produto = 1;
            
            MessageBox.Show("Preço final = " + Calculadora.CalcularPrecoFinal(preco_inicial, tipo_produto));
        }

        private void cmd_executar2_Click(object sender, EventArgs e)
        {
            cl_calcular Calculadora = new cl_calcular();
            int preco_inicial = Convert.ToInt32(caixa_texto.Text);
            int tipo_produto = 0;

            if (btn_menos5.Checked)
                tipo_produto = 2;

            MessageBox.Show("Preço final = " + Calculadora.CalcularPrecoFinal(preco_inicial, tipo_produto));
            
        }
    }
}
