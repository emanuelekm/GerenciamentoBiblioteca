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
            this.labelResumo = new System.Windows.Forms.Label();
            this.dataGridViewEmprestimo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprestimo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxLeitor
            // 
            this.comboBoxLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxLeitor.FormattingEnabled = true;
            this.comboBoxLeitor.Location = new System.Drawing.Point(242, 110);
            this.comboBoxLeitor.Name = "comboBoxLeitor";
            this.comboBoxLeitor.Size = new System.Drawing.Size(647, 28);
            this.comboBoxLeitor.TabIndex = 0;
            // 
            // comboBoxLivro
            // 
            this.comboBoxLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxLivro.FormattingEnabled = true;
            this.comboBoxLivro.Location = new System.Drawing.Point(241, 160);
            this.comboBoxLivro.Name = "comboBoxLivro";
            this.comboBoxLivro.Size = new System.Drawing.Size(648, 28);
            this.comboBoxLivro.TabIndex = 1;
            // 
            // dtpEmprestimo
            // 
            this.dtpEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtpEmprestimo.Location = new System.Drawing.Point(242, 214);
            this.dtpEmprestimo.Name = "dtpEmprestimo";
            this.dtpEmprestimo.Size = new System.Drawing.Size(647, 26);
            this.dtpEmprestimo.TabIndex = 2;
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtpDevolucao.Location = new System.Drawing.Point(241, 267);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(648, 26);
            this.dtpDevolucao.TabIndex = 3;
            // 
            // buttonConfirmarEmprestimo
            // 
            this.buttonConfirmarEmprestimo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmarEmprestimo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConfirmarEmprestimo.Location = new System.Drawing.Point(32, 336);
            this.buttonConfirmarEmprestimo.Name = "buttonConfirmarEmprestimo";
            this.buttonConfirmarEmprestimo.Size = new System.Drawing.Size(325, 53);
            this.buttonConfirmarEmprestimo.TabIndex = 4;
            this.buttonConfirmarEmprestimo.Text = "Confirmar Empréstimo";
            this.buttonConfirmarEmprestimo.UseVisualStyleBackColor = true;
            this.buttonConfirmarEmprestimo.Click += new System.EventHandler(this.buttonConfirmarEmprestimo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Realizar Empréstimo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(27, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuário Leitor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(27, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Livros Disponíveis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(27, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data do Empréstimo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(27, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data de Devolução";
            // 
            // labelResumo
            // 
            this.labelResumo.AutoSize = true;
            this.labelResumo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelResumo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResumo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelResumo.Location = new System.Drawing.Point(24, 57);
            this.labelResumo.Name = "labelResumo";
            this.labelResumo.Size = new System.Drawing.Size(0, 21);
            this.labelResumo.TabIndex = 10;
            // 
            // dataGridViewEmprestimo
            // 
            this.dataGridViewEmprestimo.AllowUserToAddRows = false;
            this.dataGridViewEmprestimo.AllowUserToDeleteRows = false;
            this.dataGridViewEmprestimo.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewEmprestimo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmprestimo.Location = new System.Drawing.Point(31, 480);
            this.dataGridViewEmprestimo.Name = "dataGridViewEmprestimo";
            this.dataGridViewEmprestimo.ReadOnly = true;
            this.dataGridViewEmprestimo.RowHeadersWidth = 62;
            this.dataGridViewEmprestimo.RowTemplate.Height = 28;
            this.dataGridViewEmprestimo.Size = new System.Drawing.Size(1420, 341);
            this.dataGridViewEmprestimo.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelResumo);
            this.panel1.Location = new System.Drawing.Point(933, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 189);
            this.panel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(24, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Resumo do empréstimo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(27, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tabela de Empréstimos";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(725, 336);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(164, 53);
            this.buttonLimpar.TabIndex = 14;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // UC_Emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
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
            this.Name = "UC_Emprestimo";
            this.Size = new System.Drawing.Size(1550, 881);
            this.Load += new System.EventHandler(this.UCEmprestimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprestimo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label labelResumo;
        private System.Windows.Forms.DataGridView dataGridViewEmprestimo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonLimpar;
    }
}
