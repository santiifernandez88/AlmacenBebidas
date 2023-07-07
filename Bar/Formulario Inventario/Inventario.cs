using Bar.Formulario_Empleados;
using Bar.Formulario_Inventario;
using Entidades;
using Entidades.Bebidas;
using Entidades.Empleados;
using Entidades.Usuarios;
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

namespace Bar
{
    public partial class Inventario : FormEmpleado
    {
        Controlador controlador = new Controlador();
        Usuario usuario;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return createParams;
            }
        }
        public Inventario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
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

            ActualizarDatagridAlcoholicas(controlador.ObtenerTodasBebidasAlcoholicas());
            dtgEmpleado.ReadOnly = true;
            btnModEmp.Text = "Rellenar stock";
            lblTitulo.Text = "Bebidas alcoholicas";
        }

        private void ActualizarDatagridAlcoholicas(List<BebidaAlcoholica> bebidas)
        {
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
            try
            {
                int idAEliminar = (int)dtgEmpleado.Rows[celdaClickeada].Cells[2].Value;
                DialogResult dg = MessageBox.Show("Estas seguro que quieres eliminar esta bebida?", "Eliminar bebida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    if (lblTitulo.Text == "Bebidas alcoholicas")
                    {
                        controlador.BajaBebidaAlcoholica(idAEliminar);
                        MessageBox.Show("Se elimino correctamente la bebida");
                        ActualizarDatagridAlcoholicas(controlador.ObtenerTodasBebidasAlcoholicas());
                    }
                    else
                    {
                        controlador.BajaBebidaNoAlcoholica(idAEliminar);
                        MessageBox.Show("Se elimino correctamente la bebida");
                        ActualizarDatagridNoAlcoholicas(controlador.ObtenerTodasBebidasNoAlcoholicas());
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string nombreClse = MethodBase.GetCurrentMethod().DeclaringType.Name;
                string nombreMetodo = MethodBase.GetCurrentMethod().Name;
                controlador.LogsErrores(ex, nombreClse, nombreMetodo);
            }
        }

        public override void btnModEmp_Click(object sender, EventArgs e)
        {
            if(lblTitulo.Text == "Bebidas alcoholicas")
            {
                AdministradorBebidaAlcoholica administrador = new AdministradorBebidaAlcoholica();
                administrador.RellenarStock();
                ActualizarDatagridAlcoholicas(controlador.ObtenerTodasBebidasAlcoholicas());
            }
            else
            {
                AdministradorBebidasNoAlcoholicas administrador = new AdministradorBebidasNoAlcoholicas();
                administrador.RellenarStock();
                ActualizarDatagridNoAlcoholicas(controlador.ObtenerTodasBebidasNoAlcoholicas());
            }         
        }

        public override void btnAltaEmp_Click(object sender, EventArgs e)
        {
            if(lblTitulo.Text == "Bebidas alcoholicas")
            {
                FormAltaBebidaAlc formAltaBebidaAlc = new FormAltaBebidaAlc();
                DialogResult dg = formAltaBebidaAlc.ShowDialog();
                if (dg == DialogResult.OK)
                {
                    ActualizarDatagridAlcoholicas(controlador.ObtenerTodasBebidasAlcoholicas());
                }
            }
            else
            {
                FormAltaBebidaNoAlc formAltaBebidaNoAlc = new FormAltaBebidaNoAlc();
                DialogResult dg = formAltaBebidaNoAlc.ShowDialog();
                if (dg == DialogResult.OK)
                {
                    ActualizarDatagridNoAlcoholicas(controlador.ObtenerTodasBebidasNoAlcoholicas());
                }
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            ActualizarDatagridNoAlcoholicas(controlador.ObtenerTodasBebidasNoAlcoholicas());
            lblTitulo.Text = "Bebidas no alcoholicas";

            btnCambiar.Click -= btnCambiar_Click;
            btnCambiar.Click += CambiarInventario;
        }

        private void CambiarInventario(object sender, EventArgs e) 
        {
            ActualizarDatagridAlcoholicas(controlador.ObtenerTodasBebidasAlcoholicas());
            lblTitulo.Text = "Bebidas alcoholicas";
            btnCambiar.Click -= CambiarInventario;
            btnCambiar.Click += btnCambiar_Click;
        }

        private void ActualizarDatagridNoAlcoholicas(List<BebidaNoAlcoholica> bebidas)
        {
            dtgEmpleado.DataSource = null;
            dtgEmpleado.DataSource = bebidas;
        }
    }
}
