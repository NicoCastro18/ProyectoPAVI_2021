﻿using ProyectoGrupo9.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string consulta = "select * from Pacientes where borrado = 0 ORDER BY 2";

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }
        public DataTable RecuperarFiltrados(string DNI)
        {
            string consulta = "select * from Pacientes where borrado = 0  and dni =" + DNI;

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }


    }
}
