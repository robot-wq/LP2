namespace AtividadeExtra
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
            this.lstBox_Valores = new System.Windows.Forms.ListBox();
            this.btn_Armazenar = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBox_Valores
            // 
            this.lstBox_Valores.FormattingEnabled = true;
            this.lstBox_Valores.ItemHeight = 20;
            this.lstBox_Valores.Location = new System.Drawing.Point(402, 58);
            this.lstBox_Valores.Name = "lstBox_Valores";
            this.lstBox_Valores.Size = new System.Drawing.Size(314, 184);
            this.lstBox_Valores.TabIndex = 0;
            // 
            // btn_Armazenar
            // 
            this.btn_Armazenar.Location = new System.Drawing.Point(157, 58);
            this.btn_Armazenar.Name = "btn_Armazenar";
            this.btn_Armazenar.Size = new System.Drawing.Size(188, 81);
            this.btn_Armazenar.TabIndex = 1;
            this.btn_Armazenar.Text = "Calcular valores";
            this.btn_Armazenar.UseVisualStyleBackColor = true;
            this.btn_Armazenar.Click += new System.EventHandler(this.btn_Armazenar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(157, 164);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(188, 78);
            this.btn_Limpar.TabIndex = 2;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Armazenar);
            this.Controls.Add(this.lstBox_Valores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox_Valores;
        private System.Windows.Forms.Button btn_Armazenar;
        private System.Windows.Forms.Button btn_Limpar;
    }
}

