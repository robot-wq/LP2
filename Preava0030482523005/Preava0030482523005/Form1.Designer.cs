namespace Preava0030482523005
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
            this.btnexecutar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnexecutar
            // 
            this.btnexecutar.Location = new System.Drawing.Point(59, 30);
            this.btnexecutar.Name = "btnexecutar";
            this.btnexecutar.Size = new System.Drawing.Size(179, 124);
            this.btnexecutar.TabIndex = 0;
            this.btnexecutar.Text = "executar";
            this.btnexecutar.UseVisualStyleBackColor = true;
            this.btnexecutar.Click += new System.EventHandler(this.btnexecutar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(59, 236);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(179, 96);
            this.btn_limpar.TabIndex = 1;
            this.btn_limpar.Text = "limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
//            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(435, 30);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(283, 293);
            this.txtresultado.TabIndex = 3;
            this.txtresultado.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btnexecutar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexecutar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.RichTextBox txtresultado;
    }
}

