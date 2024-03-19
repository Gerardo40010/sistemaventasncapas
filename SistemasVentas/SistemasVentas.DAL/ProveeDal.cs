using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProveeDal
    {
        public DataTable ListarProveeDal()
        {
            string consulta = "select * from Provee";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;

        }
        public void InsertarProveeDal(Provee provee)
        {
            string consulta = "insert into provee values('" + provee.IdProducto + "'," +
                                                           "'" + provee.IdProducto + "'," +
                                                         "'" + provee.IdProveedor + "'," +
                                                         "'" + provee.Fecha.ToString("yyyy-MM-dd") + "'," +
                                                          "'" + provee.Precio + "')";
           
            conexion.Ejecutar(consulta);
        }
        public Provee ObtenerProveeId(int id)
        {
            string consulta = "SELECT * FROM provee WHERE idProvee = " + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Provee provee = new Provee();
            if (tabla.Rows.Count > 0)
            {
                provee.IdProvee = Convert.ToInt32(tabla.Rows[0]["idProvee"]);
                provee.IdProducto = Convert.ToInt32(tabla.Rows[0]["idProducto"]);
                provee.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idProveedor"]);
                provee.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                provee.Precio = Convert.ToDecimal(tabla.Rows[0]["precio"]);
            }
            return provee;
        }

        public void EditarProveeDal(Provee provee)
        {
            string consulta = "UPDATE provee SET idProducto = " + provee.IdProducto +
                              ", idProveedor = " + provee.IdProveedor +
                              ", fecha = '" + provee.Fecha.ToString("yyyy-MM-dd") +
                              "', precio = " + provee.Precio +
                              " WHERE idProvee = " + provee.IdProvee;
            conexion.Ejecutar(consulta);
        }

        public void EliminarProveeDal(int id)
        {
            string consulta = "DELETE FROM provee WHERE idProvee = " + id;
            conexion.Ejecutar(consulta);
        }


    }
}
