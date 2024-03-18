using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.Modelos;
namespace SistemasVentas.DAL
{
    public class PersonaDal
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "select * from persona";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
            
        }
        public void InsertarPersonaDal(Persona persona)
        {
            string consulta = "insert into persona values('"+persona.Nombre+"',"+
                                                          "'"+persona.Apellido+"',"+
                                                          "'" +persona.Telefono+"',"+
                                                          "'"+persona.CI+ "',"+
                                                          "'"+persona.Correo+ "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Persona ObtenerPersonaId(int id)
        {
            string consulta = "select * from persona where idpersona=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Persona persona = new Persona();
            if (tabla.Rows.Count > 0)
            {
              
                persona.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                persona.Nombre = tabla.Rows[0]["nombre"].ToString();
                persona.Apellido = tabla.Rows[0]["apellido"].ToString();
                persona.Telefono = tabla.Rows[0]["telefono"].ToString();
                persona.CI = tabla.Rows[0]["ci"].ToString();
                persona.Correo = tabla.Rows[0]["correo"].ToString();
                persona.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return persona;
        }
        public void EditarPersonaDal (Persona persona)
        {
            string consulta = "update persona set nombre='" + persona.Nombre + "'," +
                                                        "apellido='" + persona.Apellido + "'," +
                                                        "telefono='" + persona.Telefono + "'," +
                                                        "ci='" + persona.CI + "'," +
                                                        "correo='" + persona.Correo + "' " +
                                                        "where idpersona=" + persona.IdPersona;
            conexion.Ejecutar(consulta);
        }
        public void EliminarPersonaDal(int id)
        {
            string consulta = "delete from persona where idpersona=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
