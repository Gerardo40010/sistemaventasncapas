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

namespace SitemasVentas.VISTA.IngresoVistas
{
    public partial class IngresoEditarVista : Form
    {
        int idIngreso = 0;
        Ingreso ingreso = new Ingreso();
        IngresoBss bss = new IngresoBss();
        public IngresoEditarVista(int id)
        {
            idIngreso = id;
            InitializeComponent();
        }
        private void IngresoEditarVista_Load(object sender, EventArgs e)
        {
            ingreso = bss.ObtenerIngresoId(idIngreso);
            textBox1.Text = ingreso.IdProveedor.ToString();
            dateTimePicker1.Value = ingreso.FechaIngreso;
            textBox4.Text = ingreso.Total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingreso.IdProveedor = int.Parse(textBox1.Text);
            ingreso.FechaIngreso = dateTimePicker1.Value;
            ingreso.Total = decimal.Parse(textBox4.Text);

            bss.EditarIngresoBss(ingreso);
            MessageBox.Show("Ingreso actualizado correctamente.");
        }
    }
}
