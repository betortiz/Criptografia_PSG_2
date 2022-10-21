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
            this.SuspendLayout();
            // 
            // txt_chave
            // 
            this.txt_chave.Location = new System.Drawing.Point(12, 12);
            this.txt_chave.Name = "txt_chave";
            this.txt_chave.Size = new System.Drawing.Size(40, 20);
            this.txt_chave.TabIndex = 1;
            this.txt_chave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_chave.TextChanged += new System.EventHandler(this.txt_chave_TextChanged);
            this.txt_chave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_chave_KeyPress);
            // 
            // btn_criptar
            // 
            this.btn_criptar.BackColor = System.Drawing.Color.White;
            this.btn_criptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_criptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_criptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_criptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.btn_criptar.Location = new System.Drawing.Point(12, 235);
            this.btn_criptar.Name = "btn_criptar";
            this.btn_criptar.Size = new System.Drawing.Size(75, 30);
            this.btn_criptar.TabIndex = 3;
            this.btn_criptar.Text = "Criptar";
            this.btn_criptar.UseVisualStyleBackColor = false;
            this.btn_criptar.Click += new System.EventHandler(this.btn_criptar_Click);
            this.btn_criptar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_criptar_KeyPress);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.ForeColor = System.Drawing.Color.White;
            this.lbl_1.Location = new System.Drawing.Point(68, 12);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(273, 17);
            this.lbl_1.TabIndex = 2;
            this.lbl_1.Text = "Digite um valor para a chave (1 - 9 )";
            // 
            // txt_cripto
            // 
            this.txt_cripto.Location = new System.Drawing.Point(12, 38);
            this.txt_cripto.Multiline = true;
            this.txt_cripto.Name = "txt_cripto";
            this.txt_cripto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_cripto.Size = new System.Drawing.Size(428, 97);
            this.txt_cripto.TabIndex = 2;
            this.txt_cripto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_criptar_KeyPress);
            // 
            // txt_decripto
            // 
            this.txt_decripto.Enabled = false;
            this.txt_decripto.Location = new System.Drawing.Point(12, 141);
            this.txt_decripto.Multiline = true;
            this.txt_decripto.Name = "txt_decripto";
            this.txt_decripto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_decripto.Size = new System.Drawing.Size(428, 90);
            this.txt_decripto.TabIndex = 7;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.White;
            this.btn_limpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.btn_limpar.Location = new System.Drawing.Point(251, 235);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 30);
            this.btn_limpar.TabIndex = 5;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.White;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.btn_sair.Location = new System.Drawing.Point(365, 235);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 30);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_decriptar
            // 
            this.btn_decriptar.BackColor = System.Drawing.Color.White;
            this.btn_decriptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_decriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_decriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decriptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.btn_decriptar.Location = new System.Drawing.Point(128, 235);
            this.btn_decriptar.Name = "btn_decriptar";
            this.btn_decriptar.Size = new System.Drawing.Size(80, 30);
            this.btn_decriptar.TabIndex = 8;
            this.btn_decriptar.Text = "Decriptar";
            this.btn_decriptar.UseVisualStyleBackColor = false;
            this.btn_decriptar.Click += new System.EventHandler(this.btn_decriptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(452, 271);
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
    }
}

