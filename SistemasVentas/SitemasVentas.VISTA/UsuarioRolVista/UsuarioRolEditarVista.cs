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
    public partial class UsuarioRolEditarVista : Form
    {
        int idUsuarioRol = 0;
        UsuarioRol usuarioRol = new UsuarioRol();
        UsuarioRolBss bss = new UsuarioRolBss();

        public UsuarioRolEditarVista(int id)
        {
            idUsuarioRol = id;
            InitializeComponent();
        }

        private void UsuarioRolEditarVista_Load(object sender, EventArgs e)
        {
            usuarioRol = bss.ObtenerUsuarioRolId(idUsuarioRol);
            textBox1.Text = usuarioRol.IdUsuario.ToString();
            textBox2.Text = usuarioRol.IdRol.ToString();
            dateTimePicker1.Value = usuarioRol.FechaAsigna;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuarioRol.IdUsuario = int.Parse(textBox1.Text);
            usuarioRol.IdRol = int.Parse(textBox2.Text);
            usuarioRol.FechaAsigna = dateTimePicker1.Value;
            bss.EditarUsuarioRolBss(usuarioRol);
            MessageBox.Show("Asignación de usuario-rol actualizada correctamente.");
        }
    }
}
