
using ProyectoGrupo9.Clases;
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
    public partial class frmLogin : Form
    {
        //string user = "admin";
        //string pass = "1234";

        private Empleado miUsuario = new Empleado();

        internal Empleado MiUsuario { get => miUsuario; set => miUsuario = value; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "LOGEO";
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un usuario");
                this.txtUsuario.Focus();
                return;
               
            }
            if (this.txtContraseña.Text == "")
            {
                MessageBox.Show("Debe ingresar una contraseña");
                this.txtContraseña.Focus();
                return;
            }
            miUsuario.Usuario_empleado = this.txtUsuario.Text; //hace que se asigne el set en el nombre en la pagina Usuario
            miUsuario.Contraseña = this.txtContraseña.Text;

            miUsuario.Id_empleado = this.miUsuario.validarUsuario(this.miUsuario.Usuario_empleado, this.miUsuario.Contraseña);

            // if (this.txtUsuario.Text == this.lblUsuari && this.txtContraseña.Text == this.pass)
            if (MiUsuario.Id_empleado != 0)
            {
                MessageBox.Show("Login OK", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta", "Error al Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtContraseña.Text = "";
                this.txtUsuario.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

