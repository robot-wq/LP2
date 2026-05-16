using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Atividade6
{
    public partial class frm_Exc2 : Form
    {
        string[] nomes = new string[10];
        int comprimento;
        public frm_Exc2()
        {
            InitializeComponent();
        }

        private void btn_Executar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) {
                nomes[i] = Interaction.InputBox($"Digite o {i + 1}° nome");

                if (string.IsNullOrEmpty(nomes[i]))
                {
                    MessageBox.Show("nome vazio");
                    i--;
                }
            }

            for (int j = 0; j < 10; j++) {
                comprimento = nomes[j].Replace(" ", "").Length; 
                lstbx_Valores.Items.Add($"O nome: {nomes[j]} possui {comprimento} caracteres");
            }
        }
    }
}
