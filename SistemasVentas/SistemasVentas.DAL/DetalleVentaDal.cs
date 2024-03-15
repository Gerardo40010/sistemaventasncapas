using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleVentaDal
    {
        public DataTable ListarDetalleVentaDal()
        {
            string consulta = "select * from DetalleVenta";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;

        }
        public void InsertarDetalleVentaDal(DetalleVenta detalleVenta)
        {
            string consulta = "insert into detalleventa values('" + detalleVenta.IdVenta + "'," +
                                                      "'" + detalleVenta.IdProducto + "'," +
                                                       "'" + detalleVenta.Cantidad + "'," +
                                                     "'" + detalleVenta.PrecioVenta + "'," +
                                                    "'" + detalleVenta.Subtotal + "'," +
                                                          "'Exitoso')";
            conexion.Ejecutar(consulta);
        }
    }
}
