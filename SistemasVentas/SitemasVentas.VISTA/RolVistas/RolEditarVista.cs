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

namespace SitemasVentas.VISTA.RolVistas
{
    public partial class RolEditarVista : Form
    {
        int idRol = 0;
        Rol rol = new Rol();
        RolBss bss = new RolBss();

        public RolEditarVista(int id)
        {
            idRol = id;
            InitializeComponent();
        }
        private void RolEditarVista_Load(object sender, EventArgs e)
        {
            rol = bss.ObtenerRolId(idRol);
            textBox1.Text = rol.Nombre;
          
        }










        private void button1_Click(object sender, EventArgs e)
        {
            rol.Nombre = textBox1.Text;
            bss.EditarRolBss(rol);
            MessageBox.Show("Rol actualizado correctamente.");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
