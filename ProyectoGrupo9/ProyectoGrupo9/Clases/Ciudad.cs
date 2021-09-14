using ProyectoGrupo9.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupo9.Clases
{
    class Ciudad
    {
        public int Id_ciudad { get; set; }
        public bool Borrado { get; set; }
        public int Provincia { get; set; }
        public string Nombre { get; set; }

        public DataTable RecuperarTodos()
        {
            string consulta = "select * from Ciudades where borrado = 0 ORDER BY 2";

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }
    }
}
