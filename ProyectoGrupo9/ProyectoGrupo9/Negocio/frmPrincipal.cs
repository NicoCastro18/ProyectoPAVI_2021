using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrupo9.Negocio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarPaciente cb;
            cb = new frmRegistrarPaciente();
            cb.ShowDialog();

            cb.Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de abandonar la aplicacion?",
                "SALIR",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void datosPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActualizacion cb;
            cb = new frmActualizacion();
            cb.ShowDialog();

            cb.Dispose();
        }

        private void borrarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta cb;
            cb = new frmConsulta();
            cb.ShowDialog();

            cb.Dispose(); 
        }
    }
}
