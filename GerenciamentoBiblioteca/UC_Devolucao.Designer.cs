namespace GerenciamentoBiblioteca
{
    partial class UC_Devolucao
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
            this.dataGridViewDevolucoes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDevolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevolucoes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Realizar Devolução";
            // 
            // dataGridViewDevolucoes
            // 
            this.dataGridViewDevolucoes.AllowUserToAddRows = false;
            this.dataGridViewDevolucoes.AllowUserToDeleteRows = false;
            this.dataGridViewDevolucoes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewDevolucoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDevolucoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDevolucoes.Location = new System.Drawing.Point(42, 128);
            this.dataGridViewDevolucoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDevolucoes.Name = "dataGridViewDevolucoes";
            this.dataGridViewDevolucoes.ReadOnly = true;
            this.dataGridViewDevolucoes.RowHeadersWidth = 62;
            this.dataGridViewDevolucoes.RowTemplate.Height = 28;
            this.dataGridViewDevolucoes.Size = new System.Drawing.Size(1527, 583);
            this.dataGridViewDevolucoes.TabIndex = 1;
            this.dataGridViewDevolucoes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewDevolucoes_CellFormatting);
            this.dataGridViewDevolucoes.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewDevolucoes_RowPrePaint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(37, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empréstimos em andamento";
            // 
            // buttonDevolver
            // 
            this.buttonDevolver.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDevolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDevolver.Location = new System.Drawing.Point(1321, 50);
            this.buttonDevolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDevolver.Name = "buttonDevolver";
            this.buttonDevolver.Size = new System.Drawing.Size(248, 51);
            this.buttonDevolver.TabIndex = 3;
            this.buttonDevolver.Text = "Confirmar devolução";
            this.buttonDevolver.UseVisualStyleBackColor = true;
            this.buttonDevolver.Click += new System.EventHandler(this.buttonDevolver_Click);
            // 
            // UC_Devolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDevolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDevolucoes);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Devolucao";
            this.Size = new System.Drawing.Size(1632, 746);
            this.Load += new System.EventHandler(this.UC_Devolucao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevolucoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDevolucoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDevolver;
    }
}
