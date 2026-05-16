namespace Atividade6
{
    partial class frm_Exc3
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
            this.btn_Executar = new System.Windows.Forms.Button();
            this.lst_Verificador = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Executar
            // 
            this.btn_Executar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Executar.Location = new System.Drawing.Point(89, 154);
            this.btn_Executar.Name = "btn_Executar";
            this.btn_Executar.Size = new System.Drawing.Size(242, 124);
            this.btn_Executar.TabIndex = 0;
            this.btn_Executar.Text = "Executar";
            this.btn_Executar.UseVisualStyleBackColor = true;
            this.btn_Executar.Click += new System.EventHandler(this.btn_Executar_Click);
            // 
            // lst_Verificador
            // 
            this.lst_Verificador.FormattingEnabled = true;
            this.lst_Verificador.Location = new System.Drawing.Point(395, 66);
            this.lst_Verificador.Name = "lst_Verificador";
            this.lst_Verificador.Size = new System.Drawing.Size(307, 303);
            this.lst_Verificador.TabIndex = 1;
            // 
            // frm_Exc3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_Verificador);
            this.Controls.Add(this.btn_Executar);
            this.Name = "frm_Exc3";
            this.Text = "frm_Exc3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Executar;
        private System.Windows.Forms.ListBox lst_Verificador;
    }
}