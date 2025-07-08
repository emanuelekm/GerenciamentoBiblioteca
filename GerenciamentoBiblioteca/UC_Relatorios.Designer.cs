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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chartEmprestimo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chartLivroDisponibilidade = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartEstadoLivro = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTabelaEmprestimo = new System.Windows.Forms.Button();
            this.dataGridViewLivrosEmAtraso = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmprestimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLivroDisponibilidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadoLivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivrosEmAtraso)).BeginInit();
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
            chartArea4.Name = "ChartArea1";
            this.chartEmprestimo.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartEmprestimo.Legends.Add(legend4);
            this.chartEmprestimo.Location = new System.Drawing.Point(43, 142);
            this.chartEmprestimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartEmprestimo.Name = "chartEmprestimo";
            this.chartEmprestimo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartEmprestimo.Series.Add(series4);
            this.chartEmprestimo.Size = new System.Drawing.Size(649, 644);
            this.chartEmprestimo.TabIndex = 1;
            this.chartEmprestimo.Text = "Relação de empréstimos e devoluções";
            this.chartEmprestimo.UseWaitCursor = true;
            // 
            // buttonExportar
            // 
            this.buttonExportar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportar.Location = new System.Drawing.Point(1355, 28);
            this.buttonExportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(224, 67);
            this.buttonExportar.TabIndex = 3;
            this.buttonExportar.Text = "Exportar dados gráficos em PDF";
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
            chartArea5.Name = "ChartArea1";
            this.chartLivroDisponibilidade.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartLivroDisponibilidade.Legends.Add(legend5);
            this.chartLivroDisponibilidade.Location = new System.Drawing.Point(717, 142);
            this.chartLivroDisponibilidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartLivroDisponibilidade.Name = "chartLivroDisponibilidade";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartLivroDisponibilidade.Series.Add(series5);
            this.chartLivroDisponibilidade.Size = new System.Drawing.Size(411, 306);
            this.chartLivroDisponibilidade.TabIndex = 5;
            this.chartLivroDisponibilidade.Text = "chart1";
            // 
            // chartEstadoLivro
            // 
            chartArea6.Name = "ChartArea1";
            this.chartEstadoLivro.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartEstadoLivro.Legends.Add(legend6);
            this.chartEstadoLivro.Location = new System.Drawing.Point(1157, 142);
            this.chartEstadoLivro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartEstadoLivro.Name = "chartEstadoLivro";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartEstadoLivro.Series.Add(series6);
            this.chartEstadoLivro.Size = new System.Drawing.Size(411, 307);
            this.chartEstadoLivro.TabIndex = 6;
            this.chartEstadoLivro.Text = "Estado dos Livros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1154, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado dos livros";
            // 
            // buttonTabelaEmprestimo
            // 
            this.buttonTabelaEmprestimo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonTabelaEmprestimo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabelaEmprestimo.Location = new System.Drawing.Point(718, 739);
            this.buttonTabelaEmprestimo.Name = "buttonTabelaEmprestimo";
            this.buttonTabelaEmprestimo.Size = new System.Drawing.Size(411, 47);
            this.buttonTabelaEmprestimo.TabIndex = 8;
            this.buttonTabelaEmprestimo.Text = "Visualizar tabela detalhada de empréstimo";
            this.buttonTabelaEmprestimo.UseVisualStyleBackColor = false;
            this.buttonTabelaEmprestimo.Click += new System.EventHandler(this.buttonTabelaEmprestimo_Click);
            // 
            // dataGridViewLivrosEmAtraso
            // 
            this.dataGridViewLivrosEmAtraso.AllowUserToAddRows = false;
            this.dataGridViewLivrosEmAtraso.AllowUserToDeleteRows = false;
            this.dataGridViewLivrosEmAtraso.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewLivrosEmAtraso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLivrosEmAtraso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLivrosEmAtraso.Location = new System.Drawing.Point(717, 503);
            this.dataGridViewLivrosEmAtraso.Name = "dataGridViewLivrosEmAtraso";
            this.dataGridViewLivrosEmAtraso.ReadOnly = true;
            this.dataGridViewLivrosEmAtraso.RowHeadersWidth = 51;
            this.dataGridViewLivrosEmAtraso.RowTemplate.Height = 24;
            this.dataGridViewLivrosEmAtraso.Size = new System.Drawing.Size(850, 214);
            this.dataGridViewLivrosEmAtraso.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(714, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Exemplares em atraso";
            // 
            // UC_Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewLivrosEmAtraso);
            this.Controls.Add(this.buttonTabelaEmprestimo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartEstadoLivro);
            this.Controls.Add(this.chartLivroDisponibilidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.chartEmprestimo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Relatorios";
            this.Size = new System.Drawing.Size(1603, 828);
            ((System.ComponentModel.ISupportInitialize)(this.chartEmprestimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLivroDisponibilidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadoLivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivrosEmAtraso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEmprestimo;
        private System.Windows.Forms.Button buttonExportar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLivroDisponibilidade;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEstadoLivro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTabelaEmprestimo;
        private System.Windows.Forms.DataGridView dataGridViewLivrosEmAtraso;
        private System.Windows.Forms.Label label4;
    }
}
