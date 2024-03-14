using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SitemasVentas.VISTA.TipoProdVistas
{
    public partial class TipoProdListarVista : Form
    {
        public TipoProdListarVista()
        {
            InitializeComponent();
        }
        TipoProdBss bss = new TipoProdBss();
        private void TipoProdListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarTipoProdBss();
        }
    }
}
