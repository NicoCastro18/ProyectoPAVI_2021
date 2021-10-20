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
    public partial class frmRegistrarMedico : Form
    {
        private Medicos miMedico = new Medicos();
        Especialidad oEspecialidad = new Especialidad();
        public frmRegistrarMedico()
        {
            InitializeComponent();
        }

        private void frmRegistrarMedico_Load(object sender, EventArgs e)
        {
            CargarCombo(comboBox1, oEspecialidad.RecuperarTodos());
            btnCancelar.Enabled = true;
            btnRegistrar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text == "" || this.txtApellido.Text == "" || this.txtMatricula.Text == "" || this.comboBox1.Text == "" || this.txtHonorarios.Text == "")
            {
                MessageBox.Show("Debe Ingresar todos los campos obligatorios");
            }
            else
            {
                SqlConnection conexion = new SqlConnection(@"server=DESKTOP-O6JL5EQ\SQLEXPRESS; database=Proyecto Pav;integrated security=true");
                conexion.Open();
                string consulta = "INSERT INTO Medico (nombre,apellido,mail,telefono,matricula,honorarios,especialidad) VALUES ('" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtMail.Text + "', '" + txtTelefono.Text + "', '" + txtMatricula.Text + "', '" + txtHonorarios.Text + "','" + comboBox1.Text + "')";
                SqlCommand agregado = new SqlCommand(consulta, conexion);
                agregado.ExecuteNonQuery();
                MessageBox.Show("Se agrego el Medico correctamente");
                conexion.Close();

                this.Close();
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
    }
}
