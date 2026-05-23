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

namespace AtividadeExtra
{
    public partial class Form1 : Form
    {
        double[,] compras = new double[7, 5];
        double[] TotalporDia = new double[7];
        double TotalGeral;
        string[] DiaSemana = {"Segunda", "Terça", "Quarta", "Quinta", "Sexta"
                            , "Sábado", "Domingo"};
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Armazenar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++) {
                
                for (int j = 0; j < 5; j++) {
                    string input = Interaction.InputBox($"Digite o valor da Compra {j+1} de {DiaSemana[i]}");

                    if (!double.TryParse(input, out compras[i, j]))
                    {
                        MessageBox.Show("Apenas valores numéricos são aceitos");
                        j--;
                    }
                    TotalporDia[i] += compras[i, j];                    
                }
                TotalGeral += TotalporDia[i];
            }


            for (int k = 0; k < 7; k++)
            {
                lstBox_Valores.Items.Add($"{DiaSemana[k]}: {TotalporDia[k]}");
            }

            lstBox_Valores.Items.Add($"Total geral: {TotalGeral}");
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            lstBox_Valores.Items.Clear();
            Array.Clear(compras, 0, compras.Length);
            Array.Clear(TotalporDia, 0, TotalporDia.Length);
            TotalGeral = 0;
        }
    }
}
