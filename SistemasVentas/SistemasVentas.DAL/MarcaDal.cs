using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class MarcaDal
    {
        public DataTable ListarMarcaDal()
        {
            string consulta = "select * from marca";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;

        }
        public void InsertarMarcaDal(Marca marca)
        {
            string consulta = "insert into marca values('" + marca.Nombre + "'," +
                                                           "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Marca ObtenerMarcaId(int id)
        {
            string consulta = "SELECT * FROM marca WHERE idMarca = " + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Marca marca = new Marca();
            if (tabla.Rows.Count > 0)
            {
                marca.IdMarca = Convert.ToInt32(tabla.Rows[0]["idMarca"]);
                marca.Nombre = tabla.Rows[0]["nombre"].ToString();
                marca.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return marca;
        }

        public void EditarMarcaDal(Marca marca)
        {
            string consulta = "UPDATE marca SET nombre = '" + marca.Nombre +
                              "', estado = '" + marca.Estado + "' " +
                              "WHERE idMarca = " + marca.IdMarca;
            conexion.Ejecutar(consulta);
        }

        public void EliminarMarcaDal(int id)
        {
            string consulta = "DELETE FROM marca WHERE idMarca = " + id;
            conexion.Ejecutar(consulta);
        }
    }
}
