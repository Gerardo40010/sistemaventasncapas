using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class VentaDal
    {
        public DataTable ListarVentaDal()
        {
            string consulta = "select * from Venta";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;

        }
        public void InsertarVentaDal(Venta venta)
        {
            string consulta = "insert into venta values('" + venta.IdCliente + "'," +
                                                           "'" + venta.IdVendedor + "'," +
                                                           "'" + venta.Fecha.ToString("yyyy-MM-dd") + "'," +
                                                           "'" + venta.Total + "'," +
                                                           "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Venta ObtenerVentaId(int id)
        {
            string consulta = "SELECT * FROM venta WHERE idVenta = " + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Venta venta = new Venta();
            if (tabla.Rows.Count > 0)
            {
                venta.IdVenta = Convert.ToInt32(tabla.Rows[0]["idVenta"]);
                venta.IdCliente = Convert.ToInt32(tabla.Rows[0]["idCliente"]);
                venta.IdVendedor = Convert.ToInt32(tabla.Rows[0]["idVendedor"]);
                venta.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                venta.Total = Convert.ToDecimal(tabla.Rows[0]["total"]);
                venta.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return venta;
        }

        public void EditarVentaDal(Venta venta)
        {
            string consulta = "UPDATE venta SET idCliente = " + venta.IdCliente +
                              ", idVendedor = " + venta.IdVendedor +
                              ", fecha = '" + venta.Fecha.ToString("yyyy-MM-dd") +
                              "', total = " + venta.Total +
                              ", estado = '" + venta.Estado + "' " +
                              "WHERE idVenta = " + venta.IdVenta;
            conexion.Ejecutar(consulta);
        }

        public void EliminarVentaDal(int id)
        {
            string consulta = "DELETE FROM venta WHERE idVenta = " + id;
            conexion.Ejecutar(consulta);
        }
    }
}
