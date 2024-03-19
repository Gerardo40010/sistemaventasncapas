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

namespace SitemasVentas.VISTA.ClienteVistas
{
    public partial class ClienteEditarVista : Form
    {
        int idx = 0;
        Cliente c = new Cliente();
        ClienteBss bss = new ClienteBss();
        public ClienteEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ClienteEditarVista_Load(object sender, EventArgs e)
        {
            c = bss.ObtenerClienteId(idx);
            textBox1.Text = c.TipoCliente;
            textBox2.Text = c.CodigoCliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.TipoCliente = textBox1.Text;
            c.CodigoCliente = textBox2.Text;

            bss.EditarClienteBss(c);
            MessageBox.Show("Datos actualizados");
        }
    }

}
