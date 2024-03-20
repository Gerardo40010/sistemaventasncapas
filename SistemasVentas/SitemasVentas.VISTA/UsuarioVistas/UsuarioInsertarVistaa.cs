using SistemasVentas.BSS;
using SistemaVentas.Modelos;
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

namespace SitemasVentas.VISTA.UsuarioVistas
{
    public partial class UsuarioInsertarVistaa : Form
    {
        public UsuarioInsertarVistaa()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bss = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bss.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;

            }
        }
        UsuarioBss bssuser = new UsuarioBss();
        private void button2_Click(object sender, EventArgs e)
        {
           
                Usuario usuario = new Usuario();
            usuario.IdPersona = IdPersonaSeleccionada;
                usuario.NombreUser = textBox2.Text;
                usuario.Contraseña = textBox3.Text;
                usuario.FechaReg = dateTimePicker1.Value;
            bssuser.InsertarUsuarioBss(usuario);
                MessageBox.Show("Se guardó correctamente el usuario");
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
