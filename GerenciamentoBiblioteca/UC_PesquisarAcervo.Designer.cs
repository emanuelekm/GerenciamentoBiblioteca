namespace GerenciamentoBiblioteca
{
    partial class UC_PesquisarAcervo
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
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.dataGridViewPesquisar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPesquisar.Location = new System.Drawing.Point(6, 61);
            this.textBoxPesquisar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(443, 26);
            this.textBoxPesquisar.TabIndex = 0;
            this.textBoxPesquisar.Text = "Título";
            this.textBoxPesquisar.TextChanged += new System.EventHandler(this.textBoxPesquisar_TextChanged_1);
            // 
            // dataGridViewPesquisar
            // 
            this.dataGridViewPesquisar.AllowUserToAddRows = false;
            this.dataGridViewPesquisar.AllowUserToDeleteRows = false;
            this.dataGridViewPesquisar.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesquisar.Location = new System.Drawing.Point(24, 25);
            this.dataGridViewPesquisar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            this.dataGridViewPesquisar.ReadOnly = true;
            this.dataGridViewPesquisar.RowHeadersWidth = 62;
            this.dataGridViewPesquisar.RowTemplate.Height = 28;
            this.dataGridViewPesquisar.Size = new System.Drawing.Size(1014, 539);
            this.dataGridViewPesquisar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisa de acervo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::GerenciamentoBiblioteca.Properties.Resources.icons8_pesquisar_24;
            this.pictureBox1.Location = new System.Drawing.Point(932, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGenero.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Location = new System.Drawing.Point(465, 61);
            this.comboBoxGenero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(219, 27);
            this.comboBoxGenero.TabIndex = 5;
            this.comboBoxGenero.Text = "Gênero";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Bom",
            "Regular",
            "Ruim"});
            this.comboBoxStatus.Location = new System.Drawing.Point(699, 62);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(102, 27);
            this.comboBoxStatus.TabIndex = 6;
            this.comboBoxStatus.Text = "Estado";
            // 
            // textBoxAno
            // 
            this.textBoxAno.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAno.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxAno.Location = new System.Drawing.Point(813, 61);
            this.textBoxAno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(102, 26);
            this.textBoxAno.TabIndex = 7;
            this.textBoxAno.Text = "Ano";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxAno);
            this.panel1.Controls.Add(this.textBoxPesquisar);
            this.panel1.Controls.Add(this.comboBoxStatus);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.comboBoxGenero);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 100);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewPesquisar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 589);
            this.panel2.TabIndex = 9;
            // 
            // UC_PesquisarAcervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_PesquisarAcervo";
            this.Size = new System.Drawing.Size(1063, 689);
            this.Load += new System.EventHandler(this.UC_PesquisarAcervo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox textBoxAno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
