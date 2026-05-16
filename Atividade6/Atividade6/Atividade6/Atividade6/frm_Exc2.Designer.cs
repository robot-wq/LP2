namespace Atividade6
{
    partial class frm_Exc2
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
            this.lstbx_Valores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Executar
            // 
            this.btn_Executar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Executar.Location = new System.Drawing.Point(109, 124);
            this.btn_Executar.Name = "btn_Executar";
            this.btn_Executar.Size = new System.Drawing.Size(199, 105);
            this.btn_Executar.TabIndex = 0;
            this.btn_Executar.Text = "Executar";
            this.btn_Executar.UseVisualStyleBackColor = true;
            this.btn_Executar.Click += new System.EventHandler(this.btn_Executar_Click);
            // 
            // lstbx_Valores
            // 
            this.lstbx_Valores.FormattingEnabled = true;
            this.lstbx_Valores.Location = new System.Drawing.Point(457, 124);
            this.lstbx_Valores.Name = "lstbx_Valores";
            this.lstbx_Valores.Size = new System.Drawing.Size(241, 108);
            this.lstbx_Valores.TabIndex = 1;
            // 
            // frm_Exc2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstbx_Valores);
            this.Controls.Add(this.btn_Executar);
            this.Name = "frm_Exc2";
            this.Text = "frm_Exc2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Executar;
        private System.Windows.Forms.ListBox lstbx_Valores;
    }
}