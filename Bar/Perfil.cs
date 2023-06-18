using Bar.Properties;
using Entidades.Usuarios;
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
    public partial class Perfil : Form
    {
        Usuario usuario;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return createParams;
            }
        }
        public Perfil(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            txtNombreUsuario.Text = usuario.NombreUsuario;
            txtPassword.Text = usuario.Contraseña;
            txtNombreUsuario.ReadOnly = true;
            txtPassword.ReadOnly = true;

            lbl_nombre.Text = this.usuario.Empleado.Nombre;
            lbl_apellido.Text = this.usuario.Empleado.Apellido;
            lbl_edad.Text = this.usuario.Empleado.Edad.ToString();
            lbl_dni.Text = this.usuario.Empleado.Dni.ToString();
            lbl_sueldo.Text = this.usuario.Empleado.Sueldo.ToString();
            lbl_id.Text = this.usuario.Empleado.Id.ToString();
            lbl_puesto.Text = this.usuario.Empleado.Puesto.ToString();
            cmbAvatar.Items.Add("Doctor Strange");
            cmbAvatar.Items.Add("Ironman");
            cmbAvatar.Items.Add("Black Widow");
            cmbAvatar.Items.Add("Spiderman");

        }


        private void btnModificar_Click(object sender, EventArgs e)
        {

            DialogResult dg = MessageBox.Show("Esta seguro que desea cambiar su nombre de usuario o contraseña?", "Precaucion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dg == DialogResult.Yes)
            {
                txtNombreUsuario.Text = "";
                txtPassword.Text = "";
                txtNombreUsuario.ReadOnly = false;
                txtPassword.ReadOnly = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.usuario.NombreUsuario = txtNombreUsuario.Text;
            this.usuario.Contraseña = txtPassword.Text;
            MessageBox.Show("Se guardaron los cambios correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardarFoto_Click(object sender, EventArgs e)
        {
            switch (cmbAvatar.SelectedIndex)
            {
                case 0:
                    picAvatar.BackgroundImage = Resources.DocStrange;
                    break;
                case 1:
                    picAvatar.BackgroundImage = Resources.IronMan;
                    break;
                case 2:
                    picAvatar.BackgroundImage = Resources.BlackWidow;
                    break;
                case 3:
                    picAvatar.BackgroundImage = Resources.SpiderMan;
                    break;
            }

            picAvatar.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
