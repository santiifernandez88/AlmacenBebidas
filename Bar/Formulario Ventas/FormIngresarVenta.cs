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
        BebidaAlcoholica bebidaUno;
        BebidaNoAlcoholica bebidaDos;

        public FormIngresarVenta(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lstCliente.Format += lstClientes_Format;
        }

        private void FormIngresarVenta_Load(object sender, EventArgs e)
        {
            btnAplicar.Visible = false;
            foreach (var metodo in Enum.GetValues(typeof(MetodoDePago)))
            {
                cmbMetodoPago.Items.Add(metodo);
            }

            cmbBebida.Items.Add("Bebida alcoholica");
            cmbBebida.Items.Add("Bebida no alcoholica");
            cmbBebida.Items.Add("Combo");

            ConfigurarListBoxClientes(controlador.ObtenerTodosClientes());

            lblCombo.Text = "Combo: \n";

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
            Cliente cliente = (Cliente)lstCliente.SelectedItem;
            ValidarBebida(cliente.Dni);
        }

        private void ValidarBebida(int dniARetornar)
        {
            if ((string)cmbBebida.SelectedItem == "Bebida alcoholica" || (string)cmbBebida.SelectedItem == "Bebida no alcoholica")
            {
                Bebida bebida = (Bebida)lstBebidas.SelectedItem;
                if (controlador.AltaVenta(cmbMetodoPago.SelectedIndex, bebida.Id, dniARetornar, this.usuario.Empleado.Id))
                {
                    MessageBox.Show("Se pudo añadir la venta al historial.", "Añadir venta.");
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se pudo añadir la venta al historial estoy en bebida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                if ((string)cmbBebida.SelectedItem == "Combo")
                {
                    //aca lo utilizo
                    if (controlador.AltaVenta(cmbMetodoPago.SelectedIndex, bebidaUno.Id, bebidaDos.Id, dniARetornar, this.usuario.Empleado.Id))
                    {
                        MessageBox.Show("Se pudo añadir la venta al historial.", "Añadir venta.");
                        this.DialogResult = DialogResult.OK;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo añadir la venta al historial estoy en combo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void ConfigurarListBoxClientes(List<Cliente> clientes)
        {
            lstCliente.DataSource = null;
            lstCliente.DataSource = clientes;
            lstCliente.DisplayMember = "Nombre";
        }
        public void ConfigurarListBoxBebidasAlc(List<BebidaAlcoholica> bebidas)
        {
            lstBebidas.DataSource = null;
            lstBebidas.DataSource = bebidas;
            lstBebidas.DisplayMember = "Nombre";
        }
        public void ConfigurarListBoxBebidasNoAlc(List<BebidaNoAlcoholica> bebidas)
        {
            lstBebidas.DataSource = null;
            lstBebidas.DataSource = bebidas;
            lstBebidas.DisplayMember = "Nombre";
        }

        private void lstClientes_Format(object sender, ListControlConvertEventArgs e)
        {
            Cliente cliente = (Cliente)e.ListItem;

            string displayText = cliente.ToString();

            e.Value = displayText;
        }

        private void lstBebidas_Format(object sender, ListControlConvertEventArgs e)
        {
            if ((string)cmbBebida.SelectedItem == "Bebida alcoholica")
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

        private void cmbBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cmbBebida.SelectedItem == "Bebida alcoholica")
            {
                btnAplicar.Visible = false;
                ConfigurarListBoxBebidasAlc(controlador.ObtenerTodasBebidasAlcoholicas());
            }

            if ((string)cmbBebida.SelectedItem == "Bebida no alcoholica")
            {
                btnAplicar.Visible = false;
                ConfigurarListBoxBebidasNoAlc(controlador.ObtenerTodasBebidasNoAlcoholicas());
            }

            if ((string)cmbBebida.SelectedItem == "Combo")
            {
                btnAplicar.Visible = true;
                ConfigurarListBoxBebidasAlc(controlador.ObtenerTodasBebidasAlcoholicas());
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            bebidaUno = (BebidaAlcoholica)lstBebidas.SelectedItem;
            lblCombo.Text += bebidaUno.ToString();
            this.btnAplicar.Click -= btnAplicar_Click;
            ConfigurarListBoxBebidasNoAlc(controlador.ObtenerTodasBebidasNoAlcoholicas());
            this.btnAplicar.Click += ElegirBebidaDos;

        }

        private void ElegirBebidaDos(object sender, EventArgs e)
        {        
            bebidaDos = (BebidaNoAlcoholica)lstBebidas.SelectedItem;
            lblCombo.Text += "\n" + bebidaDos.ToString();
            this.btnAplicar.Click -= ElegirBebidaDos;
        }

    }
}
