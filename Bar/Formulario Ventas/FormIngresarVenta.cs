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
using System.Reflection;
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
        AdministradorBebidaAlcoholica admB1 = new AdministradorBebidaAlcoholica();
        AdministradorBebidasNoAlcoholicas admB2 = new AdministradorBebidasNoAlcoholicas();

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
            try 
            {
                if(!string.IsNullOrEmpty(cmbBebida.Text) && !string.IsNullOrEmpty(cmbMetodoPago.Text))
                {
                    Cliente cliente = (Cliente)lstCliente.SelectedItem;
                    if((string)cmbBebida.SelectedItem == "Bebida alcoholica" || (string)cmbBebida.SelectedItem == "Bebida no alcoholica")
                    {
                        Bebida bebida = (Bebida)lstBebidas.SelectedItem;
                        /*admB1.ReservaStock += ManejadorReservaStock;
                        admB1.SinStock += ManejadorSinStock;
                        admB2.ReservaStock += ManejadorReservaStock;
                        admB2.SinStock += ManejadorSinStock;*/
                        controlador.AltaVenta(cmbMetodoPago.SelectedIndex, bebida.Id, cliente.Dni, this.usuario.Empleado.Id);
                        MessageBox.Show("Se pudo añadir la venta al historial.", "Añadir venta.");
                        this.DialogResult = DialogResult.OK;
                        this.Hide();
                    }
                    else
                    {
                        if((string)cmbBebida.SelectedItem == "Combo")
                        {
                           /* admB1.ReservaStock += ManejadorReservaStock;
                             admB1.SinStock += ManejadorSinStock;
                             admB2.ReservaStock += ManejadorReservaStock;
                             admB2.SinStock += ManejadorSinStock;*/
                            controlador.AltaVenta(cmbMetodoPago.SelectedIndex, bebidaUno.Id, bebidaDos.Id, cliente.Dni, this.usuario.Empleado.Id);
                            MessageBox.Show("Se pudo añadir la venta al historial.", "Añadir venta.");
                            this.DialogResult = DialogResult.OK;
                            this.Hide();  
                        }
                    }
                }
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string nombreClse = MethodBase.GetCurrentMethod().DeclaringType.Name;
                string nombreMetodo = MethodBase.GetCurrentMethod().Name;
                controlador.LogsErrores(ex, nombreClse, nombreMetodo);
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

        private void ManejadorReservaStock(object sender, BebidaEventArgs e)
        {
            DialogResult dg = MessageBox.Show($"La bebida {((Bebida)sender).Marca} se esta quedando sin stock, desea rellenar el stock?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                ((Bebida)sender).Stock = 25;
            }
        }

        private void ManejadorSinStock(object sender, BebidaEventArgs e)
        {
            DialogResult dg = MessageBox.Show($"La bebida {((Bebida)sender).Marca} se quedó sin stock, desea rellenar el stock?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                ((Bebida)sender).Stock = 25;
            }
        }

    }
}
