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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmprestimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLivroDisponibilidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadoLivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivrosEmAtraso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(8)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatório de Empréstimos e Devoluções";
            // 
            // chartEmprestimo
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEmprestimo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEmprestimo.Legends.Add(legend1);
            this.chartEmprestimo.Location = new System.Drawing.Point(32, 115);
            this.chartEmprestimo.Margin = new System.Windows.Forms.Padding(2);
            this.chartEmprestimo.Name = "chartEmprestimo";
            this.chartEmprestimo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEmprestimo.Series.Add(series1);
            this.chartEmprestimo.Size = new System.Drawing.Size(487, 523);
            this.chartEmprestimo.TabIndex = 1;
            this.chartEmprestimo.Text = "Relação de empréstimos e devoluções";
            this.chartEmprestimo.UseWaitCursor = true;
            // 
            // buttonExportar
            // 
            this.buttonExportar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(8)))), ((int)(((byte)(67)))));
            this.buttonExportar.Location = new System.Drawing.Point(1016, 23);
            this.buttonExportar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(168, 68);
            this.buttonExportar.TabIndex = 3;
            this.buttonExportar.Text = "Exportar dados gráficos em PDF";
            this.buttonExportar.UseVisualStyleBackColor = true;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(590, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade de empréstimos e devoluções de acordo com os estados em tempo real";
            // 
            // chartLivroDisponibilidade
            // 
            chartArea2.Name = "ChartArea1";
            this.chartLivroDisponibilidade.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartLivroDisponibilidade.Legends.Add(legend2);
            this.chartLivroDisponibilidade.Location = new System.Drawing.Point(538, 115);
            this.chartLivroDisponibilidade.Margin = new System.Windows.Forms.Padding(2);
            this.chartLivroDisponibilidade.Name = "chartLivroDisponibilidade";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartLivroDisponibilidade.Series.Add(series2);
            this.chartLivroDisponibilidade.Size = new System.Drawing.Size(308, 249);
            this.chartLivroDisponibilidade.TabIndex = 5;
            this.chartLivroDisponibilidade.Text = "chart1";
            // 
            // chartEstadoLivro
            // 
            chartArea3.Name = "ChartArea1";
            this.chartEstadoLivro.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartEstadoLivro.Legends.Add(legend3);
            this.chartEstadoLivro.Location = new System.Drawing.Point(868, 115);
            this.chartEstadoLivro.Margin = new System.Windows.Forms.Padding(2);
            this.chartEstadoLivro.Name = "chartEstadoLivro";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartEstadoLivro.Series.Add(series3);
            this.chartEstadoLivro.Size = new System.Drawing.Size(308, 249);
            this.chartEstadoLivro.TabIndex = 6;
            this.chartEstadoLivro.Text = "Estado dos Livros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(864, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado dos livros";
            // 
            // buttonTabelaEmprestimo
            // 
            this.buttonTabelaEmprestimo.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTabelaEmprestimo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabelaEmprestimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(8)))), ((int)(((byte)(67)))));
            this.buttonTabelaEmprestimo.Location = new System.Drawing.Point(538, 600);
            this.buttonTabelaEmprestimo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTabelaEmprestimo.Name = "buttonTabelaEmprestimo";
            this.buttonTabelaEmprestimo.Size = new System.Drawing.Size(352, 38);
            this.buttonTabelaEmprestimo.TabIndex = 8;
            this.buttonTabelaEmprestimo.Text = "Visualizar tabela detalhada de empréstimo";
            this.buttonTabelaEmprestimo.UseVisualStyleBackColor = false;
            this.buttonTabelaEmprestimo.Click += new System.EventHandler(this.buttonTabelaEmprestimo_Click);
            // 
            // dataGridViewLivrosEmAtraso
            // 
            this.dataGridViewLivrosEmAtraso.AllowUserToAddRows = false;
            this.dataGridViewLivrosEmAtraso.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewLivrosEmAtraso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLivrosEmAtraso.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewLivrosEmAtraso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLivrosEmAtraso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLivrosEmAtraso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLivrosEmAtraso.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewLivrosEmAtraso.Location = new System.Drawing.Point(538, 409);
            this.dataGridViewLivrosEmAtraso.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewLivrosEmAtraso.Name = "dataGridViewLivrosEmAtraso";
            this.dataGridViewLivrosEmAtraso.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLivrosEmAtraso.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewLivrosEmAtraso.RowHeadersWidth = 51;
            this.dataGridViewLivrosEmAtraso.RowTemplate.Height = 24;
            this.dataGridViewLivrosEmAtraso.Size = new System.Drawing.Size(638, 174);
            this.dataGridViewLivrosEmAtraso.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(534, 373);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Exemplares em atraso";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GerenciamentoBiblioteca.Properties.Resources.icons8_voltar_24;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UC_Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.pictureBox1);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Relatorios";
            this.Size = new System.Drawing.Size(1202, 673);
            ((System.ComponentModel.ISupportInitialize)(this.chartEmprestimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLivroDisponibilidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadoLivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivrosEmAtraso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
