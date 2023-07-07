using Entidades;
using Entidades.Usuarios;
using System.Reflection;

namespace Bar
{
    public partial class Login : Form
    {
        Usuario usuario;
        Controlador controlador = new Controlador();

        public Login()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.ValidarUsuario(txt_NombreUsuario.Text, txt_Contrase�a.Text, out usuario);
                MenuPrincipal menuPrincipal = new MenuPrincipal(usuario);
                menuPrincipal.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string nombreClse = MethodBase.GetCurrentMethod().DeclaringType.Name;
                string nombreMetodo = MethodBase.GetCurrentMethod().Name;
                controlador.LogsErrores(ex, nombreClse, nombreMetodo);
            }           
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void picAutoLogeo_Click(object sender, EventArgs e)
        {
            txt_NombreUsuario.Text = "aaa";
            txt_Contrase�a.Text = "aaa";
        }
    }
}