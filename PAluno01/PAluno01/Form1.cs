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

namespace PAluno01
{
    public partial class Form1 : Form
    {
        double[,] nota = new double[0, 10];
        double[] média = new double[10];
        double soma;
        string[] professor = { "aluno1", "aluno2", "aluno3" };
        private object lstBox_Valores;

        public Form1()
        {
            InitializeComponent();
        }

        public object Interaction { get; private set; }

        private int GetV()
        {
            return lstnota.Items.Add($"média: {média}");
        }

        private void btnExecutar_Click(object sender, EventArgs e, int v)
        {
            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    string input = ($"Digite o valor da nota {j + 1} de {professor[i]}");

                    if (!double.TryParse(input, out nota[i, j]))
                    {
                        MessageBox.Show("Apenas valores numéricos são aceitos");
                        j--;
                    }
                    média[i] += nota[i, j];
                }
                soma += média[i];
            }


            for (int k = 1; k < 10; k++)
            {
                lstnota.Items.Add($"{média[k]}: {professor[k]}");
            }
        }
               
           
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            btnLimpar.Select();
            Array.Clear(nota, 0, nota.Length);
            Array.Clear(média, 0, média.Length);
            média = null;
        }
    }
}

//obs:não sei porque não está indo a compilação
 