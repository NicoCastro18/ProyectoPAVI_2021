using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrupo9.Negocio
{
    public partial class frmModificacionEmpleado : Form
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Mail { get; set; }
        public string Rol { get; set; }
        public int Id_empleado { get; set; }


        public frmModificacionEmpleado()
        {
            InitializeComponent();
        }

        private void txtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModificacionEmpleado_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = this.Nombre.ToString();
            this.txtApellido.Text = this.Apellido.ToString();
            //this.txtMail.Text = this.Mail.ToString();
            this.txtUsuario.Text = this.Usuario.ToString();
            this.txtContraseña.Text = this.Contraseña.ToString();
            this.cboRol.Text = this.Rol.ToString();
            
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"server=DESKTOP-O6JL5EQ\SQLEXPRESS; database=Proyecto Pav;integrated security=true");
            conexion.Open();
            string consulta = "Update Empleados set  nombre = '" + txtNombre.Text + "', apellido = '" + txtApellido.Text + "', usuario = '" + txtUsuario.Text + "', contraseña = '" + txtContraseña.Text + "', mail = '" + txtMail.Text + "', rol = '" + cboRol.Text + "'"
                + "where id_empleado = " + Id_empleado;
            SqlCommand agregado = new SqlCommand(consulta, conexion);
            agregado.ExecuteNonQuery();
            MessageBox.Show("Se cambiaron los datos del empleado correctamente");
            conexion.Close();
            this.Close();
        }
    }
    
}
