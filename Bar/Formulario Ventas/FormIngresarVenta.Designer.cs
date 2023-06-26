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
            lblMetodoPago = new Label();
            cmbMetodoPago = new ComboBox();
            btnReset = new Button();
            btnAgregar = new Button();
            btnCancelar = new Button();
            lblCliente = new Label();
            lstCliente = new ListBox();
            lblTipoBebida = new Label();
            cmbBebida = new ComboBox();
            lstBebidas = new ListBox();
            btnAplicar = new Button();
            lblCombo = new Label();
            SuspendLayout();
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.BorderStyle = BorderStyle.Fixed3D;
            lblVenta.Font = new Font("Microsoft Himalaya", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblVenta.ForeColor = Color.White;
            lblVenta.Location = new Point(315, 22);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(207, 42);
            lblVenta.TabIndex = 1;
            lblVenta.Text = "NUEVA VENTA";
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.ForeColor = Color.White;
            lblMetodoPago.Location = new Point(457, 109);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(125, 20);
            lblMetodoPago.TabIndex = 7;
            lblMetodoPago.Text = "Metodo de pago:";
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Location = new Point(588, 106);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(214, 28);
            cmbMetodoPago.TabIndex = 10;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.CadetBlue;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(648, 402);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(164, 38);
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
            btnAgregar.Location = new Point(441, 443);
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
            btnCancelar.Location = new Point(648, 473);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(164, 53);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.ForeColor = Color.White;
            lblCliente.Location = new Point(457, 149);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(88, 20);
            lblCliente.TabIndex = 18;
            lblCliente.Text = "Cliente DNI:";
            // 
            // lstCliente
            // 
            lstCliente.FormattingEnabled = true;
            lstCliente.ItemHeight = 20;
            lstCliente.Location = new Point(457, 177);
            lstCliente.Name = "lstCliente";
            lstCliente.Size = new Size(355, 204);
            lstCliente.TabIndex = 19;
            // 
            // lblTipoBebida
            // 
            lblTipoBebida.AutoSize = true;
            lblTipoBebida.ForeColor = Color.White;
            lblTipoBebida.Location = new Point(48, 109);
            lblTipoBebida.Name = "lblTipoBebida";
            lblTipoBebida.Size = new Size(114, 20);
            lblTipoBebida.TabIndex = 16;
            lblTipoBebida.Text = "Tipo de bebida:";
            // 
            // cmbBebida
            // 
            cmbBebida.FormattingEnabled = true;
            cmbBebida.Location = new Point(167, 106);
            cmbBebida.Name = "cmbBebida";
            cmbBebida.Size = new Size(243, 28);
            cmbBebida.TabIndex = 15;
            cmbBebida.SelectedIndexChanged += cmbBebida_SelectedIndexChanged;
            // 
            // lstBebidas
            // 
            lstBebidas.FormattingEnabled = true;
            lstBebidas.ItemHeight = 20;
            lstBebidas.Location = new Point(48, 177);
            lstBebidas.Name = "lstBebidas";
            lstBebidas.Size = new Size(362, 204);
            lstBebidas.TabIndex = 17;
            lstBebidas.Format += lstBebidas_Format;
            // 
            // btnAplicar
            // 
            btnAplicar.AutoSize = true;
            btnAplicar.BackColor = Color.CadetBlue;
            btnAplicar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAplicar.ForeColor = Color.White;
            btnAplicar.Location = new Point(315, 387);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(95, 36);
            btnAplicar.TabIndex = 21;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // lblCombo
            // 
            lblCombo.AutoSize = true;
            lblCombo.ForeColor = Color.White;
            lblCombo.Location = new Point(48, 473);
            lblCombo.Name = "lblCombo";
            lblCombo.Size = new Size(50, 20);
            lblCombo.TabIndex = 22;
            lblCombo.Text = "label1";
            // 
            // FormIngresarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(848, 558);
            Controls.Add(lblCombo);
            Controls.Add(btnAplicar);
            Controls.Add(lstCliente);
            Controls.Add(lblCliente);
            Controls.Add(lstBebidas);
            Controls.Add(lblTipoBebida);
            Controls.Add(cmbBebida);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(btnReset);
            Controls.Add(cmbMetodoPago);
            Controls.Add(lblMetodoPago);
            Controls.Add(lblVenta);
            Name = "FormIngresarVenta";
            Text = "FormIngresarVenta";
            Load += FormIngresarVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVenta;
        private Label lblMetodoPago;
        private ComboBox cmbMetodoPago;
        private Button btnReset;
        private Button btnAgregar;
        private Button btnCancelar;
        private Label lblCliente;
        private ListBox lstCliente;
        private Label lblTipoBebida;
        private ComboBox cmbBebida;
        private ListBox lstBebidas;
        private Button btnAplicar;
        private Label lblCombo;
    }
}