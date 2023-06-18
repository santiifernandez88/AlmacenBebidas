using Entidades.Empleados;

namespace Bar.Formulario_Inventario
{
    partial class FormAltaBebidas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbTipoBebida = new ComboBox();
            txtDescripcion = new TextBox();
            txtMLitros = new TextBox();
            lblMLitros = new Label();
            lblDescripcion = new Label();
            SuspendLayout();
            // 
            // lblAlta
            // 
            lblAlta.Location = new Point(221, 18);
            lblAlta.Size = new Size(192, 46);
            lblAlta.Text = "Alta de bebida";
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(109, 128);
            lblNombre.Size = new Size(53, 20);
            lblNombre.Text = "Marca:";
            // 
            // lblApellido
            // 
            lblApellido.Location = new Point(12, 179);
            lblApellido.Size = new Size(160, 20);
            lblApellido.Text = "Graduacion alcoholica:";
            // 
            // lblEdad
            // 
            lblEdad.Location = new Point(114, 228);
            lblEdad.Size = new Size(53, 20);
            lblEdad.Text = "Precio:";
            // 
            // lblDni
            // 
            lblDni.Location = new Point(114, 284);
            lblDni.Size = new Size(48, 20);
            lblDni.Text = "Stock:";
            // 
            // lblSueldo
            // 
            lblSueldo.Location = new Point(614, 543);
            lblSueldo.Visible = false;
            // 
            // lblPuesto
            // 
            lblPuesto.Location = new Point(368, 221);
            lblPuesto.Size = new Size(114, 20);
            lblPuesto.Text = "Tipo de bebida:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(173, 125);
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(173, 175);
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(173, 221);
            // 
            // txtDni
            // 
            txtDni.Location = new Point(173, 277);
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(558, 551);
            txtSueldo.Visible = false;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(472, 376);
            // 
            // btnReset
            // 
            btnReset.Location = new Point(501, 284);
            // 
            // cmbPuesto
            // 
            cmbPuesto.Items.AddRange(new object[] { Entidades.PuestosDeTrabajo.Jefe, Entidades.PuestosDeTrabajo.Encargado, Entidades.PuestosDeTrabajo.Vendedor });
            cmbPuesto.Location = new Point(578, 566);
            cmbPuesto.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(169, 376);
            btnCancelar.Size = new Size(184, 72);
            // 
            // lblContraseña
            // 
            lblContraseña.Location = new Point(558, 560);
            lblContraseña.Visible = false;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.Location = new Point(553, 563);
            lblNombreUsuario.Visible = false;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(528, 560);
            txtContraseña.Visible = false;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(528, 560);
            txtNombreUsuario.Visible = false;
            // 
            // label5
            // 
            label5.Location = new Point(558, 551);
            label5.Visible = false;
            // 
            // cmbTipoBebida
            // 
            cmbTipoBebida.FormattingEnabled = true;
            cmbTipoBebida.Location = new Point(501, 218);
            cmbTipoBebida.Name = "cmbTipoBebida";
            cmbTipoBebida.Size = new Size(181, 28);
            cmbTipoBebida.TabIndex = 26;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(501, 171);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(181, 27);
            txtDescripcion.TabIndex = 27;
            // 
            // txtMLitros
            // 
            txtMLitros.Location = new Point(501, 125);
            txtMLitros.Name = "txtMLitros";
            txtMLitros.Size = new Size(181, 27);
            txtMLitros.TabIndex = 28;
            // 
            // lblMLitros
            // 
            lblMLitros.AutoSize = true;
            lblMLitros.ForeColor = Color.White;
            lblMLitros.Location = new Point(408, 128);
            lblMLitros.Name = "lblMLitros";
            lblMLitros.Size = new Size(77, 20);
            lblMLitros.TabIndex = 29;
            lblMLitros.Text = "Mili Litros:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = Color.White;
            lblDescripcion.Location = new Point(395, 175);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 20);
            lblDescripcion.TabIndex = 30;
            lblDescripcion.Text = "Descripcion:";
            // 
            // FormAltaBebidas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 482);
            Controls.Add(lblDescripcion);
            Controls.Add(lblMLitros);
            Controls.Add(txtMLitros);
            Controls.Add(txtDescripcion);
            Controls.Add(cmbTipoBebida);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAltaBebidas";
            Text = "FormAltaBebidas";
            Load += FormAltaBebidas_Load;
            Controls.SetChildIndex(cmbTipoBebida, 0);
            Controls.SetChildIndex(lblAlta, 0);
            Controls.SetChildIndex(lblNombre, 0);
            Controls.SetChildIndex(lblApellido, 0);
            Controls.SetChildIndex(lblEdad, 0);
            Controls.SetChildIndex(lblDni, 0);
            Controls.SetChildIndex(lblSueldo, 0);
            Controls.SetChildIndex(lblPuesto, 0);
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(txtApellido, 0);
            Controls.SetChildIndex(txtEdad, 0);
            Controls.SetChildIndex(txtDni, 0);
            Controls.SetChildIndex(txtSueldo, 0);
            Controls.SetChildIndex(btnAceptar, 0);
            Controls.SetChildIndex(btnReset, 0);
            Controls.SetChildIndex(cmbPuesto, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(lblContraseña, 0);
            Controls.SetChildIndex(lblNombreUsuario, 0);
            Controls.SetChildIndex(txtContraseña, 0);
            Controls.SetChildIndex(txtNombreUsuario, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(txtDescripcion, 0);
            Controls.SetChildIndex(txtMLitros, 0);
            Controls.SetChildIndex(lblMLitros, 0);
            Controls.SetChildIndex(lblDescripcion, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipoBebida;
        private TextBox txtDescripcion;
        private TextBox txtMLitros;
        private Label lblMLitros;
        private Label lblDescripcion;
    }
}