namespace GerenciamentoBiblioteca
{
    partial class UC_HistoricoLeitor
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
            this.dataGridViewHistorico = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHistorico
            // 
            this.dataGridViewHistorico.AllowUserToAddRows = false;
            this.dataGridViewHistorico.AllowUserToDeleteRows = false;
            this.dataGridViewHistorico.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewHistorico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistorico.Location = new System.Drawing.Point(25, 75);
            this.dataGridViewHistorico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewHistorico.Name = "dataGridViewHistorico";
            this.dataGridViewHistorico.ReadOnly = true;
            this.dataGridViewHistorico.RowHeadersWidth = 51;
            this.dataGridViewHistorico.RowTemplate.Height = 24;
            this.dataGridViewHistorico.Size = new System.Drawing.Size(905, 549);
            this.dataGridViewHistorico.TabIndex = 1;
            this.dataGridViewHistorico.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewHistorico_RowPrePaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Histórico de Leitura";
            // 
            // UC_HistoricoLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewHistorico);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_HistoricoLeitor";
            this.Size = new System.Drawing.Size(975, 686);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewHistorico;
        private System.Windows.Forms.Label label1;
    }
}
