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
    public partial class frmDetalleBug : Form
    {
        private int idBug;

        public int IdBug { get => idBug; set => idBug = value; }

        public frmDetalleBug()
        {
            InitializeComponent();
        }

        private void frmDetalleBug_Load(object sender, EventArgs e)
        {
            actualizarCampos();

        }

        private void actualizarCampos()
        {
            DataTable tabla = new DataTable();
            Bug oBugSeleccionado = new Bug();
            tabla = oBugSeleccionado.RecuperarPorId(idBug);
            txt_nro_bug.Text = tabla.Rows[0]["id_Bug"].ToString();
            txt_titulo.Text = tabla.Rows[0]["titulo"].ToString();
            txt_producto.Text = tabla.Rows[0]["producto"].ToString();
            txt_fec_alta.Text = tabla.Rows[0]["fecha_alta"].ToString();
            txt_descri.Text = tabla.Rows[0]["descripcion"].ToString();
            txt_prioridad.Text = tabla.Rows[0]["prioridad"].ToString();
            txt_criticidad.Text = tabla.Rows[0]["criticidad"].ToString();

            tabla.Clear();

            HistorialBug oHB = new HistorialBug();
            tabla = oHB.RecuperarHistorialPorId(idBug);

            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgv_historiales.Rows.Add(tabla.Rows[i]["fecha_historico"],
                                             tabla.Rows[i]["responsable"],
                                             tabla.Rows[i]["estado"],
                                             tabla.Rows[i]["asignadoA"]);
                }
            }



        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_descri_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nro_bug_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_historiales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
