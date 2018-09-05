using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularIdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            //  DateTime.Now.Year - Pega a data do meu S.O.
            // dateTimePicker1 - É o meu elemento.
            // .Value - Eu indico para o sistema o valor que eu quero
            // .Year - Eu pego o valor ANO
            int idade = DateTime.Now.Year - dateTimePicker1.Value.Year;

            if (DateTime.Now.Year < dateTimePicker1.Value.DayOfYear) idade--;

            MessageBox.Show("Tem " + idade + " anos de idade!");

            // Verificar se é menor de idade
            // Verificar se é manior que 18 e menor que 55
            // Se for maior que 55 é a melhor idade

            if (idade < 18)
            {
                MessageBox.Show("Você é  uma criança seu trouxa!");
            }
            else if (idade > 18 && idade < 55)
            {
                MessageBox.Show("Você é um Adulto agora se fodeu pra pagar dividas! (:");
            }
            else
            {
                MessageBox.Show("Boa morte! (:");
            }
        }
    }
}
