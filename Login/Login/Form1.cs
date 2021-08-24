using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmLogin : Form
    {   string usuario = "admin";
        string contra = "1234";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    
  
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un usuario");
                this.txtUsuario.Focus();
                return;
            }
            if (this.txtContra.Text == "")
            {
                MessageBox.Show("Debe ingresar una contraseña");
                this.txtContra.Focus();
                return;
            }
            if (this.txtUsuario.Text == this.usuario && this.txtContra.Text == this.contra)
            {
                MessageBox.Show("Login confirmado", "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Login denegado", "Usuario y o contraseña erroneos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtContra.Text = "";
                this.txtUsuario.Focus();

            }
        }

        private void lbContra_Click(object sender, EventArgs e)
        {

        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
