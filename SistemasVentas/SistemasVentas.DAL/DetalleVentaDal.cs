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
        public DetalleVenta ObtenerDetalleVentaId(int id)
        {
            string consulta = "SELECT * FROM detalleventa WHERE idDetalleVenta = " + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            DetalleVenta detalleVenta = new DetalleVenta();
            if (tabla.Rows.Count > 0)
            {
                detalleVenta.IdDetalleVenta = Convert.ToInt32(tabla.Rows[0]["idDetalleVenta"]);
                detalleVenta.IdVenta = Convert.ToInt32(tabla.Rows[0]["idVenta"]);
                detalleVenta.IdProducto = Convert.ToInt32(tabla.Rows[0]["idProducto"]);
                detalleVenta.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                detalleVenta.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioVenta"]);
                detalleVenta.Subtotal = Convert.ToDecimal(tabla.Rows[0]["subtotal"]);
                detalleVenta.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return detalleVenta;
        }

        public void EditarDetalleVentaDal(DetalleVenta detalleVenta)
        {
            string consulta = "UPDATE detalleventa SET idVenta = " + detalleVenta.IdVenta +
                              ", idProducto = " + detalleVenta.IdProducto +
                              ", cantidad = " + detalleVenta.Cantidad +
                              ", precioVenta = " + detalleVenta.PrecioVenta +
                              ", subtotal = " + detalleVenta.Subtotal +
                              "WHERE idDetalleVenta = " + detalleVenta.IdDetalleVenta;
            conexion.Ejecutar(consulta);
        }

        public void EliminarDetalleVentaDal(int id)
        {
            string consulta = "DELETE FROM detalleventa WHERE idDetalleVenta = " + id;
            conexion.Ejecutar(consulta);
        }

    }
}
