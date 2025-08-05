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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRanking = new System.Windows.Forms.Button();
            this.buttonPesquisa = new System.Windows.Forms.Button();
            this.buttonHistorico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(8)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Início";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(370, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Histórico de Leitura";
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(632, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Publicações e avaliações";
            this.label3.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(94, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pesquisar Acervo";
            this.label4.UseMnemonic = false;
            // 
            // buttonRanking
            // 
            this.buttonRanking.BackColor = System.Drawing.SystemColors.Window;
            this.buttonRanking.BackgroundImage = global::GerenciamentoBiblioteca.Properties.Resources.icons8_tópico_popular_64;
            this.buttonRanking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRanking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRanking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRanking.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRanking.Location = new System.Drawing.Point(591, 79);
            this.buttonRanking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRanking.Name = "buttonRanking";
            this.buttonRanking.Size = new System.Drawing.Size(261, 180);
            this.buttonRanking.TabIndex = 5;
            this.buttonRanking.UseMnemonic = false;
            this.buttonRanking.UseVisualStyleBackColor = false;
            this.buttonRanking.Click += new System.EventHandler(this.buttonRanking_Click);
            // 
            // buttonPesquisa
            // 
            this.buttonPesquisa.BackColor = System.Drawing.SystemColors.Window;
            this.buttonPesquisa.BackgroundImage = global::GerenciamentoBiblioteca.Properties.Resources.icons8_pesquisar_64;
            this.buttonPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPesquisa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisa.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPesquisa.Location = new System.Drawing.Point(28, 79);
            this.buttonPesquisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.Size = new System.Drawing.Size(261, 180);
            this.buttonPesquisa.TabIndex = 2;
            this.buttonPesquisa.UseVisualStyleBackColor = false;
            this.buttonPesquisa.Click += new System.EventHandler(this.buttonPesquisa_Click);
            // 
            // buttonHistorico
            // 
            this.buttonHistorico.BackColor = System.Drawing.SystemColors.Window;
            this.buttonHistorico.BackgroundImage = global::GerenciamentoBiblioteca.Properties.Resources.icons8_leitura_641;
            this.buttonHistorico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHistorico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistorico.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHistorico.Location = new System.Drawing.Point(312, 79);
            this.buttonHistorico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHistorico.Name = "buttonHistorico";
            this.buttonHistorico.Size = new System.Drawing.Size(260, 180);
            this.buttonHistorico.TabIndex = 1;
            this.buttonHistorico.UseMnemonic = false;
            this.buttonHistorico.UseVisualStyleBackColor = false;
            this.buttonHistorico.Click += new System.EventHandler(this.buttonHistorico_Click);
            // 
            // UC_InicioLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRanking);
            this.Controls.Add(this.buttonPesquisa);
            this.Controls.Add(this.buttonHistorico);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_InicioLeitor";
            this.Size = new System.Drawing.Size(908, 495);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHistorico;
        private System.Windows.Forms.Button buttonPesquisa;
        private System.Windows.Forms.Button buttonRanking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
