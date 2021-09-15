using ProyectoGrupo9.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoGrupo9.Negocio;

namespace ProyectoGrupo9.Clases
{
    class Paciente
    {
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_nacimiento { get; set; }
        public string Calle { get; set; }
        public int Ciudad { get; set; }
        public int Obra_social { get; set; }
        public bool Borrado { get; set; }
        public int Id_Paciente { get; set; }
        public string Mail { get; set; }
        public int Altura_Calle { get; set; }
        public int Provincia { get; set; }

        public DataTable RecuperarTodos()
        {
            string consulta = "select * from Pacientes where borrado = 0";

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }

        public DataTable RecuperarFiltrados(string dni)
        {
            string consulta = "select * from Pacientes P where P.borrado = 0 and P.dni = " + dni;
            
            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }

        public DataTable RecuperarPorDNI(int Dni_Paciente)
        {
            string consulta = "SELECT dni, nombre, apellido, mail, fecha_nacimiento, provincia, ciudad, calle, altura_Calle"
                               + " FROM Pacientes "
                               + " WHERE borrado = 0 "
                               + " And dni =" + Dni_Paciente;

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }
    }
}
