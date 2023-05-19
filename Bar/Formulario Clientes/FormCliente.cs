using Bar.Formulario_Empleados;
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

namespace Bar.Formulario_Clientes
{
    public partial class FormCliente : FormEmpleado
    {
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
        public FormCliente()
        {
            InitializeComponent();

        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
           if(this.usuario.Empleado.Puesto == PuestosDeTrabajo.Vendedor)
           {
                btnBajaEmp.Visible = true;
           }

            ActualizarDatagrid(Controlador.ObtenerTodosClientes());
            dtgEmpleado.ReadOnly = true;
        }

        public override void dtgEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            celdaClickeada = e.RowIndex;
        }

        public void ActualizarDatagrid(List<Cliente> clientes)
        {
            dtgEmpleado.DataSource = null;
            dtgEmpleado.DataSource = clientes;
        }

        public override void btnAltaEmp_Click(object sender, EventArgs e)
        {
            FormAltaCliente formAlta = new FormAltaCliente();
            DialogResult dg = formAlta.ShowDialog();
            if(dg == DialogResult.OK) 
            {
                ActualizarDatagrid(Controlador.ObtenerTodosClientes());
            }
        }

        public override void btnBajaEmp_Click(object sender, EventArgs e)
        {
            int dniAEliminar = (int)dtgEmpleado.Rows[celdaClickeada].Cells[4].Value;
            DialogResult dg = MessageBox.Show("Estas seguro que quieres eliminar a un cliente?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                if (Controlador.BorrarCliente(dniAEliminar))
                {
                    MessageBox.Show("Se elimino correctamente al cliente");
                }
                else
                {
                    MessageBox.Show("Error, no se pudo eliminar correctamente el cliente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ActualizarDatagrid(Controlador.ObtenerTodosClientes());
            }
        }

        public override void btnModEmp_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Estas seguro que quieres modificar a un empleado?", "Modificar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                int dniAModificar = (int)dtgEmpleado.Rows[celdaClickeada].Cells[4].Value;             
                Cliente clienteAModificar = Controlador.TraerClienteDni(dniAModificar);
                FormModificarCliente formModificar = new FormModificarCliente(clienteAModificar);
                DialogResult dg2 = formModificar.ShowDialog();   
                if(dg2 == DialogResult.OK) 
                {
                    ActualizarDatagrid(Controlador.ObtenerTodosClientes());
                }
            }           
        }
    }
}
