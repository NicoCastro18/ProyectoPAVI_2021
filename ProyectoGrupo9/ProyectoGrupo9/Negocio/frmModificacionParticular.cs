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
        public int Dni_Paciente { get; set; }
        Obra_Social oObra = new Obra_Social();
        Provincia oProvincia = new Provincia();
        Ciudad oCiudad = new Ciudad();

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
            string consulta = "Update Pacientes set dni = '" + txtDni.Text + "', nombre = '" + txtNombre.Text + "', apellido = '" + txtApellido.Text + "', mail = '" + txtMail.Text + "', obra_social = '" + cboObra.Text + "', provincia = '" + cboProvincia.Text + "', ciudad = '" + cboCiudad.Text + "', calle = '" + txtCalle.Text + "', altura_Calle = '" + txtAltura_Calle.Text + "'"+"where dni ="+ Dni_Paciente;
            SqlCommand agregado = new SqlCommand(consulta, conexion);
            agregado.ExecuteNonQuery();
            MessageBox.Show("Se cambiaron los datos del paciente correctamente");
            conexion.Close();
            this.Close();
        }

        private void frmModificacionParticular_Load(object sender, EventArgs e)
        {
            this.txtDni.Text = this.Dni_Paciente.ToString();
            //agregarCampos();
            this.CargarCombo(cboObra, oObra.RecuperarTodos());
            this.CargarCombo(cboProvincia, oProvincia.RecuperarTodos());
            this.CargarCombo(cboCiudad, oCiudad.RecuperarTodos());
        }

        private void agregarCampos()
        {

            
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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

        private void btnCancelarCambios_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
