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
    public partial class FormAltaBebidaAlc : Form
    {
        Controlador controlador = new Controlador();
        public FormAltaBebidaAlc()
        {
            InitializeComponent();
        }

        private void FormAltaBebidaAlc_Load(object sender, EventArgs e)
        {
            foreach (var tipo in Enum.GetValues(typeof(TiposBebidasAlcoholicas)))
            {
                cmbTipoDeBebida.Items.Add(tipo);
            }
        }

        public void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cmbTipoDeBebida.Text))
                {
                    controlador.AltaBebidaAlcoholica(txtMarca.Text, txtStock.Text, txtPrecio.Text, txtMLitros.Text, txtGradoAlc.Text, txtDescripcion.Text, cmbTipoDeBebida.SelectedIndex);
                    MessageBox.Show("Se pudo agregar la bebida al inventario.");
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
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
