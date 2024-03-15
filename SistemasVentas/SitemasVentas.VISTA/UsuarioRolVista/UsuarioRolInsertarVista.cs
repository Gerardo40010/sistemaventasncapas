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

namespace SitemasVentas.VISTA.UsuarioRolVista
{
    public partial class UsuarioRolInsertarVista : Form
    {
        public UsuarioRolInsertarVista()
        {
            InitializeComponent();
        }

        UsuarioRolBss bss = new UsuarioRolBss();

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRol usuarioRol = new UsuarioRol();
            usuarioRol.IdUsuario = int.Parse(textBox1.Text);
            usuarioRol.IdRol = int.Parse(textBox2.Text);
            usuarioRol.FechaAsigna = dateTimePicker1.Value;
            bss.InsertarUsuarioRolBss(usuarioRol);
            MessageBox.Show("Se guardó correctamente el registro en UsuarioRol");
        }

    }
}
