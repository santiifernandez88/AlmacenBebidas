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

namespace Bar.Formulario_Ventas
{
    public partial class FormIngresarVenta : Form
    {
        public FormIngresarVenta()
        {
            InitializeComponent();

            lstClientes.Format += lstClientes_Format;
        }

        private void FormIngresarVenta_Load(object sender, EventArgs e)
        {
            cmbMetodoPago.Items.Add(MetodoDePago.MercadoPago);
            cmbMetodoPago.Items.Add(MetodoDePago.Debito);
            cmbMetodoPago.Items.Add(MetodoDePago.Credito);
            cmbMetodoPago.Items.Add(MetodoDePago.Efectivo);
            ConfigurarListBox(Controlador.ObtenerTodosClientes());          
        }

        public void ConfigurarListBox(List<Cliente> clientes)
        {
            lstClientes.DataSource = null;
            lstClientes.DataSource = clientes;
            lstClientes.DisplayMember = "Nombre";
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int dniARetornar;
            Cliente cliente = (Cliente)lstClientes.SelectedItem;
            dniARetornar = cliente.Dni;
            if (Controlador.CrearVenta(cmbMetodoPago.SelectedIndex, txtBebidaId.Text, dniARetornar, txtEmpleadoId.Text))
            {
                MessageBox.Show("Se pudo añadir la venta al historial.", "Añadir venta.");
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se pudo añadir la venta al historial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstClientes_Format(object sender, ListControlConvertEventArgs e)
        {
            Cliente cliente = (Cliente)e.ListItem;

            string displayText = cliente.ToString();

            e.Value = displayText;
        }

    }
}
