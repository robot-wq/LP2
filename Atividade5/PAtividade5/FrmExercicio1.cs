using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade5
{

    public partial class FrmExercicio1 : Form
    {
        string texto;
        int totEspacos = 0;
        int totR = 0;
        int totPar = 0;
        public FrmExercicio1()
        {
            InitializeComponent();
        }

        private void btn_Espacos_Click(object sender, EventArgs e)
        {
            totEspacos = 0;
            foreach (char c in rchtxt_Texto.Text)
            {
                if (c == ' ' || c == '\t')
                {
                    totEspacos++;
                }
            }

            MessageBox.Show($"O total de espaços encontrados no texto foi {totEspacos}");
        }

        private void btn_TotalR_Click(object sender, EventArgs e)
        {
            totR = 0;
            foreach (char r in rchtxt_Texto.Text) {
                if (Char.ToLower(r) == 'r') {
                    totR++;
                }
            }

            MessageBox.Show($"O total de letras R encontradas no texto é {totR}");
        }

        private void btn_Pares_Click(object sender, EventArgs e)
        {
            totPar = 0;
            for (int i = 0; i < rchtxt_Texto.Text.Length - 1; i++) {
                char k = rchtxt_Texto.Text[i];
                if (k == rchtxt_Texto.Text[i + 1]) {
                    totPar++;
                }

                
            }

            MessageBox.Show($"O total de pares de letras seguidas é: {totPar}");

        }
        }
    }

