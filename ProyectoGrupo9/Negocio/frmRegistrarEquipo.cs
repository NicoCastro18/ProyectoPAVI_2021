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
    public partial class frmRegistrarEquipo : Form
    {
        Equipos oEquipo = new Equipos();
        Area oArea = new Area();
        public frmRegistrarEquipo()
        {
            InitializeComponent();
        }

        private void frmRegistrarEquipo_Load(object sender, EventArgs e)
        {
            this.CargarCombo(comboBox1, oArea.RecuperarTodos());
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" || this.comboBox1.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los campos obligatorios");

            }
            else
            {
                SqlConnection conexion = new SqlConnection(@"server=DESKTOP-O6JL5EQ\SQLEXPRESS; database=Proyecto Pav;integrated security=true");
                conexion.Open();
                string consulta = "INSERT INTO Equipos (nombre, area) VALUES ('" + textBox1.Text + "', '" + comboBox1.Text + "')";
                SqlCommand agregado = new SqlCommand(consulta, conexion);
                agregado.ExecuteNonQuery();
                MessageBox.Show("Se agrego el equipo correctamente");
                conexion.Close();

                this.Close();
            }
        }
    }
}
