using Bar.Formulario_Clientes;
using Bar.Formulario_Empleados;
using Bar.Properties;
using Entidades;
using Entidades.Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar
{
    public partial class MenuPrincipal : Form
    {
        private Usuario usuario;

        public MenuPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            DatosPanel();
            if (this.usuario.Empleado.Puesto == PuestosDeTrabajo.Vendedor)
            {
                empleadosToolStripMenuItem.Visible = false;
            }
        }

        private void DatosPanel()
        {
            lblNombre.Text = this.usuario.Empleado.Nombre;
            lblApellido.Text = this.usuario.Empleado.Apellido;
            lblId.Text = this.usuario.Empleado.Id.ToString();
            lblTipoUsuario.Text = this.usuario.Empleado.Puesto.ToString();

            if(this.usuario.Empleado.Puesto == PuestosDeTrabajo.Jefe)
            {
                picFotoUser.BackgroundImage = Resources.SuperAdmin;
                picFotoUser.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                picFotoUser.BackgroundImage = Resources.User;
                picFotoUser.BackgroundImageLayout = ImageLayout.Stretch;
            }

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            DialogResult dg = MessageBox.Show("Estas seguro que quieres cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dg == DialogResult.Yes)
            {
                login.Show();
                this.Hide();
            }
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil(usuario);
            AbrirFormulario(perfil);
        }

        private void pnlDatos_Click(object sender, EventArgs e)
        {
            perfilToolStripMenuItem_Click(sender, e);
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpleado empleado = new FormEmpleado();
            empleado.UsuarioLogeado = usuario;
            AbrirFormulario(empleado);
        }

        private void AbrirFormulario(Form formAbrir)
        {
            formAbrir.MdiParent = this;
            formAbrir.FormBorderStyle = FormBorderStyle.None;
            formAbrir.Dock = DockStyle.Fill;
            formAbrir.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente cliente = new FormCliente();
            cliente.UsuarioLogeado = usuario;
            AbrirFormulario(cliente);
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            inventario.UsuarioLogeado = usuario;
            AbrirFormulario(inventario);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormVentas ventas = new FormVentas(usuario);
            AbrirFormulario(ventas);
        }
    }
}
