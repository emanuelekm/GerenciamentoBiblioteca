namespace GerenciamentoBiblioteca
{
    partial class UC_FeedPublicacoes
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
            this.flowComentarios = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonFazerComentario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Publicações";
            // 
            // flowComentarios
            // 
            this.flowComentarios.AutoScroll = true;
            this.flowComentarios.BackColor = System.Drawing.SystemColors.Control;
            this.flowComentarios.Location = new System.Drawing.Point(42, 104);
            this.flowComentarios.Name = "flowComentarios";
            this.flowComentarios.Size = new System.Drawing.Size(937, 439);
            this.flowComentarios.TabIndex = 1;
            this.flowComentarios.WrapContents = false;
            // 
            // buttonFazerComentario
            // 
            this.buttonFazerComentario.BackColor = System.Drawing.SystemColors.Window;
            this.buttonFazerComentario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFazerComentario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonFazerComentario.Location = new System.Drawing.Point(901, 36);
            this.buttonFazerComentario.Name = "buttonFazerComentario";
            this.buttonFazerComentario.Size = new System.Drawing.Size(78, 54);
            this.buttonFazerComentario.TabIndex = 2;
            this.buttonFazerComentario.Text = "+";
            this.buttonFazerComentario.UseVisualStyleBackColor = false;
            this.buttonFazerComentario.Click += new System.EventHandler(this.buttonFazerComentario_Click);
            // 
            // UC_FeedPublicacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonFazerComentario);
            this.Controls.Add(this.flowComentarios);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_FeedPublicacoes";
            this.Size = new System.Drawing.Size(1015, 601);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowComentarios;
        private System.Windows.Forms.Button buttonFazerComentario;
    }
}
