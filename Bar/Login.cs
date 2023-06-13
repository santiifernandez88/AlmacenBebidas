using Entidades;


namespace Bar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            Usuario usuario;

            if (Controlador.ValidarUsuario(txt_NombreUsuario.Text, txt_Contrase�a.Text, out usuario))
            {
                MenuPrincipal menuPrincipal = new MenuPrincipal(usuario);
                menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error de logeo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}