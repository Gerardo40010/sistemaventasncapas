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

namespace SitemasVentas.VISTA.ProveeVistas
{
    public partial class ProveeEditarVista : Form
    {
        int idProvee = 0;
        Provee provee = new Provee();
        ProveeBss bss = new ProveeBss();

        public ProveeEditarVista(int id)
        {
            idProvee = id;
            InitializeComponent();
        }
        private void ProveeEditarVista_Load(object sender, EventArgs e)
        {
            provee = bss.ObtenerProveeId(idProvee);
            textBox1.Text = provee.IdProducto.ToString();
            textBox2.Text = provee.IdProveedor.ToString();
            dateTimePicker1.Value = provee.Fecha;
            textBox3.Text = provee.Precio.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            provee.IdProducto = int.Parse(textBox1.Text);
            provee.IdProveedor = int.Parse(textBox2.Text);
            provee.Fecha = dateTimePicker1.Value;
            provee.Precio = decimal.Parse(textBox3.Text);

            bss.EditarProveeBss(provee);
            MessageBox.Show("Relación producto-proveedor actualizada correctamente.");
        }
    }
}
