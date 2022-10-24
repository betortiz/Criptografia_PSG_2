using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cripto_PSG.Controller;

namespace Cripto_PSG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Funcionalidade controller = new Funcionalidade();

        private void btn_criptar_Click(object sender, EventArgs e)
        {
            int cripto = +1;

            controller.Criptar(txt_chave, txt_cripto, txt_decripto, cripto);
        }
        private void btn_decriptar_Click(object sender, EventArgs e)
        {
            int cripto = -1;

            controller.Criptar(txt_chave, txt_cripto, txt_decripto, cripto);
        }
        private void txt_chave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0')
            {
                e.Handled = true;
                DialogResult dn = MessageBox.Show("Digite apenas número de 1 a 9", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dn = MessageBox.Show("Somente números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            controller.Limpar(txt_chave, txt_cripto, txt_decripto);
        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            controller.Sair();
        }
        public void message_validator()
        {
            controller.MensagemValidar();
        }
        private void btn_criptar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_criptar_Click(sender, e);
            }
        }
        private void txt_chave_TextChanged(object sender, EventArgs e)
        {
            if (txt_chave.Text.Length > 1)
            {
                txt_chave.Text = String.Empty;
                message_validator();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
