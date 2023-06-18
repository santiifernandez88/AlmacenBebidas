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

namespace Bar.Formulario_Empleados
{
    public partial class FormAltaEmpleado : Form
    {
        Controlador controlador = new Controlador();
        public FormAltaEmpleado()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            
            foreach(var puesto in Enum.GetValues(typeof(PuestosDeTrabajo)))
            {
                cmbPuesto.Items.Add(puesto);
            }                                  
        }

        public virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            if (controlador.AltaEmpleado(txtNombre.Text, txtApellido.Text, txtEdad.Text, txtDni.Text, txtSueldo.Text, txtNombreUsuario.Text, txtContraseña.Text, cmbPuesto.SelectedIndex))
            {
                MessageBox.Show("Se pudo crear correctamente el empleado.");
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se pudo crear correctamente el empleado");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Esta seguro que quiere resetear todos los campos?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
