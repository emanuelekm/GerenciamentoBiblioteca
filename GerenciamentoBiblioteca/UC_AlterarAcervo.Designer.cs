namespace GerenciamentoBiblioteca
{
    partial class UC_AlterarAcervo
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
            this.dataGridViewModificarAcervo = new System.Windows.Forms.DataGridView();
            this.textBoxPesquisarColecao = new System.Windows.Forms.TextBox();
            this.pictureBoxLupa = new System.Windows.Forms.PictureBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificarAcervo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alterar acervo";
            // 
            // dataGridViewModificarAcervo
            // 
            this.dataGridViewModificarAcervo.AllowUserToAddRows = false;
            this.dataGridViewModificarAcervo.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewModificarAcervo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewModificarAcervo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewModificarAcervo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModificarAcervo.Location = new System.Drawing.Point(46, 170);
            this.dataGridViewModificarAcervo.Name = "dataGridViewModificarAcervo";
            this.dataGridViewModificarAcervo.RowHeadersWidth = 62;
            this.dataGridViewModificarAcervo.RowTemplate.Height = 28;
            this.dataGridViewModificarAcervo.Size = new System.Drawing.Size(1431, 691);
            this.dataGridViewModificarAcervo.TabIndex = 1;
            // 
            // textBoxPesquisarColecao
            // 
            this.textBoxPesquisarColecao.Location = new System.Drawing.Point(46, 109);
            this.textBoxPesquisarColecao.Multiline = true;
            this.textBoxPesquisarColecao.Name = "textBoxPesquisarColecao";
            this.textBoxPesquisarColecao.Size = new System.Drawing.Size(851, 34);
            this.textBoxPesquisarColecao.TabIndex = 2;
            // 
            // pictureBoxLupa
            // 
            this.pictureBoxLupa.Image = global::GerenciamentoBiblioteca.Properties.Resources.icons8_pesquisar_24;
            this.pictureBoxLupa.Location = new System.Drawing.Point(903, 113);
            this.pictureBoxLupa.Name = "pictureBoxLupa";
            this.pictureBoxLupa.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLupa.TabIndex = 3;
            this.pictureBoxLupa.TabStop = false;
            this.pictureBoxLupa.Click += new System.EventHandler(this.pictureBoxLupa_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(1145, 77);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(150, 66);
            this.buttonEditar.TabIndex = 4;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.Location = new System.Drawing.Point(1329, 77);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(150, 66);
            this.buttonExcluir.TabIndex = 5;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Location = new System.Drawing.Point(951, 77);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(150, 66);
            this.buttonAdicionar.TabIndex = 6;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // UC_AlterarAcervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.pictureBoxLupa);
            this.Controls.Add(this.textBoxPesquisarColecao);
            this.Controls.Add(this.dataGridViewModificarAcervo);
            this.Controls.Add(this.label1);
            this.Name = "UC_AlterarAcervo";
            this.Size = new System.Drawing.Size(1513, 913);
            this.Load += new System.EventHandler(this.UCAlterarAcervo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificarAcervo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewModificarAcervo;
        private System.Windows.Forms.TextBox textBoxPesquisarColecao;
        private System.Windows.Forms.PictureBox pictureBoxLupa;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAdicionar;
    }
}
