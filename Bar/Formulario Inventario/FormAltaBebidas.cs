using Bar.Formulario_Empleados;
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

namespace Bar.Formulario_Inventario
{
    public partial class FormAltaBebidas : FormAltaEmpleado
    {
        public FormAltaBebidas()
        {
            InitializeComponent();
        }

        private void FormAltaBebidas_Load(object sender, EventArgs e)
        {
            cmbTipoBebida.Items.Add(TiposDeBebida.Licor);
            cmbTipoBebida.Items.Add(TiposDeBebida.Gin);
            cmbTipoBebida.Items.Add(TiposDeBebida.Vino);
            cmbTipoBebida.Items.Add(TiposDeBebida.Fernet);
            cmbTipoBebida.Items.Add(TiposDeBebida.Cerveza);
            cmbTipoBebida.Items.Add(TiposDeBebida.Whiskey);
            cmbTipoBebida.Items.Add(TiposDeBebida.Vodka);
        }



        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Controlador.CrearBebida(txtNombre.Text, txtApellido.Text, txtEdad.Text, txtDni.Text, cmbTipoBebida.SelectedIndex))
            {
                MessageBox.Show("Se pudo agregar la bebida al inventario.");
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se pudo agregar la bebida al inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
