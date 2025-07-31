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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.dataGridViewPesquisar = new System.Windows.Forms.DataGridView();
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::GerenciamentoBiblioteca.Properties.Resources.icons8_pesquisar_64;
            this.pictureBox1.Location = new System.Drawing.Point(979, 94);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Bom",
            "Regular",
            "Ruim"});
            this.comboBoxStatus.Location = new System.Drawing.Point(716, 95);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(102, 27);
            this.comboBoxStatus.TabIndex = 6;
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGenero.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGenero.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Location = new System.Drawing.Point(482, 94);
            this.comboBoxGenero.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(219, 27);
            this.comboBoxGenero.TabIndex = 5;
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPesquisar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPesquisar.Location = new System.Drawing.Point(23, 94);
            this.textBoxPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPesquisar.Multiline = true;
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(443, 27);
            this.textBoxPesquisar.TabIndex = 0;
            this.textBoxPesquisar.TextChanged += new System.EventHandler(this.textBoxPesquisar_TextChanged_1);
            // 
            // dataGridViewPesquisar
            // 
            this.dataGridViewPesquisar.AllowUserToAddRows = false;
            this.dataGridViewPesquisar.AllowUserToDeleteRows = false;
            this.dataGridViewPesquisar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.dataGridViewPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesquisar.Location = new System.Drawing.Point(23, 135);
            this.dataGridViewPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            this.dataGridViewPesquisar.ReadOnly = true;
            this.dataGridViewPesquisar.RowHeadersWidth = 62;
            this.dataGridViewPesquisar.RowTemplate.Height = 28;
            this.dataGridViewPesquisar.Size = new System.Drawing.Size(980, 481);
            this.dataGridViewPesquisar.TabIndex = 1;
            // 
            // textBoxAno
            // 
            this.textBoxAno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAno.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAno.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxAno.Location = new System.Drawing.Point(833, 94);
            this.textBoxAno.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAno.Multiline = true;
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(130, 27);
            this.textBoxAno.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(8)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisa de acervo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxAno);
            this.panel2.Controls.Add(this.dataGridViewPesquisar);
            this.panel2.Controls.Add(this.textBoxPesquisar);
            this.panel2.Controls.Add(this.comboBoxGenero);
            this.panel2.Controls.Add(this.comboBoxStatus);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 689);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gênero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(712, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(829, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ano de publicação";
            // 
            // UC_PesquisarAcervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_PesquisarAcervo";
            this.Size = new System.Drawing.Size(1063, 689);
            this.Load += new System.EventHandler(this.UC_PesquisarAcervo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewPesquisar;
        private System.Windows.Forms.TextBox textBoxAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
