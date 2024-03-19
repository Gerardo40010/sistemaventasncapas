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
        public Ingreso ObtenerIngresoId(int id)
        {
            string consulta = "SELECT * FROM ingreso WHERE idIngreso = " + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Ingreso ingreso = new Ingreso();
            if (tabla.Rows.Count > 0)
            {
                ingreso.IdIngreso = Convert.ToInt32(tabla.Rows[0]["idIngreso"]);
                ingreso.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idProveedor"]);
                ingreso.FechaIngreso = Convert.ToDateTime(tabla.Rows[0]["fechaIngreso"]);
                ingreso.Total = Convert.ToDecimal(tabla.Rows[0]["total"]);
                ingreso.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return ingreso;
        }

        public void EditarIngresoDal(Ingreso ingreso)
        {
            string consulta = "UPDATE ingreso SET idProveedor = " + ingreso.IdProveedor +
                              ", fechaIngreso = '" + ingreso.FechaIngreso.ToString("yyyy-MM-dd") +
                              "', total = " + ingreso.Total +
                              ", estado = '" + ingreso.Estado + "' " +
                              "WHERE idIngreso = " + ingreso.IdIngreso;
            conexion.Ejecutar(consulta);
        }

        public void EliminarIngresoDal(int id)
        {
            string consulta = "DELETE FROM ingreso WHERE idIngreso = " + id;
            conexion.Ejecutar(consulta);
        }
    }
}
