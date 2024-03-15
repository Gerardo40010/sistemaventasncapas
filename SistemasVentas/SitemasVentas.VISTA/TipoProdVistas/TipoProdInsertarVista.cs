using SistemasVentas.BSS;
using SistemaVentas.Modelos;
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
    public partial class TipoProdInsertarVista : Form
    {
        public TipoProdInsertarVista()
        {
            InitializeComponent();
        }

        TipoProdBss bss = new TipoProdBss();

        private void button1_Click(object sender, EventArgs e)
        {
            TipoProd tipoProd = new TipoProd();
            tipoProd.Nombre = textBox1.Text;
            bss.InsertarTipoProdBss(tipoProd);
            MessageBox.Show("Se guardó correctamente el tipo de producto");
        }

    }
}
