using ProyectoGrupo9.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProyectoGrupo9.Datos;




namespace ProyectoGrupo9
{
    public partial class frmRegistrarPaciente : Form
    {
        Provincia oProvincia = new Provincia();
        Obra_Social oObraSocial = new Obra_Social();
        Ciudad oCiudad = new Ciudad();

        public frmRegistrarPaciente()
        {
            InitializeComponent();
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

        private void Form1_Load(object sender, EventArgs e)
        {

            this.CargarCombo(cboObra, oObraSocial.RecuperarTodos());
            this.CargarCombo(cboProvincia, oProvincia.RecuperarTodos());
            this.CargarCombo(cboCiudades, oCiudad.RecuperarTodos());

            this.btnAceptarIngreso.Enabled = true;
            this.btnCancelarIngreso.Enabled = true;
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
            SqlConnection conexion = new SqlConnection(@"server=DESKTOP-O6JL5EQ\SQLEXPRESS; database=Proyecto Pav;integrated security=true");
            conexion.Open();
            string consulta = "INSERT INTO Pacientes (nombre,apellido,dni,mail,obra_social,provincia,ciudad,calle,altura_calle) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', " + textBox3.Text + ", '" + textBox6.Text + "', '" + cboObra.Text + "', '"+ cboProvincia.Text+ "', '"+ cboCiudades.Text+ "', '" + textBox4.Text + "', " + textBox5.Text + ")";
            SqlCommand agregado = new SqlCommand(consulta, conexion);
            agregado.ExecuteNonQuery();
            MessageBox.Show("Se agrego el paciente correctamente");
            conexion.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
