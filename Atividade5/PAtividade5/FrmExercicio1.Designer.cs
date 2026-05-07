namespace PAtividade5
{
    partial class FrmExercicio1
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
            this.rchtxt_Texto = new System.Windows.Forms.RichTextBox();
            this.btn_Espacos = new System.Windows.Forms.Button();
            this.btn_TotalR = new System.Windows.Forms.Button();
            this.btn_Pares = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxt_Texto
            // 
            this.rchtxt_Texto.Location = new System.Drawing.Point(87, 81);
            this.rchtxt_Texto.Name = "rchtxt_Texto";
            this.rchtxt_Texto.Size = new System.Drawing.Size(275, 256);
            this.rchtxt_Texto.TabIndex = 0;
            this.rchtxt_Texto.Text = "";
            // 
            // btn_Espacos
            // 
            this.btn_Espacos.Location = new System.Drawing.Point(434, 83);
            this.btn_Espacos.Name = "btn_Espacos";
            this.btn_Espacos.Size = new System.Drawing.Size(226, 59);
            this.btn_Espacos.TabIndex = 1;
            this.btn_Espacos.Text = "Total de espaços";
            this.btn_Espacos.UseVisualStyleBackColor = true;
            this.btn_Espacos.Click += new System.EventHandler(this.btn_Espacos_Click);
            // 
            // btn_TotalR
            // 
            this.btn_TotalR.Location = new System.Drawing.Point(434, 177);
            this.btn_TotalR.Name = "btn_TotalR";
            this.btn_TotalR.Size = new System.Drawing.Size(226, 59);
            this.btn_TotalR.TabIndex = 2;
            this.btn_TotalR.Text = "Total de letras \"R\"";
            this.btn_TotalR.UseVisualStyleBackColor = true;
            this.btn_TotalR.Click += new System.EventHandler(this.btn_TotalR_Click);
            // 
            // btn_Pares
            // 
            this.btn_Pares.Location = new System.Drawing.Point(434, 278);
            this.btn_Pares.Name = "btn_Pares";
            this.btn_Pares.Size = new System.Drawing.Size(226, 59);
            this.btn_Pares.TabIndex = 3;
            this.btn_Pares.Text = "Total de pares";
            this.btn_Pares.UseVisualStyleBackColor = true;
            this.btn_Pares.Click += new System.EventHandler(this.btn_Pares_Click);
            // 
            // FrmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Pares);
            this.Controls.Add(this.btn_TotalR);
            this.Controls.Add(this.btn_Espacos);
            this.Controls.Add(this.rchtxt_Texto);
            this.Name = "FrmExercicio1";
            this.Text = "FrmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxt_Texto;
        private System.Windows.Forms.Button btn_Espacos;
        private System.Windows.Forms.Button btn_TotalR;
        private System.Windows.Forms.Button btn_Pares;
    }
}