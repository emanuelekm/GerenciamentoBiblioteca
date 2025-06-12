namespace GerenciamentoBiblioteca
{
    partial class FormPrincipalLeitor
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
            this.labelBemVindo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBemVindo
            // 
            this.labelBemVindo.AutoSize = true;
            this.labelBemVindo.Location = new System.Drawing.Point(360, 175);
            this.labelBemVindo.Name = "labelBemVindo";
            this.labelBemVindo.Size = new System.Drawing.Size(51, 20);
            this.labelBemVindo.TabIndex = 0;
            this.labelBemVindo.Text = "label1";
            // 
            // FormPrincipalLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBemVindo);
            this.Name = "FormPrincipalLeitor";
            this.Text = "FormPrincipalLeitor";
            this.Load += new System.EventHandler(this.FormPrincipalLeitor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBemVindo;
    }
}