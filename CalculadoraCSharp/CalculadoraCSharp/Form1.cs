using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCSharp
{
    public partial class CalculadoraCSharp : Form
    {
        // DECLARANDO AS VARIÁVEIS
        double valorUm;
        double valor02;

        public CalculadoraCSharp()
        {
            InitializeComponent();
        }

        private void operacaoClick(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }

        private void CalculadoraCSharp_Load(object sender, EventArgs e)
        {
            // RECEBENDO VALORES DIGITADOS
            valorUm = Double.Parse(txtUm.Text);
            valor02 = Double.Parse(txtDois.Text);

            // VERIFICANDO A OPERAÇÃO QUE O USUÁRIO ESTÁ EXECULTANDO
            string tipo_operacao = (sender as Button).Text;

            // MOSTRANDO A OPERAÇÃO EXECULTADO NUMA CAIXA DE MENSAGEM
            MessageBox.Show(tipo_operacao);
        }
    }
}
