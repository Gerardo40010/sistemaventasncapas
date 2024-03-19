using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProveedorDal
    {
        public DataTable ListarProveedorDal()
        {
            string consulta = "select * from Proveedor";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;

        }
        public void InsertarProveedorDal(Proveedor proveedor)
        {
            string consulta = "insert into proveedor values('" + proveedor.Nombre + "'," +                                                           
                                                           "'" + proveedor.Telefono + "'," +
                                                           "'" + proveedor.Direccion + "'," +
                                                           "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Proveedor ObtenerProveedorId(int id)
        {
            string consulta = "SELECT * FROM proveedor WHERE idProveedor = " + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Proveedor proveedor = new Proveedor();
            if (tabla.Rows.Count > 0)
            {
                proveedor.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idProveedor"]);
                proveedor.Nombre = tabla.Rows[0]["nombre"].ToString();
                proveedor.Telefono = tabla.Rows[0]["telefono"].ToString();
                proveedor.Direccion = tabla.Rows[0]["direccion"].ToString();
                proveedor.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return proveedor;
        }

        public void EditarProveedorDal(Proveedor proveedor)
        {
            string consulta = "UPDATE proveedor SET nombre = '" + proveedor.Nombre +
                              "', telefono = '" + proveedor.Telefono +
                              "', direccion = '" + proveedor.Direccion +
                              "', estado = '" + proveedor.Estado + "' " +
                              "WHERE idProveedor = " + proveedor.IdProveedor;
            conexion.Ejecutar(consulta);
        }

        public void EliminarProveedorDal(int id)
        {
            string consulta = "DELETE FROM proveedor WHERE idProveedor = " + id;
            conexion.Ejecutar(consulta);
        }
    }
}
