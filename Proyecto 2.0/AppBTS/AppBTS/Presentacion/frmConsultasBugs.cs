using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBTS.Presentacion
{
    public partial class frmConsultasBugs : Form
    {
        Bug oBug = new Bug();
        Estado oEstado = new Estado();
        Prioridad oPrioridad = new Prioridad();
        Producto oProducto = new Producto();
        Usuario oUsuario = new Usuario();
        Criticidad oCriticidad = new Criticidad();
        

        public frmConsultasBugs()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmConsultasBugs_Load(object sender, EventArgs e)
        {
            this.dtpFechaDesde.Value = DateTime.Today.AddDays(-7);
            this.dtpFechaHasta.Value = DateTime.Today;

            this.CargarCombo(cboEstado,oEstado.RecuperarTodos());
            this.CargarCombo(cboPrioridad, oPrioridad.RecuperarTodos());
            this.CargarCombo(cboProducto, oProducto.RecuperarTodos());
            this.CargarCombo(cboAsignado, oUsuario.RecuperarTodos(), "usuario", "id_usuario");
            this.CargarCombo(cboCriticidad, oCriticidad.RecuperarTodos());

            //this.dgbBugs.DataSource = oBug.RecuperarTodos();
            this.CargarGrilla(dgvBugs, oBug.RecuperarTodos());

            this.btnConsultar.Enabled = true;
            this.btnNuevo.Enabled = true;
            this.btnAsignar.Enabled = false;
            this.btnEditar.Enabled = false;
            this.btnDetalle.Enabled = false;
            this.btnSalir.Enabled = true;


        }

        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_bug"],
                                tabla.Rows[i]["titulo"],
                                tabla.Rows[i]["producto"],
                                tabla.Rows[i]["fecha_alta"],
                                tabla.Rows[i]["estado"],
                                tabla.Rows[i]["usuario"],
                                tabla.Rows[i]["criticidad"],
                                tabla.Rows[i]["prioridad"]);
            };
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultasBugs_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que quiere salir?",
               "SALIR",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void dgvBugs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            string _estado, _asignado, _prioridad, _criticidad, _producto;
            _estado = _asignado = _prioridad = _criticidad = _producto = string.Empty;

            if (dtpFechaDesde.Value > dtpFechaDesde.Value)
            {
                MessageBox.Show("Error");
                //MessageBox.Show("Error","Fecha erronea", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                dtpFechaDesde.Focus();
                return;
            }
            if (cboEstado.SelectedIndex != -1)
                _estado = cboEstado.SelectedValue.ToString();
            if (cboAsignado.SelectedIndex != -1)
                _asignado = cboAsignado.SelectedValue.ToString();
            if (cboPrioridad.SelectedIndex != -1)
                _prioridad = cboPrioridad.SelectedValue.ToString();
            if (cboCriticidad.SelectedIndex != -1)
                _criticidad = cboCriticidad.SelectedValue.ToString();
            if (cboProducto.SelectedIndex != -1)
                _producto = cboProducto.SelectedValue.ToString();


            this.CargarGrilla(dgvBugs, oBug.RecuperarFiltrados(dtpFechaDesde.Value.ToString("yyyy/MM/dd"),
                                                                dtpFechaHasta.Value.ToString("yyyy/MM/dd"),
                                                                _estado,
                                                                _prioridad,
                                                                _producto,
                                                                _asignado,
                                                                _criticidad));
            
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            frmDetalleBug fdb = new frmDetalleBug();
            fdb.IdBug = (int)dgvBugs.CurrentRow.Cells[0].Value;
            fdb.ShowDialog();
        }
    }
}
