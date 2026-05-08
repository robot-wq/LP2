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
    public partial class frm_Exc3 : Form
    {
        string[,] respostas = new string[6, 10];

        string[] gabarito = new string[10]
        {"A", "C", "B", "E", "A", "E", "B", "C", "D", "D"};
        public frm_Exc3()
        {
            InitializeComponent();
        }

        private void btn_Executar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    respostas[i, j] = Interaction.InputBox($"aluno {i + 1}, digite a alternativa da questão {j + 1}");
                    respostas[i, j] = respostas[i, j].ToUpper();

                    if (respostas[i, j] != "A" && respostas[i, j] != "B" && respostas[i, j] != "C" && respostas[i, j] != "D" &&
                        respostas[i, j] != "E")
                    {
                        MessageBox.Show("Alternativa inválida, tente novamente");
                        j--;
                    }

                }
            }

            for (int k = 0; k < 6; k++) {
                for (int d = 0; d < 10; d++) { 
                    lst_Verificador.Items.Add($"Aluno {k+1} respondeu {gabarito[d]}, escolheu{respostas[k, d]}");
                }
            }
        }
    }
}
