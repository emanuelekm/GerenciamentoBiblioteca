namespace GerenciamentoBiblioteca
{
    partial class FormUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalvarUsuario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxTipoUsuario);
            this.panel1.Controls.Add(this.dtpNascimento);
            this.panel1.Controls.Add(this.textBoxTelefone);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxNome);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(34, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 275);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(21, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo do Usuário:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(21, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(21, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data de Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(21, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(21, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome:";
            // 
            // comboBoxTipoUsuario
            // 
            this.comboBoxTipoUsuario.FormattingEnabled = true;
            this.comboBoxTipoUsuario.Location = new System.Drawing.Point(207, 214);
            this.comboBoxTipoUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTipoUsuario.Name = "comboBoxTipoUsuario";
            this.comboBoxTipoUsuario.Size = new System.Drawing.Size(532, 36);
            this.comboBoxTipoUsuario.TabIndex = 5;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Location = new System.Drawing.Point(250, 118);
            this.dtpNascimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(488, 35);
            this.dtpNascimento.TabIndex = 4;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(117, 162);
            this.textBoxTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(621, 35);
            this.textBoxTelefone.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(117, 74);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(622, 35);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(117, 28);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(622, 35);
            this.textBoxNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastrar novos usuários";
            // 
            // buttonSalvarUsuario
            // 
            this.buttonSalvarUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSalvarUsuario.Location = new System.Drawing.Point(343, 374);
            this.buttonSalvarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvarUsuario.Name = "buttonSalvarUsuario";
            this.buttonSalvarUsuario.Size = new System.Drawing.Size(162, 75);
            this.buttonSalvarUsuario.TabIndex = 2;
            this.buttonSalvarUsuario.Text = "SALVAR";
            this.buttonSalvarUsuario.UseVisualStyleBackColor = true;
            this.buttonSalvarUsuario.Click += new System.EventHandler(this.buttonSalvarUsuario_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 471);
            this.Controls.Add(this.buttonSalvarUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalvarUsuario;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.ComboBox comboBoxTipoUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}