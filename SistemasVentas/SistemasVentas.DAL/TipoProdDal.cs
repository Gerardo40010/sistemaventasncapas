using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class TipoProdDal
    {
        public DataTable ListarTipoProdDal()
        {
            string consulta = "select * from TipoProd";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;

        }
        public void InsertarTipoProdDal(TipoProd tipoProd)
        {
            string consulta = "insert into tipoprod values('" + tipoProd.Nombre + "'," +
                                                           "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public TipoProd ObtenerTipoProdId(int id)
        {
            string consulta = "SELECT * FROM tipoprod WHERE idTipoProd = " + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            TipoProd tipoProd = new TipoProd();
            if (tabla.Rows.Count > 0)
            {
                tipoProd.IdTipoProd = Convert.ToInt32(tabla.Rows[0]["idTipoProd"]);
                tipoProd.Nombre = tabla.Rows[0]["nombre"].ToString();
                tipoProd.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return tipoProd;
        }

        public void EditarTipoProdDal(TipoProd tipoProd)
        {
            string consulta = "UPDATE tipoprod SET nombre = '" + tipoProd.Nombre +
                              "', estado = '" + tipoProd.Estado + "' " +
                              "WHERE idTipoProd = " + tipoProd.IdTipoProd;
            conexion.Ejecutar(consulta);
        }

        public void EliminarTipoProdDal(int id)
        {
            string consulta = "DELETE FROM tipoprod WHERE idTipoProd = " + id;
            conexion.Ejecutar(consulta);
        }

    }
}
