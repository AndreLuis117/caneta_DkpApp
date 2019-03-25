namespace Caneta
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
            this.label_modelo = new System.Windows.Forms.Label();
            this.label_marca = new System.Windows.Forms.Label();
            this.label_cor = new System.Windows.Forms.Label();
            this.label_cor_tinta = new System.Windows.Forms.Label();
            this.label_qtde_tinta = new System.Windows.Forms.Label();
            this.txt_caixa = new System.Windows.Forms.TextBox();
            this.botao_escrever = new System.Windows.Forms.Button();
            this.eco = new System.Windows.Forms.CheckBox();
            this.label_vezes_escreveu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox_hist_escritas = new System.Windows.Forms.ListBox();
            this.label_desc_hist_escri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_modelo
            // 
            this.label_modelo.AutoSize = true;
            this.label_modelo.Location = new System.Drawing.Point(12, 9);
            this.label_modelo.Name = "label_modelo";
            this.label_modelo.Size = new System.Drawing.Size(42, 13);
            this.label_modelo.TabIndex = 1;
            this.label_modelo.Text = "Modelo";
            // 
            // label_marca
            // 
            this.label_marca.AutoSize = true;
            this.label_marca.Location = new System.Drawing.Point(12, 33);
            this.label_marca.Name = "label_marca";
            this.label_marca.Size = new System.Drawing.Size(37, 13);
            this.label_marca.TabIndex = 2;
            this.label_marca.Text = "Marca";
            // 
            // label_cor
            // 
            this.label_cor.AutoSize = true;
            this.label_cor.Location = new System.Drawing.Point(12, 58);
            this.label_cor.Name = "label_cor";
            this.label_cor.Size = new System.Drawing.Size(23, 13);
            this.label_cor.TabIndex = 3;
            this.label_cor.Text = "Cor";
            // 
            // label_cor_tinta
            // 
            this.label_cor_tinta.AutoSize = true;
            this.label_cor_tinta.Location = new System.Drawing.Point(12, 80);
            this.label_cor_tinta.Name = "label_cor_tinta";
            this.label_cor_tinta.Size = new System.Drawing.Size(46, 13);
            this.label_cor_tinta.TabIndex = 4;
            this.label_cor_tinta.Text = "Cor tinta";
            // 
            // label_qtde_tinta
            // 
            this.label_qtde_tinta.AutoSize = true;
            this.label_qtde_tinta.Location = new System.Drawing.Point(12, 104);
            this.label_qtde_tinta.Name = "label_qtde_tinta";
            this.label_qtde_tinta.Size = new System.Drawing.Size(100, 13);
            this.label_qtde_tinta.TabIndex = 5;
            this.label_qtde_tinta.Text = "Quantidade de tinta";
            // 
            // txt_caixa
            // 
            this.txt_caixa.Location = new System.Drawing.Point(172, 181);
            this.txt_caixa.Name = "txt_caixa";
            this.txt_caixa.Size = new System.Drawing.Size(100, 20);
            this.txt_caixa.TabIndex = 6;
            // 
            // botao_escrever
            // 
            this.botao_escrever.Location = new System.Drawing.Point(15, 179);
            this.botao_escrever.Name = "botao_escrever";
            this.botao_escrever.Size = new System.Drawing.Size(75, 23);
            this.botao_escrever.TabIndex = 7;
            this.botao_escrever.Text = "Escrever";
            this.botao_escrever.UseVisualStyleBackColor = true;
            this.botao_escrever.Click += new System.EventHandler(this.botao_escrever_Click_1);
            // 
            // eco
            // 
            this.eco.AutoSize = true;
            this.eco.Location = new System.Drawing.Point(15, 133);
            this.eco.Name = "eco";
            this.eco.Size = new System.Drawing.Size(115, 17);
            this.eco.TabIndex = 8;
            this.eco.Text = "Caneta econômica";
            this.eco.UseVisualStyleBackColor = true;
            // 
            // label_vezes_escreveu
            // 
            this.label_vezes_escreveu.AutoSize = true;
            this.label_vezes_escreveu.Location = new System.Drawing.Point(123, 9);
            this.label_vezes_escreveu.Name = "label_vezes_escreveu";
            this.label_vezes_escreveu.Size = new System.Drawing.Size(137, 13);
            this.label_vezes_escreveu.TabIndex = 9;
            this.label_vezes_escreveu.Text = "Quantas vezes escreveu: 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Gerar caneta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_gerar_caneta);
            // 
            // listBox_hist_escritas
            // 
            this.listBox_hist_escritas.FormattingEnabled = true;
            this.listBox_hist_escritas.Location = new System.Drawing.Point(299, 39);
            this.listBox_hist_escritas.Name = "listBox_hist_escritas";
            this.listBox_hist_escritas.Size = new System.Drawing.Size(264, 173);
            this.listBox_hist_escritas.TabIndex = 12;
            // 
            // label_desc_hist_escri
            // 
            this.label_desc_hist_escri.AutoSize = true;
            this.label_desc_hist_escri.Location = new System.Drawing.Point(375, 9);
            this.label_desc_hist_escri.Name = "label_desc_hist_escri";
            this.label_desc_hist_escri.Size = new System.Drawing.Size(102, 13);
            this.label_desc_hist_escri.TabIndex = 13;
            this.label_desc_hist_escri.Text = "Histórico de escritas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 227);
            this.Controls.Add(this.label_desc_hist_escri);
            this.Controls.Add(this.listBox_hist_escritas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_vezes_escreveu);
            this.Controls.Add(this.eco);
            this.Controls.Add(this.botao_escrever);
            this.Controls.Add(this.txt_caixa);
            this.Controls.Add(this.label_qtde_tinta);
            this.Controls.Add(this.label_cor_tinta);
            this.Controls.Add(this.label_cor);
            this.Controls.Add(this.label_marca);
            this.Controls.Add(this.label_modelo);
            this.Name = "Form1";
            this.Text = "Caneta App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_modelo;
        private System.Windows.Forms.Label label_marca;
        private System.Windows.Forms.Label label_cor;
        private System.Windows.Forms.Label label_cor_tinta;
        private System.Windows.Forms.Label label_qtde_tinta;
        private System.Windows.Forms.TextBox txt_caixa;
        private System.Windows.Forms.Button botao_escrever;
        private System.Windows.Forms.CheckBox eco;
        private System.Windows.Forms.Label label_vezes_escreveu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox_hist_escritas;
        private System.Windows.Forms.Label label_desc_hist_escri;
    }
}

