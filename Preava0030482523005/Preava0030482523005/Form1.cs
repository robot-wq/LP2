using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preava0030482523005
{
    public partial class Form1 : Form
    {
        Double MatrizA, MatrizB;
        public Form1()

        {
            InitializeComponent();
        }

        

        private void btnexecutar_Click(object sender, EventArgs e)
        {
            if (MatrizA < (MatrizB + 4) && (MatrizA > (Math.Abs(MatrizB * 4))
                    && MatrizB < (MatrizA + 4)) && (MatrizB > (Math.Abs(MatrizA * MatrizB))
                    && (4 < (MatrizA + MatrizB)) && (4 > Math.Abs(MatrizA * MatrizB)))) ;

            if (MatrizA == MatrizB && MatrizA == 4)
            {
                MessageBox.Show("Posição 0");
            }
            else if (MatrizA == MatrizB && MatrizA != 4 ||
                MatrizA == MatrizB && MatrizA != MatrizB ||
                MatrizB == MatrizA && MatrizB != MatrizA)
            {
                MessageBox.Show("Posição 1");
            }
            else
            {
                MessageBox.Show("Posição 2");
            }
            
        }
    }
}
