using ProyectoGrupo9.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupo9.Clases
{
    class Provincia
    {
        public int Id_provincia { get; set; }
        public string Nombre { get; set; }
        public bool Borrado { get; set; }


        public DataTable RecuperarTodos()
        {
            string consulta = "select * from Provincias where borrado = 0 ORDER BY 2";

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }
    }
}
