using ProyectoGrupo9.Clases;
using System;
using System.Data.SqlClient;
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
    public partial class frmBusquedaMedico : Form
    {

        Medicos oMedicos = new Medicos();

        public frmBusquedaMedico()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmActualizacionMedico_Load(object sender, EventArgs e)
        {
            this.CargarGrilla(dgvMedicoFiltrado, oMedicos.RecuperarTodos());



            this.btnBuscar.Enabled = true;
            this.btnModificar.Enabled = false;
            this.btnBorrar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string mat = string.Empty;

            mat = txtMatricula.Text;

            this.CargarGrilla(dgvMedicoFiltrado, oMedicos.RecuperarFiltrados(mat));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificacionMedico cb;
            cb = new frmModificacionMedico();
            cb.Id_medico = (int)dgvMedicoFiltrado.CurrentRow.Cells[0].Value;
            cb.Matricula = (int)dgvMedicoFiltrado.CurrentRow.Cells[1].Value;
            cb.Honorarios = (int)dgvMedicoFiltrado.CurrentRow.Cells[2].Value;
            cb.Especialidad = (string)dgvMedicoFiltrado.CurrentRow.Cells[3].Value;
            cb.NombreMedico = (string)dgvMedicoFiltrado.CurrentRow.Cells[4].Value;
            cb.ApellidoMedico = (string)dgvMedicoFiltrado.CurrentRow.Cells[5].Value;
            cb.Telefono = (int)dgvMedicoFiltrado.CurrentRow.Cells[6].Value;
            cb.Mail = (string)dgvMedicoFiltrado.CurrentRow.Cells[7].Value;
            cb.ShowDialog();

            cb.Dispose();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string mat = string.Empty;

            mat = this.txtMatricula.Text;

            SqlConnection conexion = new SqlConnection(@"server=DESKTOP-O6JL5EQ\SQLEXPRESS; database=Proyecto Pav;integrated security=true");
            conexion.Open();
            string consulta = "Delete From Medico where Matricula = " + mat;
            SqlCommand agregado = new SqlCommand(consulta, conexion);
            agregado.ExecuteNonQuery();
            MessageBox.Show("Se ha eliminado el medico con exito");
            conexion.Close();
            
        }

        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_medico"],
                                tabla.Rows[i]["matricula"],
                                tabla.Rows[i]["honorarios"],
                                tabla.Rows[i]["especialidad"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["apellido"],
                                tabla.Rows[i]["telefono"],
                                tabla.Rows[i]["mail"]);
            };
        }

        private void dgvEmpleadoFiltrado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnBorrar.Enabled = true;
            this.btnModificar.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMedicoFiltrado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnBorrar.Enabled = true;
            this.btnModificar.Enabled = true;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.CargarGrilla(dgvMedicoFiltrado, oMedicos.RecuperarTodos());
        }
    }
}
