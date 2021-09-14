using AppBTS.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Negocio
{
    class Usuario
    {
        private int id_usuario;

        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
        public int Id_perfil { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        public bool Borrado { get; set; }

       public int validarUsuario(string nombre, string clave)
       {
            string consulta = "select * from Usuarios where usuario='" + nombre + "' and password= '" + clave + "'";
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
            string consulta = "select * from Usuarios where borrado = 0 ORDER BY 2";

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }

    }
}
