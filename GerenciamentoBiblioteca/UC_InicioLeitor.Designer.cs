namespace GerenciamentoBiblioteca
{
    partial class UC_InicioLeitor
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHistorico = new System.Windows.Forms.Button();
            this.buttonPesquisa = new System.Windows.Forms.Button();
            this.buttonRanking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Início";
            // 
            // buttonHistorico
            // 
            this.buttonHistorico.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistorico.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonHistorico.Location = new System.Drawing.Point(901, 91);
            this.buttonHistorico.Name = "buttonHistorico";
            this.buttonHistorico.Size = new System.Drawing.Size(389, 276);
            this.buttonHistorico.TabIndex = 1;
            this.buttonHistorico.Text = "Histórico de leitura";
            this.buttonHistorico.UseVisualStyleBackColor = true;
            this.buttonHistorico.Click += new System.EventHandler(this.buttonHistorico_Click);
            // 
            // buttonPesquisa
            // 
            this.buttonPesquisa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonPesquisa.Location = new System.Drawing.Point(46, 91);
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.Size = new System.Drawing.Size(392, 276);
            this.buttonPesquisa.TabIndex = 2;
            this.buttonPesquisa.Text = "Pesquisar coleção";
            this.buttonPesquisa.UseVisualStyleBackColor = true;
            this.buttonPesquisa.Click += new System.EventHandler(this.buttonPesquisa_Click);
            // 
            // buttonRanking
            // 
            this.buttonRanking.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRanking.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonRanking.Location = new System.Drawing.Point(471, 91);
            this.buttonRanking.Name = "buttonRanking";
            this.buttonRanking.Size = new System.Drawing.Size(392, 276);
            this.buttonRanking.TabIndex = 5;
            this.buttonRanking.Text = "Ranking de leitores";
            this.buttonRanking.UseVisualStyleBackColor = true;
            this.buttonRanking.Click += new System.EventHandler(this.buttonRanking_Click);
            // 
            // UC_InicioLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRanking);
            this.Controls.Add(this.buttonPesquisa);
            this.Controls.Add(this.buttonHistorico);
            this.Controls.Add(this.label1);
            this.Name = "UC_InicioLeitor";
            this.Size = new System.Drawing.Size(1362, 761);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHistorico;
        private System.Windows.Forms.Button buttonPesquisa;
        private System.Windows.Forms.Button buttonRanking;
    }
}
