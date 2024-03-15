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

    }
}
