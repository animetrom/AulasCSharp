using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEnviar.Enabled = false;
        }

        private void muda_Texto(object sender, EventArgs e)
        {
            // IRÁ VERIFICAR SE TODOS OS TEXTBOXS ESTÃO PREENCHIDOS, CASO NÃO ESTIVEREM MANTER DESATIVADO, SE ESTIVEREM AI ATIVAR
            btnEnviar.Enabled = txt1.Text != "" && txt2.Text != "" && txt3.Text != "" && txt4.Text != "" && txt5.Text != "" && txt6.Text != "" ? true : false;
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.DarkBlue;
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = SystemColors.Window;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!btnEnviar.Enabled) return;
            MessageBox.Show("Usuário cadastrado com sucesso!"); 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach(Control item in this.Controls)
            { // INÍCIO DO FOREACH

                if (item is TextBox)
                    item.Text = "";

            } // FINAL DO FOREACH
        }
    }
}
