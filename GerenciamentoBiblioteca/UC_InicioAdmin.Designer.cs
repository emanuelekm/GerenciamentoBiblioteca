namespace GerenciamentoBiblioteca
{
    partial class UC_InicioAdmin
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
            this.buttonAlterarColeção = new System.Windows.Forms.Button();
            this.buttonUsuarios = new System.Windows.Forms.Button();
            this.buttonEmprestimo = new System.Windows.Forms.Button();
            this.buttonDevolucoes = new System.Windows.Forms.Button();
            this.buttonRelatorio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPesquisarAcervo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAlterarColeção
            // 
            this.buttonAlterarColeção.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarColeção.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonAlterarColeção.Location = new System.Drawing.Point(465, 144);
            this.buttonAlterarColeção.Name = "buttonAlterarColeção";
            this.buttonAlterarColeção.Size = new System.Drawing.Size(381, 197);
            this.buttonAlterarColeção.TabIndex = 0;
            this.buttonAlterarColeção.Text = "Alterar coleção";
            this.buttonAlterarColeção.UseVisualStyleBackColor = true;
            this.buttonAlterarColeção.UseWaitCursor = true;
            this.buttonAlterarColeção.Click += new System.EventHandler(this.buttonAlterarColeção_Click);
            // 
            // buttonUsuarios
            // 
            this.buttonUsuarios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuarios.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonUsuarios.Location = new System.Drawing.Point(878, 144);
            this.buttonUsuarios.Name = "buttonUsuarios";
            this.buttonUsuarios.Size = new System.Drawing.Size(381, 197);
            this.buttonUsuarios.TabIndex = 1;
            this.buttonUsuarios.Text = "Visualizar/ \r\nCadastrar novos usuários";
            this.buttonUsuarios.UseVisualStyleBackColor = true;
            this.buttonUsuarios.UseWaitCursor = true;
            this.buttonUsuarios.Click += new System.EventHandler(this.buttonUsuarios_Click);
            // 
            // buttonEmprestimo
            // 
            this.buttonEmprestimo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmprestimo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonEmprestimo.Location = new System.Drawing.Point(55, 384);
            this.buttonEmprestimo.Name = "buttonEmprestimo";
            this.buttonEmprestimo.Size = new System.Drawing.Size(381, 197);
            this.buttonEmprestimo.TabIndex = 2;
            this.buttonEmprestimo.Text = "Empréstimos";
            this.buttonEmprestimo.UseVisualStyleBackColor = true;
            this.buttonEmprestimo.UseWaitCursor = true;
            this.buttonEmprestimo.Click += new System.EventHandler(this.buttonEmprestimo_Click);
            // 
            // buttonDevolucoes
            // 
            this.buttonDevolucoes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDevolucoes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonDevolucoes.Location = new System.Drawing.Point(465, 384);
            this.buttonDevolucoes.Name = "buttonDevolucoes";
            this.buttonDevolucoes.Size = new System.Drawing.Size(381, 197);
            this.buttonDevolucoes.TabIndex = 3;
            this.buttonDevolucoes.Text = "Devoluções";
            this.buttonDevolucoes.UseVisualStyleBackColor = true;
            this.buttonDevolucoes.UseWaitCursor = true;
            this.buttonDevolucoes.Click += new System.EventHandler(this.buttonDevolucoes_Click);
            // 
            // buttonRelatorio
            // 
            this.buttonRelatorio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRelatorio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonRelatorio.Location = new System.Drawing.Point(878, 384);
            this.buttonRelatorio.Name = "buttonRelatorio";
            this.buttonRelatorio.Size = new System.Drawing.Size(381, 197);
            this.buttonRelatorio.TabIndex = 4;
            this.buttonRelatorio.Text = "Relatórios";
            this.buttonRelatorio.UseVisualStyleBackColor = true;
            this.buttonRelatorio.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(49, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Início";
            this.label1.UseWaitCursor = true;
            // 
            // buttonPesquisarAcervo
            // 
            this.buttonPesquisarAcervo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisarAcervo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonPesquisarAcervo.Location = new System.Drawing.Point(55, 144);
            this.buttonPesquisarAcervo.Name = "buttonPesquisarAcervo";
            this.buttonPesquisarAcervo.Size = new System.Drawing.Size(381, 197);
            this.buttonPesquisarAcervo.TabIndex = 10;
            this.buttonPesquisarAcervo.Text = "Pesquisar acervo";
            this.buttonPesquisarAcervo.UseVisualStyleBackColor = true;
            this.buttonPesquisarAcervo.UseWaitCursor = true;
            this.buttonPesquisarAcervo.Click += new System.EventHandler(this.buttonPesquisarAcervo_Click);
            // 
            // UCInicioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonPesquisarAcervo);
            this.Controls.Add(this.buttonEmprestimo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDevolucoes);
            this.Controls.Add(this.buttonRelatorio);
            this.Controls.Add(this.buttonAlterarColeção);
            this.Controls.Add(this.buttonUsuarios);
            this.Name = "UCInicioAdmin";
            this.Size = new System.Drawing.Size(1665, 886);
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAlterarColeção;
        private System.Windows.Forms.Button buttonUsuarios;
        private System.Windows.Forms.Button buttonEmprestimo;
        private System.Windows.Forms.Button buttonDevolucoes;
        private System.Windows.Forms.Button buttonRelatorio;
        //private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.Panel panel1;
        //public System.Windows.Forms.DataGridView dataGridView2;
        //private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPesquisarAcervo;
    }
}
