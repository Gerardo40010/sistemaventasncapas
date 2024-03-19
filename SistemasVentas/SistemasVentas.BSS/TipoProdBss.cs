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
    public class TipoProdBss
    {
        TipoProdDal dal = new TipoProdDal();
        public DataTable ListarTipoProdBss()
        {
            return dal.ListarTipoProdDal();
        }
        public void InsertarTipoProdBss(TipoProd tipoProd)
        {
            dal.InsertarTipoProdDal(tipoProd);
        }
        public TipoProd ObtenerTipoProdId(int id)
        {
            return dal.ObtenerTipoProdId(id);
        }

        public void EditarTipoProdBss(TipoProd tipoProd)
        {
            dal.EditarTipoProdDal(tipoProd);
        }

        public void EliminarTipoProdBss(int id)
        {
            dal.EliminarTipoProdDal(id);
        }
    }
}
