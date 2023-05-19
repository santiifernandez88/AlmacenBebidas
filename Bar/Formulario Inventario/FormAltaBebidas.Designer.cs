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
            lblPuesto.Location = new Point(448, 125);
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
            btnAceptar.Location = new Point(448, 359);
            // 
            // btnReset
            // 
            btnReset.Location = new Point(448, 257);
            // 
            // cmbPuesto
            // 
            cmbPuesto.Items.AddRange(new object[] { Entidades.PuestosDeTrabajo.Jefe, Entidades.PuestosDeTrabajo.Encargado, Entidades.PuestosDeTrabajo.Vendedor, Entidades.PuestosDeTrabajo.Jefe, Entidades.PuestosDeTrabajo.Encargado, Entidades.PuestosDeTrabajo.Vendedor, Entidades.PuestosDeTrabajo.Jefe, Entidades.PuestosDeTrabajo.Encargado, Entidades.PuestosDeTrabajo.Vendedor, Entidades.PuestosDeTrabajo.Jefe, Entidades.PuestosDeTrabajo.Encargado, Entidades.PuestosDeTrabajo.Vendedor, Entidades.PuestosDeTrabajo.Jefe, Entidades.PuestosDeTrabajo.Encargado, Entidades.PuestosDeTrabajo.Vendedor, Entidades.PuestosDeTrabajo.Jefe, Entidades.PuestosDeTrabajo.Encargado, Entidades.PuestosDeTrabajo.Vendedor });
            cmbPuesto.Location = new Point(578, 566);
            cmbPuesto.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(114, 359);
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
            cmbTipoBebida.Location = new Point(448, 161);
            cmbTipoBebida.Name = "cmbTipoBebida";
            cmbTipoBebida.Size = new Size(157, 28);
            cmbTipoBebida.TabIndex = 26;
            // 
            // FormAltaBebidas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 497);
            Controls.Add(cmbTipoBebida);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAltaBebidas";
            Text = "FormAltaBebidas";
            Load += FormAltaBebidas_Load;
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
            Controls.SetChildIndex(cmbTipoBebida, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipoBebida;
    }
}