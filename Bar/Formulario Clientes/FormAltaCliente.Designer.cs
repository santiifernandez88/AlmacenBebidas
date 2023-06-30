using Entidades.Empleados;

namespace Bar.Formulario_Clientes
{
    partial class FormAltaCliente
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
            cmbBebidaFavorita = new ComboBox();
            SuspendLayout();
            // 
            // lblAlta
            // 
            lblAlta.Location = new Point(203, 23);
            lblAlta.Size = new Size(198, 46);
            lblAlta.Text = "Alta de Cliente";
            // 
            // lblDni
            // 
            lblDni.Location = new Point(381, 128);
            // 
            // lblSueldo
            // 
            lblSueldo.Location = new Point(611, 620);
            lblSueldo.Visible = false;
            // 
            // lblPuesto
            // 
            lblPuesto.Location = new Point(337, 178);
            lblPuesto.Size = new Size(82, 20);
            lblPuesto.Text = "Frecuencia:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(437, 121);
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(577, 597);
            txtSueldo.Visible = false;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(408, 300);
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(479, 236);
            // 
            // cmbPuesto
            // 
            cmbPuesto.Items.AddRange(new object[] { PuestosDeTrabajo.Jefe, PuestosDeTrabajo.Encargado, PuestosDeTrabajo.Vendedor, PuestosDeTrabajo.Jefe, PuestosDeTrabajo.Encargado, PuestosDeTrabajo.Vendedor, PuestosDeTrabajo.Jefe, PuestosDeTrabajo.Encargado, PuestosDeTrabajo.Vendedor, PuestosDeTrabajo.Jefe, PuestosDeTrabajo.Encargado, PuestosDeTrabajo.Vendedor, PuestosDeTrabajo.Jefe, PuestosDeTrabajo.Encargado, PuestosDeTrabajo.Vendedor, PuestosDeTrabajo.Jefe, PuestosDeTrabajo.Encargado, PuestosDeTrabajo.Vendedor, PuestosDeTrabajo.Jefe, PuestosDeTrabajo.Encargado, PuestosDeTrabajo.Vendedor, PuestosDeTrabajo.Jefe, PuestosDeTrabajo.Encargado, PuestosDeTrabajo.Vendedor, PuestosDeTrabajo.Jefe, PuestosDeTrabajo.Encargado, PuestosDeTrabajo.Vendedor, PuestosDeTrabajo.Jefe, PuestosDeTrabajo.Encargado, PuestosDeTrabajo.Vendedor, PuestosDeTrabajo.Jefe, PuestosDeTrabajo.Encargado, PuestosDeTrabajo.Vendedor, PuestosDeTrabajo.Jefe, PuestosDeTrabajo.Encargado, PuestosDeTrabajo.Vendedor });
            cmbPuesto.Location = new Point(577, 572);
            cmbPuesto.Size = new Size(181, 28);
            cmbPuesto.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(95, 300);
            btnCancelar.Size = new Size(206, 72);
            // 
            // lblContraseña
            // 
            lblContraseña.Location = new Point(659, 613);
            lblContraseña.Visible = false;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.Location = new Point(626, 613);
            lblNombreUsuario.Visible = false;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(611, 617);
            txtContraseña.Visible = false;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(626, 606);
            txtNombreUsuario.WordWrap = false;
            // 
            // label5
            // 
            label5.Location = new Point(680, 597);
            label5.Visible = false;
            // 
            // cmbBebidaFavorita
            // 
            cmbBebidaFavorita.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBebidaFavorita.FormattingEnabled = true;
            cmbBebidaFavorita.Location = new Point(437, 175);
            cmbBebidaFavorita.Name = "cmbBebidaFavorita";
            cmbBebidaFavorita.Size = new Size(181, 28);
            cmbBebidaFavorita.TabIndex = 26;
            // 
            // FormAltaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 427);
            Controls.Add(cmbBebidaFavorita);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAltaCliente";
            Load += FormAltaCliente_Load;
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
            Controls.SetChildIndex(cmbBebidaFavorita, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected ComboBox cmbBebidaFavorita;
    }
}