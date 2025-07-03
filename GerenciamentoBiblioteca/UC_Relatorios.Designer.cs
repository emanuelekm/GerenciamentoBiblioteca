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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chartEmprestimo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewEmprestimo = new System.Windows.Forms.DataGridView();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chartLivroDisponibilidade = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartEstadoLivro = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmprestimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprestimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLivroDisponibilidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadoLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatório de Empréstimos e Devoluções";
            // 
            // chartEmprestimo
            // 
            chartArea7.Name = "ChartArea1";
            this.chartEmprestimo.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartEmprestimo.Legends.Add(legend7);
            this.chartEmprestimo.Location = new System.Drawing.Point(43, 142);
            this.chartEmprestimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartEmprestimo.Name = "chartEmprestimo";
            this.chartEmprestimo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartEmprestimo.Series.Add(series7);
            this.chartEmprestimo.Size = new System.Drawing.Size(649, 306);
            this.chartEmprestimo.TabIndex = 1;
            this.chartEmprestimo.Text = "Relação de empréstimos e devoluções";
            this.chartEmprestimo.UseWaitCursor = true;
            // 
            // dataGridViewEmprestimo
            // 
            this.dataGridViewEmprestimo.AllowUserToAddRows = false;
            this.dataGridViewEmprestimo.AllowUserToDeleteRows = false;
            this.dataGridViewEmprestimo.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewEmprestimo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmprestimo.Location = new System.Drawing.Point(43, 493);
            this.dataGridViewEmprestimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewEmprestimo.Name = "dataGridViewEmprestimo";
            this.dataGridViewEmprestimo.ReadOnly = true;
            this.dataGridViewEmprestimo.RowHeadersWidth = 62;
            this.dataGridViewEmprestimo.RowTemplate.Height = 28;
            this.dataGridViewEmprestimo.Size = new System.Drawing.Size(1536, 303);
            this.dataGridViewEmprestimo.TabIndex = 2;
            this.dataGridViewEmprestimo.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewEmprestimo_RowPrePaint);
            // 
            // buttonExportar
            // 
            this.buttonExportar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportar.Location = new System.Drawing.Point(1328, 28);
            this.buttonExportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(251, 60);
            this.buttonExportar.TabIndex = 3;
            this.buttonExportar.Text = "Exportar dados em PDF";
            this.buttonExportar.UseVisualStyleBackColor = true;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(570, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade de empréstimos e devoluções de acordo com os estados em tempo real";
            // 
            // chartLivroDisponibilidade
            // 
            chartArea8.Name = "ChartArea1";
            this.chartLivroDisponibilidade.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartLivroDisponibilidade.Legends.Add(legend8);
            this.chartLivroDisponibilidade.Location = new System.Drawing.Point(728, 110);
            this.chartLivroDisponibilidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartLivroDisponibilidade.Name = "chartLivroDisponibilidade";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartLivroDisponibilidade.Series.Add(series8);
            this.chartLivroDisponibilidade.Size = new System.Drawing.Size(411, 338);
            this.chartLivroDisponibilidade.TabIndex = 5;
            this.chartLivroDisponibilidade.Text = "chart1";
            // 
            // chartEstadoLivro
            // 
            chartArea9.Name = "ChartArea1";
            this.chartEstadoLivro.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartEstadoLivro.Legends.Add(legend9);
            this.chartEstadoLivro.Location = new System.Drawing.Point(1168, 142);
            this.chartEstadoLivro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartEstadoLivro.Name = "chartEstadoLivro";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartEstadoLivro.Series.Add(series9);
            this.chartEstadoLivro.Size = new System.Drawing.Size(411, 307);
            this.chartEstadoLivro.TabIndex = 6;
            this.chartEstadoLivro.Text = "Estado dos Livros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1165, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado dos livros";
            // 
            // UC_Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartEstadoLivro);
            this.Controls.Add(this.chartLivroDisponibilidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.dataGridViewEmprestimo);
            this.Controls.Add(this.chartEmprestimo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Relatorios";
            this.Size = new System.Drawing.Size(1603, 828);
            ((System.ComponentModel.ISupportInitialize)(this.chartEmprestimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprestimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLivroDisponibilidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadoLivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEmprestimo;
        private System.Windows.Forms.DataGridView dataGridViewEmprestimo;
        private System.Windows.Forms.Button buttonExportar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLivroDisponibilidade;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEstadoLivro;
        private System.Windows.Forms.Label label3;
    }
}
