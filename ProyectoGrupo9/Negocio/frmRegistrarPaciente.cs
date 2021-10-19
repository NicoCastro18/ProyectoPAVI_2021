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

namespace ProyectoGrupo9
{
    public partial class frmRegistrarPaciente : Form
    {
        Provincia oProvincia = new Provincia();
        Ciudad oCiudad = new Ciudad();
        Obra_Social oObra = new Obra_Social();


        public frmRegistrarPaciente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCombo(cboCiudad, oCiudad.RecuperarTodos());
            CargarCombo(cboObra, oObra.RecuperarTodos());
            CargarCombo(cboProvincia, oProvincia.RecuperarTodos());

            btnAceptarIngreso.Enabled = true;
            btnCancelarIngreso.Enabled = true;
        }

        private void frmRegistrarPacient_Load(object sender, EventArgs e)
        {
            CargarCombo(cboCiudad, oCiudad.RecuperarTodos());
            CargarCombo(cboObra, oObra.RecuperarTodos());
            CargarCombo(cboProvincia, oProvincia.RecuperarTodos());

            btnAceptarIngreso.Enabled = true;
            btnCancelarIngreso.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarIngreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarIngreso_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text == "" || this.txtApellido.Text == "" || this.txtDNI.Text == "" || this.cboCiudad.Text == "" || this.cboObra.Text == "" || this.cboProvincia.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los campos obligatorios");

            }
            else
            {
                SqlConnection conexion = new SqlConnection(@"server=DESKTOP-O6JL5EQ\SQLEXPRESS; database=Proyecto Pav;integrated security=true");
                conexion.Open();
                string consulta = "INSERT INTO Pacientes (nombre,apellido,dni,obra_social,mail,provincia,ciudad,calle,altura_Calle) VALUES ('" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtDNI.Text + "','" + cboObra.Text + "', '" + txtMail.Text + "', '" + cboProvincia.Text + "','" + cboCiudad.Text + "','" + txtCalle.Text + "', '" + txtAlturaCalle.Text + "')";
                SqlCommand agregado = new SqlCommand(consulta, conexion);
                agregado.ExecuteNonQuery();
                MessageBox.Show("Se agrego el paciente correctamente");
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

        private void cboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
