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
    public partial class FrmExercicio3 : Form
    {
        string original;
        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void btn_Verificar_Click(object sender, EventArgs e)
        {
            string original = txt_Palavra.Text;
            if (original.Length > 50)
            {
                MessageBox.Show("A frase não pode conter mais que 50 caracteres.");
                return;
            }

            string semEspacos = original.Replace(" ", "");
            string limpa = semEspacos.ToUpper();

            char[] arr = limpa.ToCharArray();
            Array.Reverse(arr);
            string invertida = new string(arr);

            if (limpa == invertida)
                MessageBox.Show($"\"{original}\" é um palíndromo.");
            else
                MessageBox.Show($"\"{original}\" não é um palíndromo.");
        }
    }
    }

