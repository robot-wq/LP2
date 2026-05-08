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
using System.Collections;

namespace Atividade6
{
    public partial class Form1 : Form
    {
        string temp;
        int[] vet = new int[20];

        string[,] alunoNotas = new string [20, 3];

        double nota1, nota2, nota3 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Exc1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vet.Length; i++) {
                temp = Interaction.InputBox($"Digite o {i + 1}° número");

                if (!int.TryParse(temp, out vet[i])) {
                    MessageBox.Show("Tipo de dado inválido");
                    i--;
                }
            }

            vet.Reverse();
            temp = "";

            foreach (int i in vet) 
                temp += i + "\n";
            MessageBox.Show(temp);
        }

        private void btn_Exc4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_Exc2>().Count() > 0)
            {
                Application.OpenForms["frmExercicio4"].BringToFront();
            }
            else
            {
                frm_Exc2 frm_Exc2 = new frm_Exc2();
                frm_Exc2.WindowState = FormWindowState.Normal;
                frm_Exc2.Show();
            }
        }

        private void btn_Exc5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_Exc3>().Count() > 0)
            {
                Application.OpenForms["frmExercicio3"].BringToFront();
            }
            else
            {
                frm_Exc3 frm_Exc3 = new frm_Exc3();
                frm_Exc3.WindowState = FormWindowState.Normal;
                frm_Exc3.Show();
            }
        }

        private void btn_Exc2_Click(object sender, EventArgs e)
        {
            ArrayList alunos = new ArrayList()
        {
            "Ana", "André", "beatriz", "Camila", "João",
            "Joana", "Otávio", "Marcelo", "Pedro", "Thaís"
        };
            alunos.RemoveAt(6);
            string msg = string.Join("\n", alunos.ToArray());

            MessageBox.Show(msg);
        }

        private void btn_Exc3_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < 20; i++) {
                double media = 0;
                for (int j = 0; j < 3; j++) {
                    alunoNotas[i, j] = Interaction.InputBox($"Digite a nota da disciplina {j + 1} do aluno {i + 1}: ");
                    
                    if (j == 0)
                    {
                        nota1 = double.Parse(alunoNotas[i, j]);
                        if (nota1 > 10 || nota1 < 0)
                        {
                            MessageBox.Show("Valor inválido, tente novamente");
                            j--;
                        }
                    }

                    else if (j == 1)
                    {
                        nota2 = double.Parse(alunoNotas[i, j]);
                        if (nota2 > 10 || nota2 < 0)
                        {
                            MessageBox.Show("Valor inválido, tente novamente");
                            j--;
                        }
                    }
                    else if (j == 2)
                    {
                        nota3 = double.Parse(alunoNotas[i, j]);
                        if (nota3 > 10 || nota3 < 0)
                        {
                            MessageBox.Show("Valor inválido, tente novamente");
                            j--;
                        }
                    }

                }
                media = (nota1 + nota2 + nota3) / 3;

                MessageBox.Show($"Aluno: {i+1} Media: {media:f2}");
            }
        }
    }
}
