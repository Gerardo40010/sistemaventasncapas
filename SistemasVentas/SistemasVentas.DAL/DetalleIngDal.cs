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
    }
}
