using Bar.Formulario_Empleados;
using Bar.Formulario_Inventario;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar.Formulario_Clientes
{
    public partial class FormAltaCliente : FormAltaEmpleado
    {
        public FormAltaCliente()
        {
            InitializeComponent();
        }

        private void FormAltaCliente_Load(object sender, EventArgs e)
        {
            cmbBebidaFavorita.Items.Add(TiposDeBebida.Vino);
            cmbBebidaFavorita.Items.Add(TiposDeBebida.Licor);
            cmbBebidaFavorita.Items.Add(TiposDeBebida.Vodka);
            cmbBebidaFavorita.Items.Add(TiposDeBebida.Gin);
            cmbBebidaFavorita.Items.Add(TiposDeBebida.Cerveza);
            cmbBebidaFavorita.Items.Add(TiposDeBebida.Vermu);
            cmbBebidaFavorita.Items.Add(TiposDeBebida.Whiskey);
            cmbBebidaFavorita.Items.Add(TiposDeBebida.Fernet);
        }

        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Controlador.CrearCliente(txtNombre.Text, txtApellido.Text, txtEdad.Text, txtDni.Text, cmbBebidaFavorita.SelectedIndex))
            {
                MessageBox.Show("Se agrego el cliente correctamente.", "Agregar cliente");
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se pudo agregar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
