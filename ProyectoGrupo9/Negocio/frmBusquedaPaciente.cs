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
    public partial class frmBusquedaPaciente : Form
    {
        Paciente oPaciente = new Paciente();
        public frmBusquedaPaciente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvBugs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarPorFiltro_Click(object sender, EventArgs e)
        {
            string DNI = string.Empty;
            DNI = this.textBox1.Text;

            this.CargarGrilla(dgvPaciente, oPaciente.RecuperarFiltrados(DNI));

            

        }

        private void frmActualizacion_Load(object sender, EventArgs e)
        {
            btnBorrar.Enabled = false;
            btnModificar.Enabled = false;
            btnRefrescar.Enabled = true;
            btnCancelar.Enabled = true;

            this.CargarGrilla(dgvPaciente, oPaciente.RecuperarTodos());

            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string DNI = string.Empty;

            DNI = this.textBox1.Text;

            SqlConnection conexion = new SqlConnection(@"server=DESKTOP-O6JL5EQ\SQLEXPRESS; database=Proyecto Pav;integrated security=true");
            conexion.Open();
            string consulta = "Delete From Pacientes where dni = " + DNI;
            SqlCommand agregado = new SqlCommand(consulta, conexion);
            agregado.ExecuteNonQuery();
            MessageBox.Show("Se ha eliminado el paciente con exito");
            conexion.Close();
            
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.CargarGrilla(dgvPaciente, oPaciente.RecuperarTodos());
        }

        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["dni"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["apellido"],
                                tabla.Rows[i]["provincia"],
                                tabla.Rows[i]["ciudad"],
                                tabla.Rows[i]["obra_social"],
                                tabla.Rows[i]["calle"],
                                tabla.Rows[i]["altura_Calle"],
                                tabla.Rows[i]["fecha_nacimiento"],
                                tabla.Rows[i]["mail"]);
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificacionParticular cb;
            cb = new frmModificacionParticular();
            cb.Nombre = (string)dgvPaciente.CurrentRow.Cells[1].Value;
            cb.DNI_Paciente = (int)dgvPaciente.CurrentRow.Cells[0].Value;
            cb.Apellido = (string)dgvPaciente.CurrentRow.Cells[2].Value;
            cb.ObraSocial = (string)dgvPaciente.CurrentRow.Cells[5].Value;
            cb.Calle = (string)dgvPaciente.CurrentRow.Cells[6].Value;
            cb.AlturaCalle = (int)dgvPaciente.CurrentRow.Cells[7].Value;
            cb.Provincia = (string)dgvPaciente.CurrentRow.Cells[3].Value;
            cb.Mail = (string)dgvPaciente.CurrentRow.Cells[9].Value;
            cb.Ciudad= (string)dgvPaciente.CurrentRow.Cells[4].Value;

            cb.ShowDialog();

            cb.Dispose();
        }

        private void dgvPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnModificar.Enabled = true;
            this.btnBorrar.Enabled = true;
        }
    }
}
