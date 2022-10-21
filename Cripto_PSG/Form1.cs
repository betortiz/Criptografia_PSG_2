using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cripto_PSG.Cotroller;

namespace Cripto_PSG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void message_validator()
        {
            DialogResult r5 = MessageBox.Show("Digite apenas números de 1 a 9!",
                 "Mensagem de aviso", MessageBoxButtons.OK,
                 MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1);

        }


        private void btn_criptar_Click(object sender, EventArgs e)
        {
            Funcionalidade cripto = new Funcionalidade();
            cripto.Criptar(txt_chave, txt_cripto, txt_decripto);
        }

        private void btn_decriptar_Click(object sender, EventArgs e)
        {
            Funcionalidade decripto = new Funcionalidade();
            decripto.Decriptar(txt_chave, txt_cripto, txt_decripto);
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
            Funcionalidade lmp1 = new Funcionalidade();
            lmp1.Limpar(txt_chave, txt_cripto, txt_decripto);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Funcionalidade s1 = new Funcionalidade();
            s1.Sair();
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
    }
}
