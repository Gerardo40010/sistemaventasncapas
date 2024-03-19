using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProductoDal
    {
        public DataTable ListarProductoDal()
        {
            string consulta = "select * from Producto";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;

        }
        public void InsertarProductoDal(Producto producto)
        {
            string consulta = "insert into producto values('" + producto.IdTipoProd + "'," +
                                                           "'" + producto.IdMarca + "'," +
                                                           "'" + producto.Nombre + "'," +
                                                           "'" + producto.CodigoBarra + "'," +
                                                           "'" + producto.Unidad + "'," +
                                                           "'" + producto.Descripcion + "'," +
                                                           "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Producto ObtenerProductoId(int id)
        {
            string consulta = "SELECT * FROM producto WHERE idProducto = " + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Producto producto = new Producto();
            if (tabla.Rows.Count > 0)
            {
                producto.IdProducto = Convert.ToInt32(tabla.Rows[0]["idProducto"]);
                producto.IdTipoProd = Convert.ToInt32(tabla.Rows[0]["idTipoProd"]);
                producto.IdMarca = Convert.ToInt32(tabla.Rows[0]["idMarca"]);
                producto.Nombre = tabla.Rows[0]["nombre"].ToString();
                producto.CodigoBarra = tabla.Rows[0]["codigoBarra"].ToString();
                producto.Unidad = Convert.ToInt32(tabla.Rows[0]["unidad"]);
                producto.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                producto.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return producto;
        }

        public void EditarProductoDal(Producto producto)
        {
            string consulta = "UPDATE producto SET idTipoProd = " + producto.IdTipoProd +
                              ", idMarca = " + producto.IdMarca +
                              ", nombre = '" + producto.Nombre +
                              "', codigoBarra = '" + producto.CodigoBarra +
                              "', unidad = " + producto.Unidad +
                              ", descripcion = '" + producto.Descripcion +
                              "', estado = '" + producto.Estado + "' " +
                              "WHERE idProducto = " + producto.IdProducto;
            conexion.Ejecutar(consulta);
        }

        public void EliminarProductoDal(int id)
        {
            string consulta = "DELETE FROM producto WHERE idProducto = " + id;
            conexion.Ejecutar(consulta);
        }

    }
}
