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

namespace SitemasVentas.VISTA.ProductoVistas
{
    public partial class ProductoInsertarVista : Form
    {
        public ProductoInsertarVista()
        {
            InitializeComponent();
        }

        ProductoBss bss = new ProductoBss();

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.IdTipoProd = int.Parse(textBox1.Text);
            producto.IdMarca = int.Parse(textBox2.Text);
            producto.Nombre = textBox3.Text;
            producto.CodigoBarra = textBox4.Text;
            producto.Unidad = int.Parse(textBox5.Text);
            producto.Descripcion = textBox6.Text;

            bss.InsertarProductoBss(producto);
            MessageBox.Show("Se guardó correctamente el producto");
        }

    }
}
