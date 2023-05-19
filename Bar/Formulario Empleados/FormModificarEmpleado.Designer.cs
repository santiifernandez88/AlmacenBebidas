namespace Bar.Formulario_Empleados
{
    partial class FormModificarEmpleado
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
            cmbPuestoTrabajo = new ComboBox();
            SuspendLayout();
            // 
            // lblSueldo
            // 
            lblSueldo.Location = new Point(345, 128);
            // 
            // lblPuesto
            // 
            lblPuesto.Location = new Point(347, 205);
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(422, 121);
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(407, 384);
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(440, 270);
            // 
            // cmbPuesto
            // 
            cmbPuesto.Items.AddRange(new object[] { Entidades.PuestosDeTrabajo.Jefe, Entidades.PuestosDeTrabajo.Encargado, Entidades.PuestosDeTrabajo.Vendedor, Entidades.PuestosDeTrabajo.Jefe, Entidades.PuestosDeTrabajo.Encargado, Entidades.PuestosDeTrabajo.Vendedor, Entidades.PuestosDeTrabajo.Jefe, Entidades.PuestosDeTrabajo.Encargado, Entidades.PuestosDeTrabajo.Vendedor, Entidades.PuestosDeTrabajo.Jefe, Entidades.PuestosDeTrabajo.Encargado, Entidades.PuestosDeTrabajo.Vendedor, Entidades.PuestosDeTrabajo.Jefe, Entidades.PuestosDeTrabajo.Encargado, Entidades.PuestosDeTrabajo.Vendedor, Entidades.PuestosDeTrabajo.Jefe, Entidades.PuestosDeTrabajo.Encargado, Entidades.PuestosDeTrabajo.Vendedor });
            cmbPuesto.Location = new Point(390, 461);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(111, 385);
            btnCancelar.Size = new Size(164, 71);
            // 
            // lblContraseña
            // 
            lblContraseña.Location = new Point(126, 485);
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.Location = new Point(95, 469);
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(227, 470);
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(407, 463);
            // 
            // label5
            // 
            label5.Location = new Point(32, 469);
            // 
            // cmbPuestoTrabajo
            // 
            cmbPuestoTrabajo.FormattingEnabled = true;
            cmbPuestoTrabajo.Location = new Point(422, 202);
            cmbPuestoTrabajo.Name = "cmbPuestoTrabajo";
            cmbPuestoTrabajo.Size = new Size(157, 28);
            cmbPuestoTrabajo.TabIndex = 26;
            // 
            // FormModificarEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(658, 515);
            Controls.Add(cmbPuestoTrabajo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormModificarEmpleado";
            Text = "FormModificar";
            Load += FormModificarEmpleado_Load;
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
            Controls.SetChildIndex(cmbPuestoTrabajo, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPuestoTrabajo;
    }
}