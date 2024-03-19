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
    public partial class DetalleVentaEditarVista : Form
    {
        int idDetalleVenta = 0;
        DetalleVenta detalleVenta = new DetalleVenta();
        DetalleVentaBss bss = new DetalleVentaBss();
        public DetalleVentaEditarVista(int id)
        {
            idDetalleVenta = id;
            InitializeComponent();
        }
        private void DetalleVentaEditarVista_Load(object sender, EventArgs e)
        {
            detalleVenta = bss.ObtenerDetalleVentaId(idDetalleVenta);
            textBox1.Text = detalleVenta.IdVenta.ToString();
            textBox2.Text = detalleVenta.IdProducto.ToString();
            textBox3.Text = detalleVenta.Cantidad.ToString();
            textBox4.Text = detalleVenta.PrecioVenta.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            detalleVenta.IdVenta = int.Parse(textBox1.Text);
            detalleVenta.IdProducto = int.Parse(textBox2.Text);
            detalleVenta.Cantidad = int.Parse(textBox1.Text);
            detalleVenta.PrecioVenta = decimal.Parse(textBox1.Text);


            bss.EditarDetalleVentaBss(detalleVenta);
            MessageBox.Show("Detalle de venta actualizado correctamente.");
        }
    }
}
