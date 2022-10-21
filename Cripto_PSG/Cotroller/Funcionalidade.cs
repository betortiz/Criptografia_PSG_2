﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cripto_PSG.Cotroller
{
    internal class Funcionalidade
    {
        internal void Sair()
        {
            if (MessageBox.Show("Deseja sair da aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }

        internal void Criptar(TextBox txt_chave, TextBox txt_cripto, TextBox txt_decripto)
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
        internal void Decriptar(TextBox txt_chave, TextBox txt_decripto, TextBox txt_cripto)
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
        
        internal void Limpar(TextBox txt_chave, TextBox txt_cripto, TextBox txt_decripto)
        {
            txt_chave.Text = String.Empty;
            txt_cripto.Text = String.Empty;
            txt_decripto.Text = String.Empty;
        }
    }
}
