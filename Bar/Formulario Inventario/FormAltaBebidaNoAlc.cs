using Entidades.Bebidas;
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
    public partial class FormAltaBebidaNoAlc : Form
    {
        Controlador controlador = new Controlador();
        public FormAltaBebidaNoAlc()
        {
            InitializeComponent();
        }

        private void FormAltaBebidaAlc_Load(object sender, EventArgs e)
        {
            foreach (var tipo in Enum.GetValues(typeof(TiposBebidasNoAlc)))
            {
                cmbTipoDeBebida.Items.Add(tipo);
            }

            cmbContieneAzuc.Items.Add("Falso");
            cmbContieneAzuc.Items.Add("Verdadero");
        }

        public void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(cmbTipoDeBebida.Text) && !string.IsNullOrEmpty(cmbContieneAzuc.Text))
                {
                    if (cmbContieneAzuc.Text == "Verdadero")
                    {
                        controlador.AltaBebidaNoAlcoholica(txtMarca.Text, txtStock.Text, txtPrecio.Text, txtMLitros.Text, txtDescripcion.Text, cmbTipoDeBebida.SelectedIndex, true);
                        MessageBox.Show("Se pudo agregar la bebida al inventario.");
                        this.DialogResult = DialogResult.OK;
                        this.Hide();
                    }
                    else
                    {
                        controlador.AltaBebidaNoAlcoholica(txtMarca.Text, txtStock.Text, txtPrecio.Text, txtMLitros.Text, txtDescripcion.Text, cmbTipoDeBebida.SelectedIndex, false);
                        MessageBox.Show("Se pudo agregar la bebida al inventario.");
                        this.DialogResult = DialogResult.OK;
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
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
    }
}
