using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (txt_chave.Text == string.Empty)
            {
                txt_chave.Text = "1";
            }

            int chave = Convert.ToInt32(txt_chave.Text);

            txt_decripto.Text = String.Empty;
            for (int i = 0; i < txt_cripto.Text.Length; i++)
            {
                int txtUsuario = (int)txt_cripto.Text[i];
                int txtCifrado = txtUsuario + chave;
                txt_decripto.Text += char.ConvertFromUtf32(txtCifrado);
                Clipboard.SetText(txt_decripto.Text);
            }
        }

        private void btn_decriptar_Click(object sender, EventArgs e)
        {
            if (txt_chave.Text == string.Empty)
            {
                txt_chave.Text = "1";
            }

            int chave = Convert.ToInt32(txt_chave.Text);

            txt_decripto.Text = String.Empty;
            for (int i = 0; i < txt_cripto.Text.Length; i++)
            {
                int txtUsuario = (int)txt_cripto.Text[i];
                int txtCifrado = txtUsuario - chave;
                txt_decripto.Text += char.ConvertFromUtf32(txtCifrado);
            }
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
            txt_chave.Text = String.Empty;
            txt_cripto.Text = String.Empty;
            txt_decripto.Text = String.Empty;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
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
