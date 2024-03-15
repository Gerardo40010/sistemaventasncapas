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
    public partial class ClienteInsertarVista : Form
    {
        public ClienteInsertarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.IdPersona=Convert.ToInt32(textBox1.Text);
            cliente.TipoCliente = textBox2.Text;
            cliente.CodigoCliente=textBox3.Text;
            bss.InsertarClienteBss(cliente);
            MessageBox.Show("Se guardó correctamente el cliente");
        }
    }
}
