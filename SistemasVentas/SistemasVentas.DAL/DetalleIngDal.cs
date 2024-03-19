using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleIngDal
    {
        public DataTable ListarDetalleIngDal()
        {
            string consulta = "select * from Detalleing";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;

        }
        public void InsertarDetalleIngDal(DetalleIng detalleIng)
        {
            string consulta = "insert into detalleing values('" + detalleIng.IdIngreso + "'," +
                                                             "'" + detalleIng.IdProducto + "'," +
                                                        "'" + detalleIng.FechaVenc.ToString("yyyy-MM-dd") + "'," +
                                                          "'" + detalleIng.Cantidad + "'," +
                                                           "'" + detalleIng.PrecioCosto + "'," +
                                                             "'" + detalleIng.PrecioVenta + "'," +
                                                            "'" + detalleIng.Subtotal + "'," +
                                                           "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public DetalleIng ObtenerDetalleIngId(int id)
        {
            string consulta = "SELECT * FROM detalleing WHERE idDetalleIng=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            DetalleIng detalleIng = new DetalleIng();
            if (tabla.Rows.Count > 0)
            {
                detalleIng.IdDetalleIng = Convert.ToInt32(tabla.Rows[0]["idDetalleIng"]);
                detalleIng.IdIngreso = Convert.ToInt32(tabla.Rows[0]["idIngreso"]);
                detalleIng.IdProducto = Convert.ToInt32(tabla.Rows[0]["idProducto"]);
                detalleIng.FechaVenc = Convert.ToDateTime(tabla.Rows[0]["fechaVenc"]);
                detalleIng.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                detalleIng.PrecioCosto = Convert.ToDecimal(tabla.Rows[0]["precioCosto"]);
                detalleIng.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioVenta"]);
                detalleIng.Subtotal = Convert.ToDecimal(tabla.Rows[0]["subtotal"]);
                detalleIng.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return detalleIng;
        }

        public void EditarDetalleIngDal(DetalleIng detalleIng)
        {
            string consulta = "UPDATE detalleing SET idIngreso=" + detalleIng.IdIngreso + "," +
                                                     "idProducto=" + detalleIng.IdProducto + "," +
                                                     "fechaVenc='" + detalleIng.FechaVenc.ToString("yyyy-MM-dd") + "'," +
                                                     "cantidad=" + detalleIng.Cantidad + "," +
                                                     "precioCosto=" + detalleIng.PrecioCosto + "," +
                                                     "precioVenta=" + detalleIng.PrecioVenta + "," +
                                                     "subtotal=" + detalleIng.Subtotal + "," +
                                                     "WHERE idDetalleIng=" + detalleIng.IdDetalleIng;

            conexion.Ejecutar(consulta);
        }

        public void EliminarDetalleIngDal(int id)
        {
            string consulta = "DELETE FROM detalleing WHERE idDetalleIng=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
