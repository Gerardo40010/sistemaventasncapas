using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClientesDal()
        {
            string consulta = "select * from cliente";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;

        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into cliente values('" + cliente.IdPersona + "'," +
                                                           "'" + cliente.TipoCliente + "'," +
                                                           "'" + cliente.CodigoCliente + "'," +
                                                           "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Cliente ObtenerClienteId(int id)
        {
            string consulta = "SELECT * FROM cliente WHERE idcliente=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Cliente cliente = new Cliente();
            if (tabla.Rows.Count > 0)
            {
                cliente.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                cliente.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                cliente.TipoCliente = tabla.Rows[0]["tipocliente"].ToString();
                cliente.CodigoCliente = tabla.Rows[0]["codigocliente"].ToString();
                cliente.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return cliente;
        }

        public void EditarClienteDal(Cliente cliente)
        {
            string consulta = "UPDATE cliente SET idpersona=" + cliente.IdPersona + "," +
                                                   "tipocliente='" + cliente.TipoCliente + "'," +
                                                   "codigocliente='" + cliente.CodigoCliente + "'," +
                                                    "estado='" + cliente.Estado + "' " +

                                                   "WHERE idcliente=" + cliente.IdCliente;
            conexion.Ejecutar(consulta);
        }

        public void EliminarClienteDal(int id)
        {
            string consulta = "DELETE FROM cliente WHERE idcliente=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
