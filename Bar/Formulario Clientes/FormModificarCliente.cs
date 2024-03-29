﻿using Entidades;
using Entidades.Clientes;
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

namespace Bar.Formulario_Clientes
{
    public partial class FormModificarCliente : FormAltaCliente
    {
        Controlador controlador = new Controlador();
        protected Cliente cliente;
        public FormModificarCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void FormModificarCliente_Load(object sender, EventArgs e)
        {
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtDni.Text = cliente.Dni.ToString();
            txtEdad.Text = cliente.Edad.ToString();
            cmbBebidaFavorita.SelectedIndex = (int)cliente.Frecuencia;
        }

        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cmbBebidaFavorita.Text))
                {
                    controlador.ModificarCliente(cliente, txtNombre.Text, txtApellido.Text, txtEdad.Text, txtDni.Text, (int)cmbBebidaFavorita.SelectedIndex);
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
