using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cripto_PSG.Controller
{
    internal class Funcionalidade
    {
        internal void Sair()
        {
            if (MessageBox.Show("Deseja sair da aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }
        internal void Criptar(TextBox txt_chave, TextBox txt_cripto, TextBox txt_decripto, int cripto)
        {
            if (txt_chave.Text == String.Empty)
            {
                txt_chave.Text = "1";
            }

            

            int chave = Convert.ToInt32(txt_chave.Text);


            txt_decripto.Text = String.Empty;
            int txtCifrado;
            int aux = chave * cripto;

            

            for (int i = 0; i < txt_cripto.Text.Length; i++)
            {

                int txtUsuario = (int)txt_cripto.Text[i];
                txtCifrado = txtUsuario + aux;
                txt_decripto.Text += char.ConvertFromUtf32(txtCifrado);              

            }
            if (txt_decripto.Text != String.Empty)
            {
                Clipboard.SetText(txt_decripto.Text);
            }
            
           
        }
       
                
        internal void Limpar(TextBox txt_chave, TextBox txt_cripto, TextBox txt_decripto)
        {
            txt_chave.Text = String.Empty;
            txt_cripto.Text = String.Empty;
            txt_decripto.Text = String.Empty;
        }
        internal void MensagemValidar()
        {
            DialogResult r5 = MessageBox.Show("Digite apenas números de 1 a 9!",
                 "Mensagem de aviso", MessageBoxButtons.OK,
                 MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1);
        }
    }
}
