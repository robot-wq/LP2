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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExercicio1>().Count() > 0)
            {
                Application.OpenForms["frmExercicio1"].BringToFront();
            }
            else
            {
                FrmExercicio1 FrmExercicio1 = new FrmExercicio1();
                FrmExercicio1.MdiParent = this;
                FrmExercicio1.WindowState = FormWindowState.Maximized;
                FrmExercicio1.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExercicio1>().Count() > 0)
            {
                Application.OpenForms["frmExercicio2"].BringToFront();
            }
            else
            {
                FrmExercicio2 FrmExercicio2 = new FrmExercicio2();
                FrmExercicio2.MdiParent = this;
                FrmExercicio2.WindowState = FormWindowState.Maximized;
                FrmExercicio2.Show();
            }
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExercicio1>().Count() > 0)
            {
                Application.OpenForms["frmExercicio3"].BringToFront();
            }
            else
            {
                FrmExercicio3 FrmExercicio3 = new FrmExercicio3();
                FrmExercicio3.MdiParent = this;
                FrmExercicio3.WindowState = FormWindowState.Maximized;
                FrmExercicio3.Show();
            }
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExercicio1>().Count() > 0)
            {
                Application.OpenForms["frmExercicio4"].BringToFront();
            }
            else
            {
                FrmExercicio4 FrmExercicio4 = new FrmExercicio4();
                FrmExercicio4.MdiParent = this;
                FrmExercicio4.WindowState = FormWindowState.Maximized;
                FrmExercicio4.Show();
            }
        }
    }
}
