namespace GerenciamentoBiblioteca
{
    partial class UC_Relatorios
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chartEmprestimo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewEmprestimo = new System.Windows.Forms.DataGridView();
            this.buttonExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmprestimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(41, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatório de Empréstimos e Devoluções";
            // 
            // chartEmprestimo
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEmprestimo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEmprestimo.Legends.Add(legend1);
            this.chartEmprestimo.Location = new System.Drawing.Point(46, 445);
            this.chartEmprestimo.Name = "chartEmprestimo";
            this.chartEmprestimo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEmprestimo.Series.Add(series1);
            this.chartEmprestimo.Size = new System.Drawing.Size(597, 383);
            this.chartEmprestimo.TabIndex = 1;
            this.chartEmprestimo.Text = "chartEmprestimo";
            // 
            // dataGridViewEmprestimo
            // 
            this.dataGridViewEmprestimo.AllowUserToAddRows = false;
            this.dataGridViewEmprestimo.AllowUserToDeleteRows = false;
            this.dataGridViewEmprestimo.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewEmprestimo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmprestimo.Location = new System.Drawing.Point(46, 112);
            this.dataGridViewEmprestimo.Name = "dataGridViewEmprestimo";
            this.dataGridViewEmprestimo.ReadOnly = true;
            this.dataGridViewEmprestimo.RowHeadersWidth = 62;
            this.dataGridViewEmprestimo.RowTemplate.Height = 28;
            this.dataGridViewEmprestimo.Size = new System.Drawing.Size(1333, 310);
            this.dataGridViewEmprestimo.TabIndex = 2;
            this.dataGridViewEmprestimo.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewEmprestimo_RowPrePaint);
            // 
            // buttonExportar
            // 
            this.buttonExportar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportar.Location = new System.Drawing.Point(1097, 32);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(282, 56);
            this.buttonExportar.TabIndex = 3;
            this.buttonExportar.Text = "Exportar dados em PDF";
            this.buttonExportar.UseVisualStyleBackColor = true;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // UC_Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.dataGridViewEmprestimo);
            this.Controls.Add(this.chartEmprestimo);
            this.Controls.Add(this.label1);
            this.Name = "UC_Relatorios";
            this.Size = new System.Drawing.Size(1505, 939);
            ((System.ComponentModel.ISupportInitialize)(this.chartEmprestimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprestimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEmprestimo;
        private System.Windows.Forms.DataGridView dataGridViewEmprestimo;
        private System.Windows.Forms.Button buttonExportar;
    }
}
