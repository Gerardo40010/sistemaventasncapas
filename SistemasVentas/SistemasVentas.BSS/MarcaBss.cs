using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.DAL;
using SistemaVentas.Modelos;

namespace SistemasVentas.BSS
{
    public class MarcaBss
    {
        MarcaDal dal = new MarcaDal();
        public DataTable ListarMarcaBss()
        {
            return dal.ListarMarcaDal();
        }
        public void InsertarMarcaBss(Marca marca)
        {
            dal.InsertarMarcaDal(marca);
        }
        public Marca ObtenerMarcaId(int id)
        {
            return dal.ObtenerMarcaId(id);
        }

        public void EditarMarcaBss(Marca marca)
        {
            dal.EditarMarcaDal(marca);
        }

        public void EliminarMarcaBss(int id)
        {
            dal.EliminarMarcaDal(id);
        }
    }
  
}
