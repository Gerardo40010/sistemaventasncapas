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
    public partial class VentaEditarVista : Form
    {
        int idVenta = 0;
        Venta venta = new Venta();
        VentaBss bss = new VentaBss();

        public VentaEditarVista(int id)
        {
            idVenta = id;
            InitializeComponent();
        }

        private void VentaEditarVista_Load(object sender, EventArgs e)
        {
            venta = bss.ObtenerVentaId(idVenta);
            textBox1.Text = venta.IdCliente.ToString();
            textBox2.Text = venta.IdVendedor.ToString();
            dateTimePicker1.Value = venta.Fecha;
            textBox3.Text = venta.Total.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            venta.IdCliente = int.Parse(textBox1.Text);
            venta.IdVendedor = int.Parse(textBox2.Text);
            venta.Fecha = dateTimePicker1.Value;
            venta.Total = decimal.Parse(textBox3.Text);


            bss.EditarVentaBss(venta);
            MessageBox.Show("Venta actualizada correctamente.");
        }
    }
}
