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
    public partial class frmModificacionParticular : Form
    {
        Provincia oProvincia = new Provincia();
        Ciudad oCiudad = new Ciudad();
        public int DNI_Paciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string ObraSocial { get; set; }
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public string Mail { get; set; }
        public string Provincia { get; set; }
        public int AlturaCalle { get; set; }

        public frmModificacionParticular()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptarIngreso_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"server=DESKTOP-O6JL5EQ\SQLEXPRESS; database=Proyecto Pav;integrated security=true");
            conexion.Open();
            string consulta = "Update Pacientes set  nombre = '" + txtNombre.Text + "', apellido = '" + txtApellido.Text + "', dni = '" + txtDni.Text + "' , mail = '" + txtMail.Text + "',  provincia = '" + cboProvincia + "', ciudad = '" + cboCiudad + "', calle = '" + txtCalle.Text + "', altura_Calle = '" + txtAlturaCalle.Text + "'" + "where dni =" + DNI_Paciente;
            SqlCommand agregado = new SqlCommand(consulta, conexion);
            agregado.ExecuteNonQuery();
            MessageBox.Show("Se cambiaron los datos del paciente correctamente");
            conexion.Close();
            this.Close();
        }

        private void frmModificacionParticular_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = this.Nombre.ToString();
            this.txtApellido.Text = this.Apellido.ToString();
            this.txtMail.Text = this.Mail.ToString();
            this.txtDni.Text = this.DNI_Paciente.ToString();
            this.txtCalle.Text = this.Calle.ToString();
            this.txtAlturaCalle.Text = this.AlturaCalle.ToString();
            this.cboCiudad.Text = this.Ciudad.ToString();
            this.cboProvincia.Text = this.Provincia.ToString();
            btnConfirmarCambios.Enabled = true;
            btnCancelarCambios.Enabled = true;

            this.CargarCombo(cboProvincia, oProvincia.RecuperarTodos());
            this.CargarCombo(cboCiudad, oCiudad.RecuperarTodos());
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

    }
}
