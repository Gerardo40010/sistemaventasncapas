using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioDal
    {
        public DataTable ListarUsuarioDal()
        {
            string consulta = "select * from Usuario";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;

        }

        public void InsertarUsuarioDal(Usuario usuario)
        {
            string consulta = "insert into usuario values(" + usuario.IdPersona + "," +
                                                          "'" + usuario.NombreUser + "'," +
                                                           "'" + usuario.Contraseña + "'," +
                                                "'" + usuario.FechaReg.ToString("yyyy-MM-dd") + "')";

            conexion.Ejecutar(consulta);
        }
        public Usuario ObtenerUsuarioId(int id)
        {
            string consulta = "SELECT * FROM usuario WHERE idUsuario = " + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Usuario usuario = new Usuario();
            if (tabla.Rows.Count > 0)
            {
                usuario.IdUsuario = Convert.ToInt32(tabla.Rows[0]["idUsuario"]);
                usuario.IdPersona = Convert.ToInt32(tabla.Rows[0]["idPersona"]);
                usuario.NombreUser = tabla.Rows[0]["nombreUser"].ToString();
                usuario.Contraseña = tabla.Rows[0]["contraseña"].ToString();
                usuario.FechaReg = Convert.ToDateTime(tabla.Rows[0]["fechaReg"]);
            }
            return usuario;
        }

        public void EditarUsuarioDal(Usuario usuario)
        {
            string consulta = "UPDATE usuario SET idPersona = " + usuario.IdPersona +
                              ", nombreUser = '" + usuario.NombreUser +
                              "', contraseña = '" + usuario.Contraseña +
                              "', fechaReg = '" + usuario.FechaReg.ToString("yyyy-MM-dd") + "' " +
                              "WHERE idUsuario = " + usuario.IdUsuario;
            conexion.Ejecutar(consulta);
        }

        public void EliminarUsuarioDal(int id)
        {
            string consulta = "DELETE FROM usuario WHERE idUsuario = " + id;
            conexion.Ejecutar(consulta);
        }
    }
}
