using Bar.Formulario_Empleados;
using Bar.Formulario_Inventario;
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

namespace Bar
{
    public partial class Inventario : FormEmpleado
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return createParams;
            }
        }
        public Inventario()
        {
            InitializeComponent();

        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            if (this.usuario.Empleado.Puesto == PuestosDeTrabajo.Vendedor)
            {
                btnAltaEmp.Visible = false;
                btnBajaEmp.Visible = false;
            }
            else
            {
                btnBajaEmp.Visible = true;
            }
            ActualizarDatagrid(Controlador.ObtenerTodasBebidas());
            dtgEmpleado.ReadOnly = true;
            btnModEmp.Text = "Rellenar stock";
        }

        private void ActualizarDatagrid(List<Bebidas> bebidas)
        {
            // ojo que si la lista esta vacia rompe
            dtgEmpleado.DataSource = null;
            dtgEmpleado.DataSource = bebidas;
        }

        int celdaClickeada;
        public override void dtgEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            celdaClickeada = e.RowIndex;
        }

        public override void btnBajaEmp_Click(object sender, EventArgs e)
        {
            int idAEliminar = (int)dtgEmpleado.Rows[celdaClickeada].Cells[0].Value;
            DialogResult dg = MessageBox.Show("Estas seguro que quieres eliminar esta bebida?", "Eliminar bebida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                if (Controlador.BorrarBebida(idAEliminar))
                {
                    MessageBox.Show("Se elimino correctamente al empleado");
                    
                }
                else
                {
                    MessageBox.Show("Error, no se pudo eliminar correctamente la bebida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ActualizarDatagrid(Controlador.ObtenerTodasBebidas());
            }
        }

        public override void btnModEmp_Click(object sender, EventArgs e)
        {
            Controlador.RellenarStock();
            ActualizarDatagrid(Controlador.ObtenerTodasBebidas());
        }

        public override void btnAltaEmp_Click(object sender, EventArgs e)
        {
            FormAltaBebidas formAltaBebidas = new FormAltaBebidas();
            formAltaBebidas.Show();
            ActualizarDatagrid(Controlador.ObtenerTodasBebidas());
        }
    }
}
