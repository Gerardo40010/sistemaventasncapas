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
    public partial class ProductoEditarVista : Form
    {
        int idProducto = 0;
        Producto producto = new Producto();
        ProductoBss bss = new ProductoBss();

        public ProductoEditarVista(int id)
        {
            idProducto = id;
            InitializeComponent();
        }
        private void ProductoEditarVista_Load(object sender, EventArgs e)
        {
            producto = bss.ObtenerProductoId(idProducto);
            textBox3.Text = producto.Nombre;
            textBox4.Text = producto.CodigoBarra;
            textBox5.Text = producto.Unidad.ToString();
            textBox6.Text = producto.Descripcion;
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            producto.Nombre = textBox3.Text;
            producto.CodigoBarra = textBox4.Text;
            producto.Unidad = int.Parse(textBox5.Text);
            producto.Descripcion = textBox6.Text;
            bss.EditarProductoBss(producto);
            MessageBox.Show("Producto actualizado correctamente.");
        }
    }
}
