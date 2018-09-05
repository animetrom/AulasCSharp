using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEntrar.Enabled = false;
        }

        private void text_Change(object sender, EventArgs e)
        {
            /*
             *  O BOTÃO ENTRAR SÓ SERÁ ATIVADO QUANDO O TEXTO DOS CAMPOS
             *  MUDAR PARA ALGO DIFERENTE DO VASIO
             *  != SIGNIFICA DIFERENTE
             *  && - SIGNIFICA "E" SÓ VAI SER VERDADEIRO QUANDO
             *  TODAS AS CONDIÇÕES FOREM VERDADEIRAS
             */
             btnEntrar.Enabled = txtUsuario.Text != "" && txtSenha.Text != "" ? true : false;
          }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                /* COMANDO FOCUS FA COM QUE O FOCO DO SISTEMA,
                 * NO CASO, O CURSOR VÁ PARA O CAMPO INDICADO
                */
                txtSenha.Focus();
                /*
                 * OS COMANDOS A SEGUIR SÃO RESPONSÁVEIS POR DESATIVAR O BEEP
                 * DO COMPUTADOR NO MOMENTO QUE FAÇO ALGO NO SISTEMA
                */
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                /* COMANDO FOCUS FA COM QUE O FOCO DO SISTEMA, 
                 * NESSE CASO, O COMANDO EXECUTA A CHAMADO DO BOTÃO ENTRAR
                */ 
                btnEntrar_Click(this, EventArgs.Empty);
                /*
                 * OS COMANDOS A SEGUIR SÃO RESPONSÁVEIS POR DESATIVAR O BEEP
                 * DO COMPUTADOR NO MOMENTO QUE FAÇO ALGO NO SISTEMA
                */
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!btnEntrar.Enabled) return;
            MessageBox.Show("Você acaba de entrar no sistema!");
        }
    }
}
