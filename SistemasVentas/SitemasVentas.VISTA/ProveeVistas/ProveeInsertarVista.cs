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
    public partial class ProveeInsertarVista : Form
    {
        public ProveeInsertarVista()
        {
            InitializeComponent();
        }

        ProveeBss bss = new ProveeBss();

        private void button1_Click(object sender, EventArgs e)
        {
            Provee provee = new Provee();
            provee.IdProducto = int.Parse(textBox1.Text);
            provee.IdProveedor = int.Parse(textBox2.Text);
            provee.Fecha = dateTimePicker1.Value;
            provee.Precio = decimal.Parse(textBox3.Text);

            bss.InsertarProveeBss(provee);
            MessageBox.Show("Se guardó correctamente el registro en Provee");
        }
    }
}
