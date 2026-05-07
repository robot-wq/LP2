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
    public partial class FrmExercicio4 : Form
    {
        int producao;
        public FrmExercicio4()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double A, gratificacoes;
            int producao;

            if (!double.TryParse(txt_Salario.Text, out A))
            {
                MessageBox.Show("Salário do cargo (A) deve ser um número válido.");
                return;
            }
            if (!int.TryParse(txt_Producao.Text, out producao))
            {
                MessageBox.Show("Produção deve ser um número inteiro.");
                return;
            }
            if (!double.TryParse(txt_Gratificacao.Text, out gratificacoes))
            {
                MessageBox.Show("Gratificações deve ser um número válido.");
                return;
            }

            int B = (producao >= 100) ? 1 : 0;
            int C = (producao >= 120) ? 1 : 0;
            int D = (producao >= 150) ? 1 : 0;

            double salarioBruto = A + A * (0.05 * B + 0.1 * C + 0.1 * D) + gratificacoes;

            double teto = 7000.00;
            if (salarioBruto > teto)
            {
                if (!(producao >= 150 && gratificacoes > 0))
                {
                    salarioBruto = teto;
                }
            }

            MessageBox.Show($"Salário bruto final do funcionário {txt_Nome.Text} com matrícula {txt_Matricula.Text} é: {salarioBruto:C2}\n");
        }
    }
}
