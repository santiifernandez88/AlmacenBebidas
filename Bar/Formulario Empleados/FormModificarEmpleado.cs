using Entidades;
using Entidades.Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar.Formulario_Empleados
{
    public partial class FormModificarEmpleado : FormAltaEmpleado
    {
        Controlador controlador = new Controlador();
        Empleado empleado;
        public FormModificarEmpleado(Empleado empleado)
        {
            InitializeComponent();
            this.empleado = empleado;
        }

        private void FormModificarEmpleado_Load(object sender, EventArgs e)
        {
            txtContraseña.Visible = false;
            txtNombreUsuario.Visible = false;
            label5.Visible = false;
            base.cmbPuesto.Visible = false;
            lblContraseña.Visible = false;
            lblNombreUsuario.Visible = false;
            lblAlta.Text = "Modificar empleado";
            txtApellido.Text = empleado.Apellido;
            txtNombre.Text = empleado.Nombre;
            txtEdad.Text = empleado.Edad.ToString();
            txtDni.Text = empleado.Dni.ToString();
            txtSueldo.Text = empleado.Sueldo.ToString();
            foreach (var puesto in Enum.GetValues(typeof(PuestosDeTrabajo)))
            {
                cmbPuesto.Items.Add(puesto);
            }
            cmbPuestoTrabajo.SelectedIndex = (int)empleado.Puesto;

        }

        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cmbPuesto.Text))
                {
                    controlador.ModificarEmpleado(empleado, txtNombre.Text, txtApellido.Text, txtEdad.Text, txtDni.Text, txtSueldo.Text, (int)cmbPuestoTrabajo.SelectedIndex);
                    MessageBox.Show("Se pudo modificar el empleado correctamente", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                }                  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                string nombreClse = MethodBase.GetCurrentMethod().DeclaringType.Name;
                string nombreMetodo = MethodBase.GetCurrentMethod().Name;
                controlador.LogsErrores(ex, nombreClse, nombreMetodo);
            }
        }
    }
}