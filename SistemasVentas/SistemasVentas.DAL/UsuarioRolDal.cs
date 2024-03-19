using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioRolDal
    {
        public DataTable ListarUsuarioRolDal()
        {
            string consulta = "select * from UsuarioRol";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;

        }
        public void InsertarUsuarioRolDal(UsuarioRol usuarioRol)
        {
            string consulta = "insert into usuariorol values('" + usuarioRol.IdUsuario + "'," +
                                                           "'" + usuarioRol.IdRol + "'," +
                                                      "'" + usuarioRol.FechaAsigna.ToString("yyyy-MM-dd") + "'," +
                                                           "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public UsuarioRol ObtenerUsuarioRolId(int id)
        {
            string consulta = "SELECT * FROM usuarioRol WHERE idUsuarioRol = " + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            UsuarioRol usuarioRol = new UsuarioRol();
            if (tabla.Rows.Count > 0)
            {
                usuarioRol.IdUsuarioRol = Convert.ToInt32(tabla.Rows[0]["idUsuarioRol"]);
                usuarioRol.IdUsuario = Convert.ToInt32(tabla.Rows[0]["idUsuario"]);
                usuarioRol.IdRol = Convert.ToInt32(tabla.Rows[0]["idRol"]);
                usuarioRol.FechaAsigna = Convert.ToDateTime(tabla.Rows[0]["fechaAsigna"]);
                usuarioRol.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return usuarioRol;
        }

        public void EditarUsuarioRolDal(UsuarioRol usuarioRol)
        {
            string consulta = "UPDATE usuarioRol SET idUsuario = " + usuarioRol.IdUsuario +
                              ", idRol = " + usuarioRol.IdRol +
                              ", fechaAsigna = '" + usuarioRol.FechaAsigna.ToString("yyyy-MM-dd") +
                              "', estado = '" + usuarioRol.Estado + "' " +
                              "WHERE idUsuarioRol = " + usuarioRol.IdUsuarioRol;
            conexion.Ejecutar(consulta);
        }

        public void EliminarUsuarioRolDal(int id)
        {
            string consulta = "DELETE FROM usuarioRol WHERE idUsuarioRol = " + id;
            conexion.Ejecutar(consulta);
        }
    }
}
