namespace GerenciamentoBiblioteca
{
    partial class UC_Config
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
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelConfig = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(8)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Configurações";
            // 
            // linkLabelConfig
            // 
            this.linkLabelConfig.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabelConfig.AutoSize = true;
            this.linkLabelConfig.BackColor = System.Drawing.SystemColors.Window;
            this.linkLabelConfig.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelConfig.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelConfig.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(8)))), ((int)(((byte)(67)))));
            this.linkLabelConfig.Location = new System.Drawing.Point(132, 220);
            this.linkLabelConfig.Name = "linkLabelConfig";
            this.linkLabelConfig.Size = new System.Drawing.Size(189, 28);
            this.linkLabelConfig.TabIndex = 5;
            this.linkLabelConfig.TabStop = true;
            this.linkLabelConfig.Text = "Manual_de_Uso.pdf";
            this.linkLabelConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelConfig_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 56);
            this.label2.TabIndex = 6;
            this.label2.Text = "Está com dúvidas sbre a utilização do sistema? \r\nBaixe o manual de uso do sistema" +
    "!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GerenciamentoBiblioteca.Properties.Resources.icons8_dúvida_48;
            this.pictureBox1.Location = new System.Drawing.Point(52, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 56);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // UC_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabelConfig);
            this.Controls.Add(this.label1);
            this.Name = "UC_Config";
            this.Size = new System.Drawing.Size(1099, 616);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
