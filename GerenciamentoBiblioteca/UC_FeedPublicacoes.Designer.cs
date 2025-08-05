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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(8)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Publicações";
            // 
            // flowComentarios
            // 
            this.flowComentarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowComentarios.AutoScroll = true;
            this.flowComentarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.flowComentarios.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowComentarios.Location = new System.Drawing.Point(29, 94);
            this.flowComentarios.Name = "flowComentarios";
            this.flowComentarios.Size = new System.Drawing.Size(912, 439);
            this.flowComentarios.TabIndex = 1;
            this.flowComentarios.WrapContents = false;
            // 
            // buttonFazerComentario
            // 
            this.buttonFazerComentario.BackColor = System.Drawing.SystemColors.Control;
            this.buttonFazerComentario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFazerComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(8)))), ((int)(((byte)(67)))));
            this.buttonFazerComentario.Location = new System.Drawing.Point(773, 26);
            this.buttonFazerComentario.Name = "buttonFazerComentario";
            this.buttonFazerComentario.Size = new System.Drawing.Size(168, 52);
            this.buttonFazerComentario.TabIndex = 2;
            this.buttonFazerComentario.Text = "Fazer publicação";
            this.buttonFazerComentario.UseVisualStyleBackColor = false;
            this.buttonFazerComentario.Click += new System.EventHandler(this.buttonFazerComentario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GerenciamentoBiblioteca.Properties.Resources.icons8_voltar_24;
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UC_FeedPublicacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonFazerComentario);
            this.Controls.Add(this.flowComentarios);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_FeedPublicacoes";
            this.Size = new System.Drawing.Size(983, 601);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowComentarios;
        private System.Windows.Forms.Button buttonFazerComentario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
