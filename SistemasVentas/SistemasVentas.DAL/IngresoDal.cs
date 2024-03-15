using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class IngresoDal
    {
        public DataTable ListarIngresoDal()
        {
            string consulta = "select * from Ingreso";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;

        }
        public void InsertarIngresoDal(Ingreso ingreso)
        {
            string consulta = "insert into ingreso values('" + ingreso.IdProveedor + "'," +
                                                           "'" + ingreso.FechaIngreso.ToString("yyyy-MM-dd") + "'," +
                                                           "'" + ingreso.Total + "'," +
                                                           "'Activo')";
            conexion.Ejecutar(consulta);
        }

    }
}
