using Entidades;
using Entidades.Usuarios;

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
                if (controlador.ValidarUsuario(txt_NombreUsuario.Text, txt_Contraseña.Text, out usuario))
                {
                    MenuPrincipal menuPrincipal = new MenuPrincipal(usuario);
                    menuPrincipal.Show();
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void picAutoLogeo_Click(object sender, EventArgs e)
        {
            txt_NombreUsuario.Text = "aaa";
            txt_Contraseña.Text = "aaa";
        }
    }
}