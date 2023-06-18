﻿using Bar.Formulario_Empleados;
using Bar.Formulario_Inventario;
using Entidades;
using Entidades.Bebidas;
using Entidades.Clientes;
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

namespace Bar.Formulario_Clientes
{
    public partial class FormAltaCliente : FormAltaEmpleado
    {
        Controlador controlador = new Controlador();
        public FormAltaCliente()
        {
            InitializeComponent();
        }

        private void FormAltaCliente_Load(object sender, EventArgs e)
        {
            foreach (var estatus in Enum.GetValues(typeof(Estatus)))
            {
                cmbBebidaFavorita.Items.Add(estatus);
            }
           
        }

        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            if (controlador.AltaCliente(txtNombre.Text, txtApellido.Text, txtEdad.Text, txtDni.Text, cmbBebidaFavorita.SelectedIndex))
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
