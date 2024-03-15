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

namespace SitemasVentas.VISTA.IngresoVistas
{
    public partial class IngresoInsertarVista : Form
    {
        public IngresoInsertarVista()
        {
            InitializeComponent();
        }

        IngresoBss bss = new IngresoBss();

        private void button1_Click(object sender, EventArgs e)
        {
            Ingreso ingreso = new Ingreso();
            ingreso.IdProveedor = int.Parse(textBox1.Text);
            ingreso.FechaIngreso = dateTimePicker1.Value;
            ingreso.Total = decimal.Parse(textBox4.Text);

            bss.InsertarIngresoBss(ingreso);
            MessageBox.Show("Se guardó correctamente el registro de ingreso");
        }

    }
}
