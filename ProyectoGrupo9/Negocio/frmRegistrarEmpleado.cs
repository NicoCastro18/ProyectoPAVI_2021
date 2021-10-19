using ProyectoGrupo9.Clases;
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
    public partial class frmRegistrarEmpleado : Form
    {
        Rol oRol = new Rol();
        public frmRegistrarEmpleado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text == "" || this.txtApellido.Text == "" || this.txtDni.Text == "" || this.cboRol.Text == "" || this.txtUsuario.Text == "" || this.txtContraseña.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los campos obligatorios");

            }
            else
            {
                SqlConnection conexion = new SqlConnection(@"server=DESKTOP-O6JL5EQ\SQLEXPRESS; database=Proyecto Pav;integrated security=true");
                conexion.Open();
                string consulta = "INSERT INTO Empleados (nombre,apellido,mail,usuario,contraseña,rol) VALUES ('" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtDni.Text + "','" + txtUsuario.Text + "', '" + txtContraseña.Text + "', '" + cboRol.Text + "')";
                SqlCommand agregado = new SqlCommand(consulta, conexion);
                agregado.ExecuteNonQuery();
                MessageBox.Show("Se agrego el empleado correctamente");
                conexion.Close();

                this.Close();
            }
        }
        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarCombo(ComboBox combo, DataTable tabla, string campoMostrar, string campoValor)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = campoMostrar;
            combo.ValueMember = campoValor;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmRegistrarEmpleado_Load(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnRegistrar.Enabled = true;

            this.CargarCombo(cboRol, oRol.RecuperarTodos());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
