using ProyectoGrupo9.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupo9.Clases
{
    class Empleado
    {
        public int Id_empleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario_empleado{ get; set; }
        public string Contraseña { get; set; }
        public string Mail { get; set; }
        public bool Borrado { get; set; }

        public int validarUsuario(string nombre, string clave)
        {
            string consulta = "select * from Empleados where usuario='" + nombre + "' and contraseña= '" + clave + "'";
            DataTable table = new DataTable();

            BDHelper oDatos = new BDHelper();
            DataTable tabla = oDatos.consultar(consulta);

            if (tabla.Rows.Count > 0)
            {
                return (int)tabla.Rows[0][0];
            }
            else
            {
                return 0;
            }
        }

        public DataTable RecuperarTodos()
        {
            string consulta = "select * from Empleados where borrado = 0 ORDER BY 2";

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }
    }
}
