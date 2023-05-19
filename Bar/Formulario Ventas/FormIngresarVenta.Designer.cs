namespace Bar.Formulario_Ventas
{
    partial class FormIngresarVenta
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
            lblVenta = new Label();
            lblBebidaId = new Label();
            lblEmpleadoId = new Label();
            lblMetodoPago = new Label();
            txtBebidaId = new TextBox();
            txtEmpleadoId = new TextBox();
            cmbMetodoPago = new ComboBox();
            btnReset = new Button();
            btnAgregar = new Button();
            btnCancelar = new Button();
            lblDniCliente = new Label();
            lstClientes = new ListBox();
            SuspendLayout();
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.BorderStyle = BorderStyle.Fixed3D;
            lblVenta.Font = new Font("Microsoft Himalaya", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblVenta.ForeColor = Color.White;
            lblVenta.Location = new Point(229, 21);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(207, 42);
            lblVenta.TabIndex = 1;
            lblVenta.Text = "NUEVA VENTA";
            // 
            // lblBebidaId
            // 
            lblBebidaId.AutoSize = true;
            lblBebidaId.ForeColor = Color.White;
            lblBebidaId.Location = new Point(20, 106);
            lblBebidaId.Name = "lblBebidaId";
            lblBebidaId.Size = new Size(82, 20);
            lblBebidaId.TabIndex = 5;
            lblBebidaId.Text = "Bebida ID: ";
            // 
            // lblEmpleadoId
            // 
            lblEmpleadoId.AutoSize = true;
            lblEmpleadoId.ForeColor = Color.White;
            lblEmpleadoId.Location = new Point(362, 102);
            lblEmpleadoId.Name = "lblEmpleadoId";
            lblEmpleadoId.Size = new Size(99, 20);
            lblEmpleadoId.TabIndex = 6;
            lblEmpleadoId.Text = "Empleado ID:";
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.ForeColor = Color.White;
            lblMetodoPago.Location = new Point(336, 159);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(125, 20);
            lblMetodoPago.TabIndex = 7;
            lblMetodoPago.Text = "Metodo de pago:";
            // 
            // txtBebidaId
            // 
            txtBebidaId.Location = new Point(122, 103);
            txtBebidaId.Name = "txtBebidaId";
            txtBebidaId.Size = new Size(140, 27);
            txtBebidaId.TabIndex = 8;
            // 
            // txtEmpleadoId
            // 
            txtEmpleadoId.Location = new Point(467, 99);
            txtEmpleadoId.Name = "txtEmpleadoId";
            txtEmpleadoId.Size = new Size(151, 27);
            txtEmpleadoId.TabIndex = 9;
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Location = new Point(467, 156);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(151, 28);
            cmbMetodoPago.TabIndex = 10;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.CadetBlue;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(467, 205);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(151, 38);
            btnReset.TabIndex = 12;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.CadetBlue;
            btnAgregar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(467, 343);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(164, 83);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.CadetBlue;
            btnCancelar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(467, 271);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(151, 53);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblDniCliente
            // 
            lblDniCliente.AutoSize = true;
            lblDniCliente.FlatStyle = FlatStyle.System;
            lblDniCliente.ForeColor = Color.White;
            lblDniCliente.Location = new Point(20, 176);
            lblDniCliente.Name = "lblDniCliente";
            lblDniCliente.Size = new Size(64, 20);
            lblDniCliente.TabIndex = 15;
            lblDniCliente.Text = "Clientes:";
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 20;
            lstClientes.Location = new Point(20, 211);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(386, 204);
            lstClientes.TabIndex = 16;
            lstClientes.Format += lstClientes_Format;
            // 
            // FormIngresarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(683, 453);
            Controls.Add(lstClientes);
            Controls.Add(lblDniCliente);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(btnReset);
            Controls.Add(cmbMetodoPago);
            Controls.Add(txtEmpleadoId);
            Controls.Add(txtBebidaId);
            Controls.Add(lblMetodoPago);
            Controls.Add(lblEmpleadoId);
            Controls.Add(lblBebidaId);
            Controls.Add(lblVenta);
            Name = "FormIngresarVenta";
            Text = "FormIngresarVenta";
            Load += FormIngresarVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVenta;
        private Label lblBebidaId;
        private Label lblEmpleadoId;
        private Label lblMetodoPago;
        private TextBox txtBebidaId;
        private TextBox txtEmpleadoId;
        private ComboBox cmbMetodoPago;
        private Button btnReset;
        private Button btnAgregar;
        private Button btnCancelar;
        private Label lblDniCliente;
        private ListBox lstClientes;
    }
}