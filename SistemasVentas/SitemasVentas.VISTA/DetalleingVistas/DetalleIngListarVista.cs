﻿using SistemasVentas.BSS;
using SitemasVentas.VISTA.PersonasVistas;
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
    public partial class DetalleIngListarVista : Form
    {
        public DetalleIngListarVista()
        {
            InitializeComponent();
        }
        DetalleIngBss bss = new DetalleIngBss();
        private void DetalleIngListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarDetalleIngBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetalleingInsertarVistas fr = new DetalleingInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarDetalleIngBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idDetalleIngSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdDetalleIng"].Value);
            DetalleignEditarVistas fr = new DetalleignEditarVistas(idDetalleIngSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarDetalleIngBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idDetalleIngSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Estas seguro de eliminar esta  persona", "Eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarDetalleIngBss(idDetalleIngSeleccionado);
                dataGridView1.DataSource = bss.ListarDetalleIngBss();
            }
        }
    }
}
