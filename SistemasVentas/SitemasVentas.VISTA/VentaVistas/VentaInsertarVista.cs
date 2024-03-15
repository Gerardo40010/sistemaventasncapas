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

namespace SitemasVentas.VISTA.VentaVistas
{
    public partial class VentaInsertarVista : Form
    {
        public VentaInsertarVista()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        VentaBss bss = new VentaBss();

        private void button1_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.IdCliente = int.Parse(textBox1.Text);
            venta.IdVendedor = int.Parse(textBox2.Text);
            venta.Fecha = DateTime.Now; 
            venta.Total = decimal.Parse(textBox3.Text);
            bss.InsertarVentaBss(venta);
            MessageBox.Show("Se guardó correctamente la venta");
        }

    }
}
