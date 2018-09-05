using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcCSharp
{
    public partial class Form1 : Form
    {
        double valor01;
        double valor02;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // MODIFICA O TEXTO DIGITADO A LBLRESULTADO
            lblResultado.Text = "";
        }

        private void operacaoClick(object sender, EventArgs e)
        {
            // DECLARANDO VARIÁVEIS E ATRIBUINDO VALORES DIGITADOS A ELAS
            valor01 = Double.Parse(txtUm.Text);
            valor02 = Double.Parse(txtDois.Text);

            //  VERIFICA A OPERAÇÃO EXECULTADA PELO USUÁRIO
            string tipo_operacao = (sender as Button).Text;

            // MOSTRA A OPERAÇÃO EXECULTADA PELO USUÁRIA ATRAVÉS DE UMA CAIXA DE MENSAGEM //
            // MessageBox.Show(tipo_operacao); //
            
            // MOSTRANDO O RESULTADO NA LBLRESULTADO
            lblResultado.Text = String.Format("{0} {1} {2} = {3}", valor01.ToString(), tipo_operacao, valor02.ToString(), operacao(tipo_operacao));

        }

        private string operacao(string tipo)
        {
            double resultado = 0;
            
            switch (tipo)
            {
                case "+":
                    resultado = valor01 + valor02;
                    break;
                case "-":
                    resultado = valor01 - valor02;
                    break;
                case "x":
                    resultado = valor01 * valor02;
                    break;
                case ":":
                    resultado = valor01 / valor02;
                    break;
            }

            return resultado.ToString();
        }




    }
    }
