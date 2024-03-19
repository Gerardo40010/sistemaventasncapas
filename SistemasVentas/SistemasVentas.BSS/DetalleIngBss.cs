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
    public class DetalleIngBss
    {
        DetalleIngDal dal = new DetalleIngDal();
        public DataTable ListarDetalleIngBss()
        {
            return dal.ListarDetalleIngDal();
        }

        public void InsertarDetalleIngBss(DetalleIng detalleIng)
        {
            dal.InsertarDetalleIngDal(detalleIng);
        }
        public DetalleIng ObtenerDetalleIngId(int id)
        {
            return dal.ObtenerDetalleIngId(id);
        }

        public void EditarDetalleIngBss(DetalleIng detalleIng)
        {
            dal.EditarDetalleIngDal(detalleIng);
        }

        public void EliminarDetalleIngBss(int id)
        {
            dal.EliminarDetalleIngDal(id);
        }
    }

}
