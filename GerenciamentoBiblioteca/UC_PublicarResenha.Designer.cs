namespace GerenciamentoBiblioteca
{
    partial class UC_PublicarResenha
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.nudEstrelas = new System.Windows.Forms.NumericUpDown();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.cbLivros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstrelas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.btnPublicar);
            this.panel1.Controls.Add(this.nudEstrelas);
            this.panel1.Controls.Add(this.txtComentario);
            this.panel1.Controls.Add(this.cbLivros);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(42, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 370);
            this.panel1.TabIndex = 3;
            // 
            // btnPublicar
            // 
            this.btnPublicar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicar.Location = new System.Drawing.Point(88, 322);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(203, 27);
            this.btnPublicar.TabIndex = 3;
            this.btnPublicar.Text = "PUBLICAR";
            this.btnPublicar.UseVisualStyleBackColor = true;
            // 
            // nudEstrelas
            // 
            this.nudEstrelas.Location = new System.Drawing.Point(21, 282);
            this.nudEstrelas.Name = "nudEstrelas";
            this.nudEstrelas.Size = new System.Drawing.Size(345, 25);
            this.nudEstrelas.TabIndex = 2;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(21, 59);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(345, 205);
            this.txtComentario.TabIndex = 1;
            // 
            // cbLivros
            // 
            this.cbLivros.FormattingEnabled = true;
            this.cbLivros.Location = new System.Drawing.Point(21, 21);
            this.cbLivros.Name = "cbLivros";
            this.cbLivros.Size = new System.Drawing.Size(345, 25);
            this.cbLivros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Publicar";
            // 
            // UC_PublicarResenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UC_PublicarResenha";
            this.Size = new System.Drawing.Size(500, 540);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstrelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.NumericUpDown nudEstrelas;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.ComboBox cbLivros;
        private System.Windows.Forms.Label label1;
    }
}
