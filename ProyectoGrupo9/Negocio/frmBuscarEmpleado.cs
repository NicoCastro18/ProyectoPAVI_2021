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
    public partial class frmBuscarEmpleado : Form
    {
        Empleado oEmpleado = new Empleado();
        public frmBuscarEmpleado()
        {
            InitializeComponent();
        }

        private void frmBuscarEmpleado_Load(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            btnRefrescar.Enabled = true;

            this.CargarGrilla(dgvEmpleado, oEmpleado.RecuperarTodos());

        }

        private void dgvMedicoFiltrado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;

            
        }
        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_empleado"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["apellido"],
                                tabla.Rows[i]["usuario"],
                                tabla.Rows[i]["contraseña"],
                                tabla.Rows[i]["rol"]);
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string id = string.Empty;

            id = this.txtId.Text;

            SqlConnection conexion = new SqlConnection(@"server=DESKTOP-O6JL5EQ\SQLEXPRESS; database=Proyecto Pav;integrated security=true");
            conexion.Open();
            string consulta = "Delete From Empleados where id_empleado = " + id;
            SqlCommand agregado = new SqlCommand(consulta, conexion);
            agregado.ExecuteNonQuery();
            MessageBox.Show("Se ha eliminado el empleado con exito");
            conexion.Close();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.CargarGrilla(dgvEmpleado, oEmpleado.RecuperarTodos());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificacionEmpleado cb;
            cb = new frmModificacionEmpleado();
            cb.Id_empleado = (int)dgvEmpleado.CurrentRow.Cells[0].Value;
            cb.Nombre = (string)dgvEmpleado.CurrentRow.Cells[1].Value;
            cb.Apellido = (string)dgvEmpleado.CurrentRow.Cells[2].Value;
            cb.Usuario = (string)dgvEmpleado.CurrentRow.Cells[3].Value;
            cb.Contraseña = (string)dgvEmpleado.CurrentRow.Cells[4].Value;
            cb.Rol = (string)dgvEmpleado.CurrentRow.Cells[5].Value;
            cb.Mail = (string)dgvEmpleado.CurrentRow.Cells[6].Value;
            
            cb.ShowDialog();

            cb.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = string.Empty;

            id = this.txtId.Text;

            this.CargarGrilla(dgvEmpleado, oEmpleado.RecuperarFiltrados(id));
        }
    }
}
