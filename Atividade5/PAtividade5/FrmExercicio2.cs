using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PAtividade5
{
    public partial class FrmExercicio2 : Form
    {
        double h, n;
        public FrmExercicio2()
        {
            InitializeComponent();
        }

        private void FrmExercicio2_Load(object sender, EventArgs e)
        {

        }

        private void btn_Gerar_Click(object sender, EventArgs e)
        {
            h = 0;
            if (!double.TryParse(txt_Num.Text, out n))
            {
                MessageBox.Show("Este campo aceita apenas números");
                return;
            } else if(n < 0){
                MessageBox.Show("Valores menores que zero não são aceitos");
                return;
            }
            else {
               
                for (int j = 1; j < n; j++) {
                    h += 1.0 / j;
                }
                MessageBox.Show($"O valor de H é: {h:f4}");
            }
        }
    }
}
