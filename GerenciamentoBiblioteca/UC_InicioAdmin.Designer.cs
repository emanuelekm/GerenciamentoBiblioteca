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
            this.buttonAlterarColeção.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarColeção.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAlterarColeção.Location = new System.Drawing.Point(464, 115);
            this.buttonAlterarColeção.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAlterarColeção.Name = "buttonAlterarColeção";
            this.buttonAlterarColeção.Size = new System.Drawing.Size(380, 226);
            this.buttonAlterarColeção.TabIndex = 0;
            this.buttonAlterarColeção.Text = "Alterar coleção";
            this.buttonAlterarColeção.UseVisualStyleBackColor = true;
            this.buttonAlterarColeção.UseWaitCursor = true;
            this.buttonAlterarColeção.Click += new System.EventHandler(this.buttonAlterarColeção_Click);
            // 
            // buttonUsuarios
            // 
            this.buttonUsuarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUsuarios.Location = new System.Drawing.Point(884, 115);
            this.buttonUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUsuarios.Name = "buttonUsuarios";
            this.buttonUsuarios.Size = new System.Drawing.Size(380, 226);
            this.buttonUsuarios.TabIndex = 1;
            this.buttonUsuarios.Text = "Visualizar/ \r\nCadastrar novos usuários";
            this.buttonUsuarios.UseVisualStyleBackColor = true;
            this.buttonUsuarios.UseWaitCursor = true;
            this.buttonUsuarios.Click += new System.EventHandler(this.buttonUsuarios_Click);
            // 
            // buttonEmprestimo
            // 
            this.buttonEmprestimo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmprestimo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEmprestimo.Location = new System.Drawing.Point(34, 369);
            this.buttonEmprestimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEmprestimo.Name = "buttonEmprestimo";
            this.buttonEmprestimo.Size = new System.Drawing.Size(380, 226);
            this.buttonEmprestimo.TabIndex = 2;
            this.buttonEmprestimo.Text = "Empréstimos";
            this.buttonEmprestimo.UseVisualStyleBackColor = true;
            this.buttonEmprestimo.UseWaitCursor = true;
            this.buttonEmprestimo.Click += new System.EventHandler(this.buttonEmprestimo_Click);
            // 
            // buttonDevolucoes
            // 
            this.buttonDevolucoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDevolucoes.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDevolucoes.Location = new System.Drawing.Point(464, 369);
            this.buttonDevolucoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDevolucoes.Name = "buttonDevolucoes";
            this.buttonDevolucoes.Size = new System.Drawing.Size(380, 226);
            this.buttonDevolucoes.TabIndex = 3;
            this.buttonDevolucoes.Text = "Devoluções";
            this.buttonDevolucoes.UseVisualStyleBackColor = true;
            this.buttonDevolucoes.UseWaitCursor = true;
            this.buttonDevolucoes.Click += new System.EventHandler(this.buttonDevolucoes_Click);
            // 
            // buttonRelatorio
            // 
            this.buttonRelatorio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRelatorio.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRelatorio.Location = new System.Drawing.Point(884, 369);
            this.buttonRelatorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRelatorio.Name = "buttonRelatorio";
            this.buttonRelatorio.Size = new System.Drawing.Size(380, 226);
            this.buttonRelatorio.TabIndex = 4;
            this.buttonRelatorio.Text = "Relatórios";
            this.buttonRelatorio.UseVisualStyleBackColor = true;
            this.buttonRelatorio.UseWaitCursor = true;
            this.buttonRelatorio.Click += new System.EventHandler(this.buttonRelatorio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Início";
            this.label1.UseWaitCursor = true;
            // 
            // buttonPesquisarAcervo
            // 
            this.buttonPesquisarAcervo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisarAcervo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPesquisarAcervo.Location = new System.Drawing.Point(34, 115);
            this.buttonPesquisarAcervo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPesquisarAcervo.Name = "buttonPesquisarAcervo";
            this.buttonPesquisarAcervo.Size = new System.Drawing.Size(380, 226);
            this.buttonPesquisarAcervo.TabIndex = 10;
            this.buttonPesquisarAcervo.Text = "Pesquisar acervo";
            this.buttonPesquisarAcervo.UseVisualStyleBackColor = true;
            this.buttonPesquisarAcervo.UseWaitCursor = true;
            this.buttonPesquisarAcervo.Click += new System.EventHandler(this.buttonPesquisarAcervo_Click);
            // 
            // UC_InicioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonPesquisarAcervo);
            this.Controls.Add(this.buttonEmprestimo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDevolucoes);
            this.Controls.Add(this.buttonRelatorio);
            this.Controls.Add(this.buttonAlterarColeção);
            this.Controls.Add(this.buttonUsuarios);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_InicioAdmin";
            this.Size = new System.Drawing.Size(1369, 709);
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
