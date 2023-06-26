﻿using Bar.Formulario_Ventas;
using Entidades;
using Entidades.Empleados;
using Entidades.Usuarios;
using Entidades.Ventas;

namespace Bar
{
    public partial class FormVentas : Form
    {
        Controlador controlador = new Controlador();
        Usuario usuario;
        int celdaClickeada;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return createParams;
            }
        }

        public FormVentas(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            if (this.usuario.Empleado.Puesto == PuestosDeTrabajo.Vendedor)
            {
                lblCantidad.Visible = false;
                lblSaldo.Visible = false;
                label1.Visible = false;
                btnBorrarVenta.Visible = false;
            }
            dtgVentas.DefaultCellStyle.ForeColor = Color.Black;
            ActualizarDatagrid(controlador.ObtenerTodasVentas());
            dtgVentas.ReadOnly = true;
        }

        public void ActualizarDatagrid(List<Venta> ventas)
        {
            dtgVentas.DataSource = null;
            dtgVentas.DataSource = ventas;
            lblCantidad.Text = controlador.AcumuladorGanancias().ToString();
        }

        private void dtgVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            celdaClickeada = e.RowIndex;
        }

        private void btnIniciarVenta_Click(object sender, EventArgs e)
        {
            FormIngresarVenta formIngresarVenta = new FormIngresarVenta(usuario);
            DialogResult dg = formIngresarVenta.ShowDialog();
            if (dg == DialogResult.OK)
            {
                ActualizarDatagrid(controlador.ObtenerTodasVentas());
            }
        }

        private void btnBorrarVenta_Click(object sender, EventArgs e)
        {
            int idAEliminar = (int)dtgVentas.Rows[celdaClickeada].Cells[0].Value;
            //MessageBox.Show(idAEliminar.ToString());
            DialogResult dg = MessageBox.Show("Estas seguro que quieres eliminar una venta?", "Eliminar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                if (controlador.BajaVenta(idAEliminar))
                {
                    MessageBox.Show("Se elimino correctamente la venta", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error, no se pudo eliminar correctamente la venta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ActualizarDatagrid(controlador.ObtenerTodasVentas());
            }
        }
    }
}
