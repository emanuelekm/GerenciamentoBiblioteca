namespace GerenciamentoBiblioteca
{
    partial class UC_Emprestimo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxLeitor = new System.Windows.Forms.ComboBox();
            this.comboBoxLivro = new System.Windows.Forms.ComboBox();
            this.dtpEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.buttonConfirmarEmprestimo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewEmprestimo = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxLeitor
            // 
            this.comboBoxLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLeitor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLeitor.FormattingEnabled = true;
            this.comboBoxLeitor.Location = new System.Drawing.Point(215, 87);
            this.comboBoxLeitor.Name = "comboBoxLeitor";
            this.comboBoxLeitor.Size = new System.Drawing.Size(831, 27);
            this.comboBoxLeitor.TabIndex = 0;
            // 
            // comboBoxLivro
            // 
            this.comboBoxLivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLivro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLivro.FormattingEnabled = true;
            this.comboBoxLivro.Location = new System.Drawing.Point(214, 128);
            this.comboBoxLivro.Name = "comboBoxLivro";
            this.comboBoxLivro.Size = new System.Drawing.Size(832, 27);
            this.comboBoxLivro.TabIndex = 1;
            // 
            // dtpEmprestimo
            // 
            this.dtpEmprestimo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmprestimo.Location = new System.Drawing.Point(215, 171);
            this.dtpEmprestimo.Name = "dtpEmprestimo";
            this.dtpEmprestimo.Size = new System.Drawing.Size(831, 26);
            this.dtpEmprestimo.TabIndex = 2;
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevolucao.Location = new System.Drawing.Point(214, 215);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(832, 26);
            this.dtpDevolucao.TabIndex = 3;
            // 
            // buttonConfirmarEmprestimo
            // 
            this.buttonConfirmarEmprestimo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmarEmprestimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(8)))), ((int)(((byte)(67)))));
            this.buttonConfirmarEmprestimo.Location = new System.Drawing.Point(661, 259);
            this.buttonConfirmarEmprestimo.Name = "buttonConfirmarEmprestimo";
            this.buttonConfirmarEmprestimo.Size = new System.Drawing.Size(261, 46);
            this.buttonConfirmarEmprestimo.TabIndex = 4;
            this.buttonConfirmarEmprestimo.Text = "Confirmar Empréstimo";
            this.buttonConfirmarEmprestimo.UseVisualStyleBackColor = true;
            this.buttonConfirmarEmprestimo.Click += new System.EventHandler(this.buttonConfirmarEmprestimo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(8)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Realizar Empréstimo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuário Leitor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Livros Disponíveis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data do Empréstimo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data de Devolução:";
            // 
            // dataGridViewEmprestimo
            // 
            this.dataGridViewEmprestimo.AllowUserToAddRows = false;
            this.dataGridViewEmprestimo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewEmprestimo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmprestimo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.dataGridViewEmprestimo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmprestimo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmprestimo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEmprestimo.Location = new System.Drawing.Point(30, 390);
            this.dataGridViewEmprestimo.Name = "dataGridViewEmprestimo";
            this.dataGridViewEmprestimo.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmprestimo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEmprestimo.RowHeadersWidth = 62;
            this.dataGridViewEmprestimo.RowTemplate.Height = 28;
            this.dataGridViewEmprestimo.Size = new System.Drawing.Size(1015, 278);
            this.dataGridViewEmprestimo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(27, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(295, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tabela com Resumos de Empréstimos";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(8)))), ((int)(((byte)(67)))));
            this.buttonLimpar.Location = new System.Drawing.Point(928, 259);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(118, 46);
            this.buttonLimpar.TabIndex = 14;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // UC_Emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewEmprestimo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConfirmarEmprestimo);
            this.Controls.Add(this.dtpDevolucao);
            this.Controls.Add(this.dtpEmprestimo);
            this.Controls.Add(this.comboBoxLivro);
            this.Controls.Add(this.comboBoxLeitor);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Emprestimo";
            this.Size = new System.Drawing.Size(1076, 691);
            this.Load += new System.EventHandler(this.UCEmprestimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprestimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLeitor;
        private System.Windows.Forms.ComboBox comboBoxLivro;
        private System.Windows.Forms.DateTimePicker dtpEmprestimo;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.Button buttonConfirmarEmprestimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewEmprestimo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonLimpar;
    }
}
