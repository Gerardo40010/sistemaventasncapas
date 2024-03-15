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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SitemasVentas.VISTA.DetalleingVistas
{
    public partial class DetalleingInsertarVistas : Form
    {
        public DetalleingInsertarVistas()
        {
            InitializeComponent();
        }

        DetalleIngBss bss = new DetalleIngBss();

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleIng detalleIng = new DetalleIng();
            detalleIng.IdIngreso = int.Parse(textBox1.Text); // Asignar el Id del ingreso
            detalleIng.IdProducto = int.Parse(textBox2.Text);
            detalleIng.Cantidad = int.Parse(textBox4.Text);
            detalleIng.PrecioCosto = decimal.Parse(textBox5.Text);
            detalleIng.PrecioVenta = decimal.Parse(textBox6.Text);
            detalleIng.FechaVenc = dateTimePicker1.Value; 

            // Calcular el subtotal multiplicando la cantidad por el precio de venta
            detalleIng.Subtotal = detalleIng.Cantidad * detalleIng.PrecioVenta;

            bss.InsertarDetalleIngBss(detalleIng);
            MessageBox.Show("Se guardó correctamente el detalle de ingreso");
        }
    }
}
