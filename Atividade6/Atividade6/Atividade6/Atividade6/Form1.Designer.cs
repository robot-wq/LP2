namespace Atividade6
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
            this.btn_Exc1 = new System.Windows.Forms.Button();
            this.btn_Exc2 = new System.Windows.Forms.Button();
            this.btn_Exc3 = new System.Windows.Forms.Button();
            this.btn_Exc4 = new System.Windows.Forms.Button();
            this.btn_Exc5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Exc1
            // 
            this.btn_Exc1.Location = new System.Drawing.Point(160, 30);
            this.btn_Exc1.Name = "btn_Exc1";
            this.btn_Exc1.Size = new System.Drawing.Size(198, 123);
            this.btn_Exc1.TabIndex = 0;
            this.btn_Exc1.Text = "Exercício 1";
            this.btn_Exc1.UseVisualStyleBackColor = true;
            this.btn_Exc1.Click += new System.EventHandler(this.btn_Exc1_Click);
            // 
            // btn_Exc2
            // 
            this.btn_Exc2.Location = new System.Drawing.Point(459, 30);
            this.btn_Exc2.Name = "btn_Exc2";
            this.btn_Exc2.Size = new System.Drawing.Size(198, 123);
            this.btn_Exc2.TabIndex = 1;
            this.btn_Exc2.Text = "Exercício 2";
            this.btn_Exc2.UseVisualStyleBackColor = true;
            this.btn_Exc2.Click += new System.EventHandler(this.btn_Exc2_Click);
            // 
            // btn_Exc3
            // 
            this.btn_Exc3.Location = new System.Drawing.Point(160, 188);
            this.btn_Exc3.Name = "btn_Exc3";
            this.btn_Exc3.Size = new System.Drawing.Size(198, 123);
            this.btn_Exc3.TabIndex = 2;
            this.btn_Exc3.Text = "Exercício 3";
            this.btn_Exc3.UseVisualStyleBackColor = true;
            this.btn_Exc3.Click += new System.EventHandler(this.btn_Exc3_Click);
            // 
            // btn_Exc4
            // 
            this.btn_Exc4.Location = new System.Drawing.Point(459, 188);
            this.btn_Exc4.Name = "btn_Exc4";
            this.btn_Exc4.Size = new System.Drawing.Size(198, 123);
            this.btn_Exc4.TabIndex = 3;
            this.btn_Exc4.Text = "Exercício 4";
            this.btn_Exc4.UseVisualStyleBackColor = true;
            this.btn_Exc4.Click += new System.EventHandler(this.btn_Exc4_Click);
            // 
            // btn_Exc5
            // 
            this.btn_Exc5.Location = new System.Drawing.Point(311, 317);
            this.btn_Exc5.Name = "btn_Exc5";
            this.btn_Exc5.Size = new System.Drawing.Size(198, 123);
            this.btn_Exc5.TabIndex = 4;
            this.btn_Exc5.Text = "Exercício 5";
            this.btn_Exc5.UseVisualStyleBackColor = true;
            this.btn_Exc5.Click += new System.EventHandler(this.btn_Exc5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Exc5);
            this.Controls.Add(this.btn_Exc4);
            this.Controls.Add(this.btn_Exc3);
            this.Controls.Add(this.btn_Exc2);
            this.Controls.Add(this.btn_Exc1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Exc1;
        private System.Windows.Forms.Button btn_Exc2;
        private System.Windows.Forms.Button btn_Exc3;
        private System.Windows.Forms.Button btn_Exc4;
        private System.Windows.Forms.Button btn_Exc5;
    }
}

