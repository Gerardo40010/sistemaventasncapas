using SistemasVentas.DAL;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class ClienteBss
    {
        ClienteDal dal = new ClienteDal();
        public DataTable ListarClienteBss()
        {
            return dal.ListarClientesDal();
        }
        public void InsertarClienteBss(Cliente cliente)
        {
            dal.InsertarClienteDal(cliente);
        }
        public Cliente ObtenerClienteId(int id)
        {
            return dal.ObtenerClienteId(id);
        }

        public void EditarClienteBss(Cliente cliente)
        {
            dal.EditarClienteDal(cliente);
        }

        public void EliminarClienteBss(int id)
        {
            dal.EliminarClienteDal(id);
        }
    }
}
