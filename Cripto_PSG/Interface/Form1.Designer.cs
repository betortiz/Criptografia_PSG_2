namespace Cripto_PSG
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_chave = new System.Windows.Forms.TextBox();
            this.btn_criptar = new System.Windows.Forms.Button();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.txt_cripto = new System.Windows.Forms.TextBox();
            this.txt_decripto = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_decriptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_chave
            // 
            this.txt_chave.AccessibleDescription = "bla";
            this.txt_chave.AccessibleName = "Digite um número de 1 a 9.";
            this.txt_chave.BackColor = System.Drawing.SystemColors.InfoText;
            this.txt_chave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.txt_chave.Location = new System.Drawing.Point(12, 43);
            this.txt_chave.MaxLength = 2;
            this.txt_chave.Name = "txt_chave";
            this.txt_chave.Size = new System.Drawing.Size(40, 24);
            this.txt_chave.TabIndex = 1;
            this.txt_chave.Tag = "";
            this.txt_chave.TextChanged += new System.EventHandler(this.txt_chave_TextChanged);
            this.txt_chave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_chave_KeyPress);
            // 
            // btn_criptar
            // 
            this.btn_criptar.BackColor = System.Drawing.Color.Black;
            this.btn_criptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_criptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_criptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_criptar.ForeColor = System.Drawing.Color.MistyRose;
            this.btn_criptar.Location = new System.Drawing.Point(12, 272);
            this.btn_criptar.Name = "btn_criptar";
            this.btn_criptar.Size = new System.Drawing.Size(110, 30);
            this.btn_criptar.TabIndex = 3;
            this.btn_criptar.Text = "Criptografar";
            this.btn_criptar.UseVisualStyleBackColor = false;
            this.btn_criptar.Click += new System.EventHandler(this.btn_criptar_Click);
            this.btn_criptar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_criptar_KeyPress);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.ForeColor = System.Drawing.Color.MistyRose;
            this.lbl_1.Location = new System.Drawing.Point(9, 9);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(276, 18);
            this.lbl_1.TabIndex = 2;
            this.lbl_1.Text = "Digite a chave de 1 a 9 logo abaixo:";
            // 
            // txt_cripto
            // 
            this.txt_cripto.BackColor = System.Drawing.SystemColors.Desktop;
            this.txt_cripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cripto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.txt_cripto.Location = new System.Drawing.Point(12, 149);
            this.txt_cripto.Multiline = true;
            this.txt_cripto.Name = "txt_cripto";
            this.txt_cripto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_cripto.Size = new System.Drawing.Size(477, 97);
            this.txt_cripto.TabIndex = 2;
            this.txt_cripto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_criptar_KeyPress);
            // 
            // txt_decripto
            // 
            this.txt_decripto.BackColor = System.Drawing.Color.Black;
            this.txt_decripto.CausesValidation = false;
            this.txt_decripto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_decripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_decripto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.txt_decripto.Location = new System.Drawing.Point(12, 362);
            this.txt_decripto.Multiline = true;
            this.txt_decripto.Name = "txt_decripto";
            this.txt_decripto.ReadOnly = true;
            this.txt_decripto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_decripto.Size = new System.Drawing.Size(477, 97);
            this.txt_decripto.TabIndex = 7;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.Black;
            this.btn_limpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.Silver;
            this.btn_limpar.Location = new System.Drawing.Point(379, 272);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(110, 30);
            this.btn_limpar.TabIndex = 5;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Black;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.btn_sair.Location = new System.Drawing.Point(379, 487);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(110, 30);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_decriptar
            // 
            this.btn_decriptar.BackColor = System.Drawing.Color.Black;
            this.btn_decriptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_decriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_decriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decriptar.ForeColor = System.Drawing.Color.MistyRose;
            this.btn_decriptar.Location = new System.Drawing.Point(193, 272);
            this.btn_decriptar.Name = "btn_decriptar";
            this.btn_decriptar.Size = new System.Drawing.Size(110, 30);
            this.btn_decriptar.TabIndex = 8;
            this.btn_decriptar.Text = "Decriptar";
            this.btn_decriptar.UseVisualStyleBackColor = false;
            this.btn_decriptar.Click += new System.EventHandler(this.btn_decriptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(9, 89);
            this.label1.MaximumSize = new System.Drawing.Size(400, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Insira a mensagem na caixa abaixo e clique na opção desejada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(9, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Resultado ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(23)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(516, 558);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_decriptar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.txt_decripto);
            this.Controls.Add(this.txt_cripto);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.btn_criptar);
            this.Controls.Add(this.txt_chave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criptografia PSG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_chave;
        private System.Windows.Forms.Button btn_criptar;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.TextBox txt_cripto;
        private System.Windows.Forms.TextBox txt_decripto;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_decriptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

