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

namespace SitemasVentas.VISTA.DetalleingVistas
{
    public partial class DetalleignEditarVistas : Form
    {
        int idDetalleIng = 0;
        DetalleIng detalleIng = new DetalleIng();
        DetalleIngBss bss = new DetalleIngBss();
        public DetalleignEditarVistas(int id)
        {
            idDetalleIng = id;
            InitializeComponent();
        }
        private void DetalleIngEditarVistas_Load(object sender, EventArgs e)
        {
            detalleIng = bss.ObtenerDetalleIngId(idDetalleIng);
            textBox1.Text = detalleIng.IdIngreso.ToString();
            textBox2.Text = detalleIng.IdProducto.ToString();
            dateTimePicker1.Value = detalleIng.FechaVenc;
            textBox4.Text = detalleIng.Cantidad.ToString();
            textBox5.Text = detalleIng.PrecioCosto.ToString();
            textBox6.Text = detalleIng.PrecioVenta.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            detalleIng.IdIngreso = int.Parse(textBox1.Text);
            detalleIng.IdProducto = int.Parse(textBox2.Text);
            detalleIng.FechaVenc = dateTimePicker1.Value;
            detalleIng.Cantidad = int.Parse(textBox4.Text);
            detalleIng.PrecioCosto = decimal.Parse(textBox5.Text);
            detalleIng.PrecioVenta = decimal.Parse(textBox6.Text);
            bss.EditarDetalleIngBss(detalleIng);
            MessageBox.Show("Detalle de ingreso actualizado correctamente.");
        }
    }
}
