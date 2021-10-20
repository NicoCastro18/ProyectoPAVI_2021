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
    public partial class frmModificacionMedico : Form
    {
        public int Id_medico { get; set; }
        public int Matricula { get; set; }
        public int Honorarios { get; set; }
        public string Especialidad { get; set; }
        public string NombreMedico { get; set; }
        public string ApellidoMedico { get; set; }
        public int Telefono { get; set; }

        public string Mail { get; set; }


        public frmModificacionMedico()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"server=DESKTOP-O6JL5EQ\SQLEXPRESS; database=Proyecto Pav;integrated security=true");
            conexion.Open();
            string consulta = "Update Medico set  matricula = " + txtMatricula.Text + ", honorarios = " + txtHonorarios.Text + ", especialidad = '" + cboEspecialidad.Text + "', nombre = '" + txtNombre.Text + "', apellido = '" + txtApellido.Text + "',telefono = " + txtTelefono.Text + ", mail = '" + txtMail.Text + "'"
                   + "where matricula = " + Matricula;
            SqlCommand agregado = new SqlCommand(consulta, conexion);
            agregado.ExecuteNonQuery();
            MessageBox.Show("Se cambiaron los datos del paciente correctamente");
            conexion.Close();
            this.Close();
        }

        private void frmModificacionMedico_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = this.NombreMedico.ToString();
            this.txtApellido.Text = this.ApellidoMedico.ToString();
            this.txtMail.Text = this.Mail.ToString();
            this.txtTelefono.Text = this.Telefono.ToString();
            this.txtIdMed.Text = this.Id_medico.ToString();
            this.txtMatricula.Text = this.Matricula.ToString();
            this.cboEspecialidad.Text = this.Especialidad.ToString();
            this.txtHonorarios.Text = this.Honorarios.ToString();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
