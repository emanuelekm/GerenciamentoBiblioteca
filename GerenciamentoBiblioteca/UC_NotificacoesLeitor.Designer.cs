namespace GerenciamentoBiblioteca
{
    partial class UC_NotificacoesLeitor
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
            this.flowNotificacoes = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowNotificacoes
            // 
            this.flowNotificacoes.AutoScroll = true;
            this.flowNotificacoes.BackColor = System.Drawing.SystemColors.Window;
            this.flowNotificacoes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowNotificacoes.Location = new System.Drawing.Point(27, 69);
            this.flowNotificacoes.Margin = new System.Windows.Forms.Padding(2);
            this.flowNotificacoes.Name = "flowNotificacoes";
            this.flowNotificacoes.Size = new System.Drawing.Size(994, 565);
            this.flowNotificacoes.TabIndex = 6;
            this.flowNotificacoes.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Notificações";
            // 
            // UC_NotificacoesLeitor
            // 
            this.Controls.Add(this.flowNotificacoes);
            this.Controls.Add(this.label1);
            this.Name = "UC_NotificacoesLeitor";
            this.Size = new System.Drawing.Size(1043, 756);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.FlowLayoutPanel flowNotificacoes;
        private System.Windows.Forms.Label label1;

        #endregion

        //private System.Windows.Forms.Label label1;
        // private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.PictureBox pictureBox1;
        //private System.Windows.Forms.Panel panelLixeira;
        //private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.PictureBox pictureBox2;
        // private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLixeira;
        //private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}
