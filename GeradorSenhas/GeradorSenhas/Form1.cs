using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorSenhas
{
    public partial class Form1 : Form
    {
        // DECLARANDO VARIÁVEL RESPONSAVEL POR DEFINIR O MÁXIMO DE SENHAS GERADAS
        int numSenhas = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string chars = "abcdefghijklmnopqrstuvwxyz";
        
            // VERIFICANDO SE OS CHECKBOX ESTÃO MARCADOS
            // CHECKBOX MAIÚSCULAS
            if (chbMaiusculas.Checked)
                chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // CHECKBOX NÚMEROS
            if (chbNumeros.Checked)
                chars += "0123456789";

            // CHECKBOX SÍMBOLOS
            if (chbSimbolos.Checked)
                chars += "#/$!?=-\"";

            // APAGA O CONTEÚDO DA LISTA
            listaSenhas.Items.Clear();

            Random rnd = new Random();

            for (int n = 1; n <= numSenhas; n++)
            {
                StringBuilder str = new StringBuilder();
                for(int m = 1; m <= count_chars.Value; m++)
                {
                    // ESTAMOS CRIANDO UMA VARIÁVEL CHAMADA POS(POSIÇÃO)
                    // PARA VERIFICAR O TAMANHO DE CARACTERES QUE TEMOS ALI
                    // ELE VAI VERIFICAR NA VARIÁVEL CHARS
                    int pos = rnd.Next(0, chars.Length);
                    str.Append(chars[pos].ToString());
                }
                listaSenhas.Items.Add(str.ToString());
            }
        }
    }
}
