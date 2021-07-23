
namespace Forms1
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btPf = new System.Windows.Forms.Button();
            this.btPj = new System.Windows.Forms.Button();
            this.lbBemVindo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btPf
            // 
            this.btPf.Location = new System.Drawing.Point(299, 144);
            this.btPf.Name = "btPf";
            this.btPf.Size = new System.Drawing.Size(176, 23);
            this.btPf.TabIndex = 0;
            this.btPf.Text = "Cadastro Pessoa Física";
            this.btPf.UseVisualStyleBackColor = true;
            this.btPf.Click += new System.EventHandler(this.btPf_Click);
            // 
            // btPj
            // 
            this.btPj.Location = new System.Drawing.Point(299, 186);
            this.btPj.Name = "btPj";
            this.btPj.Size = new System.Drawing.Size(176, 23);
            this.btPj.TabIndex = 1;
            this.btPj.Text = "Cadastro Pessoa Jurídica";
            this.btPj.UseVisualStyleBackColor = true;
            this.btPj.Click += new System.EventHandler(this.btPj_Click);
            // 
            // lbBemVindo
            // 
            this.lbBemVindo.AutoSize = true;
            this.lbBemVindo.BackColor = System.Drawing.SystemColors.Menu;
            this.lbBemVindo.Location = new System.Drawing.Point(323, 89);
            this.lbBemVindo.Name = "lbBemVindo";
            this.lbBemVindo.Size = new System.Drawing.Size(124, 13);
            this.lbBemVindo.TabIndex = 2;
            this.lbBemVindo.Text = "Bem-Vindos Havan Labs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 434);
            this.Controls.Add(this.lbBemVindo);
            this.Controls.Add(this.btPj);
            this.Controls.Add(this.btPf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPf;
        private System.Windows.Forms.Button btPj;
        private System.Windows.Forms.Label lbBemVindo;
    }
}

