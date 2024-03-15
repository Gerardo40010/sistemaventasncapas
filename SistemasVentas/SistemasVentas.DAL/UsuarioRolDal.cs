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

    }
}
