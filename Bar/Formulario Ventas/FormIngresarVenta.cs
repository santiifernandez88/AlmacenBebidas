using Entidades;
using Entidades.Bebidas;
using Entidades.Clientes;
using Entidades.Usuarios;
using Entidades.Ventas;
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
        Controlador controlador = new Controlador();
        Usuario usuario;
        public FormIngresarVenta(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lstCliente.Format += lstClientes_Format;
        }

        private void FormIngresarVenta_Load(object sender, EventArgs e)
        {
            foreach (var metodo in Enum.GetValues(typeof(MetodoDePago)))
            {
                cmbMetodoPago.Items.Add(metodo);
            }

            cmbBebida.Items.Add("Bebida alcoholica");
            cmbBebida.Items.Add("Bebida no alcoholica");
            cmbBebida.Items.Add("Combo");

            ConfigurarListBoxClientes(controlador.ObtenerTodosClientes());
            ConfigurarListBoxBebidasAlc(controlador.ObtenerTodasBebidasAlcoholicas());
            ConfigurarListBoxBebidasNoAlc(controlador.ObtenerTodasBebidasNoAlcoholicas());
        }

        public void ConfigurarListBoxClientes(List<Cliente> clientes)
        {
            lstCliente.DataSource = null;
            lstCliente.DataSource = clientes;
            lstCliente.DisplayMember = "Nombre";
        }
        public void ConfigurarListBoxBebidasAlc(List<BebidaAlcoholica> bebidas)
        {
            lstCliente.DataSource = null;
            lstCliente.DataSource = bebidas;
            lstCliente.DisplayMember = "Nombre";
        }
        public void ConfigurarListBoxBebidasNoAlc(List<BebidaNoAlcoholica> bebidas)
        {
            lstCliente.DataSource = null;
            lstCliente.DataSource = bebidas;
            lstCliente.DisplayMember = "Nombre";
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
            int idBebidaARetornar;
            Cliente cliente = (Cliente)lstCliente.SelectedItem;
            Bebida bebida = (Bebida)lstBebidas.SelectedItem;
            dniARetornar = cliente.Dni;
            ValidarBebida(dniARetornar, idBebidaARetornar);
        }

        private void ValidarBebida(int dniARetornar)
        {
            if (cmbBebida.SelectedItem == "Bebida alcoholica" || cmbBebida.SelectedItem == "Bebida no alcoholica")
            {
                if (controlador.AltaVenta(cmbMetodoPago.SelectedIndex, , dniARetornar, this.usuario.Empleado.Id))
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
            else
            {
                if (cmbBebida.SelectedItem == "Combo")
                {
                    if (controlador.AltaVenta(cmbMetodoPago.SelectedIndex, , dniARetornar, this.usuario.Empleado.Id))
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
            }
        }

        private void lstClientes_Format(object sender, ListControlConvertEventArgs e)
        {
            Cliente cliente = (Cliente)e.ListItem;

            string displayText = cliente.ToString();

            e.Value = displayText;
        }

        private void lstBebidas_Format(object sender, ListControlConvertEventArgs e)
        {
            if(cmbBebida.SelectedItem == "Bebida alcoholica")
            {
                BebidaAlcoholica bebidaAlcoholica = (BebidaAlcoholica)e.ListItem;

                string displayText = bebidaAlcoholica.ToString();

                e.Value = displayText;
            }

        }

        private void lstBebidasNoAlc_Format(object sender, ListControlConvertEventArgs e)
        {
            BebidaNoAlcoholica bebidaNoAlcoholica = (BebidaNoAlcoholica)e.ListItem;

            string displayText = bebidaNoAlcoholica.ToString();

            e.Value = displayText;
        }
    }
}
