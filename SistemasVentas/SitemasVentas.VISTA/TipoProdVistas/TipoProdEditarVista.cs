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
    public partial class TipoProdEditarVista : Form
    {
        int idTipoProd = 0;
        TipoProd tipoProd = new TipoProd();
        TipoProdBss bss = new TipoProdBss();

        public TipoProdEditarVista(int id)
        {
            idTipoProd = id;
            InitializeComponent();
        }

        private void TipoProdEditarVista_Load(object sender, EventArgs e)
        {
            tipoProd = bss.ObtenerTipoProdId(idTipoProd);
            textBox1.Text = tipoProd.Nombre;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tipoProd.Nombre = textBox1.Text;
            bss.EditarTipoProdBss(tipoProd);
            MessageBox.Show("Tipo de producto actualizado correctamente.");
        }
    }
}
