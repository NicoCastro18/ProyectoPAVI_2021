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
    
    public partial class frmConsulta : Form
    {

        Paciente oPaciente = new Paciente();
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void frmBorrado_Load(object sender, EventArgs e)
        {
            this.CargarGrilla(dgvPacienteFiltrado, oPaciente.RecuperarTodos());
            
            this.btnBuscarPorFiltro.Enabled = true;
            this.btnActualizar.Enabled = false;
            this.btnBorrar.Enabled = false;

        }

        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_paciente"],
                                tabla.Rows[i]["dni"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["apellido"],
                                tabla.Rows[i]["provincia"],
                                tabla.Rows[i]["ciudad"],
                                tabla.Rows[i]["obra_social"],
                                tabla.Rows[i]["calle"],
                                tabla.Rows[i]["altura_Calle"],
                                tabla.Rows[i]["mail"],
                                tabla.Rows[i]["fecha_nacimiento"]);
            };
        }

        private void btnBuscarPorFiltro_Click(object sender, EventArgs e)
        {

            string dni = string.Empty;

            dni = this.txtDniFiltro.Text;

            this.CargarGrilla(dgvPacienteFiltrado, oPaciente.RecuperarFiltrados(dni));

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = string.Empty;

            dni = this.txtDniFiltro.Text;
            SqlConnection conexion = new SqlConnection(@"server=DESKTOP-O6JL5EQ\SQLEXPRESS; database=Proyecto Pav;integrated security=true");
            conexion.Open();
            string consulta = "Delete From Pacientes where dni = " + dni;
            SqlCommand agregado = new SqlCommand(consulta, conexion);
            agregado.ExecuteNonQuery();
            MessageBox.Show("Se elimino el paciente correctamente");
            conexion.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
            frmModificacionParticular cb;
            cb = new frmModificacionParticular();
            cb.Dni_Paciente = (int)dgvPacienteFiltrado.CurrentRow.Cells[1].Value;
            cb.ShowDialog();

            cb.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvPacienteFiltrado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnActualizar.Enabled = true;
            this.btnBorrar.Enabled = true;
        }
    }
}
