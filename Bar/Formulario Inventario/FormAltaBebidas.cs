using Bar.Formulario_Empleados;
using Entidades;
using Entidades.Bebidas;
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
        Controlador controlador = new Controlador();
        public FormAltaBebidas()
        {
            InitializeComponent();
        }

        private void FormAltaBebidas_Load(object sender, EventArgs e)
        {
            foreach (var tipo in Enum.GetValues(typeof(TiposBebidasAlcoholicas)))
            {
                cmbPuesto.Items.Add(tipo);
            }
        }

        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            if (controlador.AltaBebidaAlcoholica(txtNombre.Text, txtApellido.Text, txtEdad.Text, txtMLitros.Text, txtDni.Text, txtDescripcion.Text, cmbTipoBebida.SelectedIndex))
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
