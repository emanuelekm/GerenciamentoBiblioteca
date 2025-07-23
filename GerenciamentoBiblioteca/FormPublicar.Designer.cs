namespace GerenciamentoBiblioteca
{
    partial class FormPublicar
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
            this.btnPublicar = new System.Windows.Forms.Button();
            this.nudEstrelas = new System.Windows.Forms.NumericUpDown();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.cbLivros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstrelas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.btnPublicar);
            this.panel1.Controls.Add(this.nudEstrelas);
            this.panel1.Controls.Add(this.txtComentario);
            this.panel1.Controls.Add(this.cbLivros);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(27, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 382);
            this.panel1.TabIndex = 5;
            // 
            // btnPublicar
            // 
            this.btnPublicar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnPublicar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicar.Location = new System.Drawing.Point(189, 328);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(126, 40);
            this.btnPublicar.TabIndex = 3;
            this.btnPublicar.Text = "PUBLICAR";
            this.btnPublicar.UseVisualStyleBackColor = false;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // nudEstrelas
            // 
            this.nudEstrelas.Location = new System.Drawing.Point(21, 282);
            this.nudEstrelas.Name = "nudEstrelas";
            this.nudEstrelas.Size = new System.Drawing.Size(469, 25);
            this.nudEstrelas.TabIndex = 2;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(21, 59);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(469, 205);
            this.txtComentario.TabIndex = 1;
            // 
            // cbLivros
            // 
            this.cbLivros.FormattingEnabled = true;
            this.cbLivros.Location = new System.Drawing.Point(21, 21);
            this.cbLivros.Name = "cbLivros";
            this.cbLivros.Size = new System.Drawing.Size(469, 25);
            this.cbLivros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Publicar resenha";
            // 
            // FormPublicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormPublicar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPublicar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstrelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.NumericUpDown nudEstrelas;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.ComboBox cbLivros;
        private System.Windows.Forms.Label label1;
    }
}