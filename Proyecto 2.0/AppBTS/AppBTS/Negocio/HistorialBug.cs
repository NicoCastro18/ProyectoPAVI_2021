using AppBTS.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Negocio
{
    class HistorialBug
    {
        public int IdBug { get; set; }
        public int IdDetalle { get; set; }
        public int Asignado { get; set; }
        public int IdEstado { get; set; }
        public int Responsable { get; set; }
        public DateTime Fecha { get; set; }
        
        public DataTable RecuperarHistorialPorId(int idBug)
        {
            string consulta = "SELECT h.fecha_historico, u.usuario as responsable, e.nombre as estado, us.usuario as asignadoA"       
                               + " FROM (((BugsHistorico h "
                               + " LEFT JOIN Usuario u ON h.id_usuario_responsable = u.id_usuario)"
                               + " JOIN Estados e ON h.id_estado = e.id_estado)" 
                               + " LEFT JOIN Usuario us ON h.id_usuario_asignado = us.is_usuario)"
                               + " WHERE h.id_bug =" + idBug;


            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }
    }
}
