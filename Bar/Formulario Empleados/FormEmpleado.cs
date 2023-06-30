using Entidades;
using Entidades.Empleados;
using Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar.Formulario_Empleados
{
    public partial class FormEmpleado : Form
    {
        Controlador controlador = new Controlador();
        protected Usuario usuario = new Usuario("aaa", "aaa", new Empleado("a", "a", 1, 1));
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

        public Usuario UsuarioLogeado { get => usuario; set => usuario = value; }

        public FormEmpleado()
        {
            InitializeComponent();

        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            if (this.usuario.Empleado.Puesto == PuestosDeTrabajo.Encargado)
            {
                btnBajaEmp.Visible = false;
            }
            ActualizarDatagrid(controlador.ObtenerTodosEmpleados());
            dtgEmpleado.ReadOnly = true;

        }

        public void ActualizarDatagrid(List<Empleado> empleados)
        {
            // ojo que si la lista esta vacia rompe
            dtgEmpleado.DataSource = null;
            dtgEmpleado.DataSource = empleados;
        }


        public virtual void dtgEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            celdaClickeada = e.RowIndex;
        }

        public virtual void btnAltaEmp_Click(object sender, EventArgs e)
        {
            FormAltaEmpleado formAlta = new FormAltaEmpleado();
            DialogResult dg = formAlta.ShowDialog();
            if (dg == DialogResult.OK)
            {
                ActualizarDatagrid(controlador.ObtenerTodosEmpleados());
            }
        }

        public virtual void btnBajaEmp_Click(object sender, EventArgs e)
        {
            try
            {
                int idAEliminar = (int)dtgEmpleado.Rows[celdaClickeada].Cells[0].Value;
                DialogResult dg = MessageBox.Show("Estas seguro que quieres eliminar a un empleado?", "Eliminar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    if (controlador.BajaEmpleado(idAEliminar))
                    {
                        MessageBox.Show("Se elimino correctamente al empleado");
                    }
                    ActualizarDatagrid(controlador.ObtenerTodosEmpleados());
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }


        public virtual void btnModEmp_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Estas seguro que quieres modificar a un empleado?", "Modificar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                int idAModificar = (int)dtgEmpleado.Rows[celdaClickeada].Cells[0].Value;
                Empleado empleadoAModificar = controlador.TraerEmpleadoId(idAModificar);
                FormModificarEmpleado formModificar = new FormModificarEmpleado(empleadoAModificar);
                DialogResult dg2 = formModificar.ShowDialog();
                if (dg2 == DialogResult.OK)
                {
                    ActualizarDatagrid(controlador.ObtenerTodosEmpleados());
                }
            }
        }
    }
}
