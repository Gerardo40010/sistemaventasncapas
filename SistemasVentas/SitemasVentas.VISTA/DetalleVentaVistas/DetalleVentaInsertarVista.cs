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

namespace SitemasVentas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaInsertarVista : Form
    {
        public DetalleVentaInsertarVista()
        {
            InitializeComponent();
        }

        DetalleVentaBss bss = new DetalleVentaBss();

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVenta detalleVenta = new DetalleVenta();
            detalleVenta.IdVenta = int.Parse(textBox1.Text);
            detalleVenta.IdProducto = int.Parse(textBox2.Text);
            detalleVenta.Cantidad = int.Parse(textBox3.Text);
            detalleVenta.PrecioVenta = decimal.Parse(textBox4.Text);

          
            detalleVenta.Subtotal = detalleVenta.Cantidad * detalleVenta.PrecioVenta;

            bss.InsertarDetalleVentaBss(detalleVenta);
            MessageBox.Show("Se guardó correctamente el detalle de venta");
        }

    }
}
