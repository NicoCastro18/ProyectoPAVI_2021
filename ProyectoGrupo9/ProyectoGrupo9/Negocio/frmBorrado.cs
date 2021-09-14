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

namespace ProyectoGrupo9.Negocio
{
    
    public partial class frmBorrado : Form
    {
        Paciente oPaciente = new Paciente();
        public frmBorrado()
        {
            InitializeComponent();
        }

        private void dgvBugs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmBorrado_Load(object sender, EventArgs e)
        {
            string dni = string.Empty;
            dni = this.txtDniFiltro.Text;

            this.CargarGrilla(dgvPacienteFiltrado, oPaciente.RecuperarFiltrados(dni));
            
            this.btnBuscarPorFiltro.Enabled = true;
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
    }
}
