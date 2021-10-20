using ProyectoGrupo9.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupo9.Clases
{
    class Medicos
    {
        public int Matricula { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Mail { get; set; }

        public int Telefono { get; set; }

        public bool Borrado { get; set; }

        public int id_medico { get; set; }

        public float Honorarios { get; set; }

        public string Especialidad { get; set; }


        public DataTable RecuperarTodos()
        {
            string consulta = "select * from Medico where borrado = 0 ORDER BY 2";

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }

        public DataTable RecuperarFiltrados(string mat)
        {
            string consulta = "select * from Medico E where E.borrado = 0 and E.matricula = " + mat;

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }

        public DataTable RecuperarImagenes()
        {
            string consulta = "select * from Medico E where E.borrado = 0 and E.especialidad = 'imagenes' Order by 5";

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }
        public DataTable RecuperarConsulta()
        {
            string consulta = "select * from Medico E where E.borrado = 0 and E.especialidad != 'imagenes' Order by 5";

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }
        public DataTable RecuperarCosto(string medico)
        {
            string consulta = "select * from Medico E where E.borrado = 0 and E.apellido = '" + medico + "'";

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }
    }  
}
