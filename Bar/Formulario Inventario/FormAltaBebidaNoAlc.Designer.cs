namespace Bar.Formulario_Inventario
{
    partial class FormAltaBebidaNoAlc
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
            lblAlta = new Label();
            txtMarca = new TextBox();
            lblMarca = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtStock = new TextBox();
            lblStock = new Label();
            txtMLitros = new TextBox();
            lblMLitros = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            cmbTipoDeBebida = new ComboBox();
            cmbContieneAzuc = new ComboBox();
            lblTipo = new Label();
            lblContieneAzuc = new Label();
            btnReset = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblAlta
            // 
            lblAlta.AutoSize = true;
            lblAlta.BorderStyle = BorderStyle.Fixed3D;
            lblAlta.Font = new Font("Microsoft Himalaya", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlta.ForeColor = Color.White;
            lblAlta.Location = new Point(181, 38);
            lblAlta.Name = "lblAlta";
            lblAlta.Size = new Size(357, 46);
            lblAlta.TabIndex = 2;
            lblAlta.Text = "Alta de bebida no alcoholica";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(125, 147);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(181, 27);
            txtMarca.TabIndex = 10;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.ForeColor = Color.White;
            lblMarca.Location = new Point(66, 150);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(53, 20);
            lblMarca.TabIndex = 11;
            lblMarca.Text = "Marca:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(125, 209);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(181, 27);
            txtPrecio.TabIndex = 16;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.ForeColor = Color.White;
            lblPrecio.Location = new Point(66, 216);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 17;
            lblPrecio.Text = "Precio:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(125, 271);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(181, 27);
            txtStock.TabIndex = 18;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.ForeColor = Color.White;
            lblStock.Location = new Point(71, 274);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(48, 20);
            lblStock.TabIndex = 19;
            lblStock.Text = "Stock:";
            // 
            // txtMLitros
            // 
            txtMLitros.Location = new Point(125, 337);
            txtMLitros.Name = "txtMLitros";
            txtMLitros.Size = new Size(181, 27);
            txtMLitros.TabIndex = 20;
            // 
            // lblMLitros
            // 
            lblMLitros.AutoSize = true;
            lblMLitros.ForeColor = Color.White;
            lblMLitros.Location = new Point(45, 340);
            lblMLitros.Name = "lblMLitros";
            lblMLitros.Size = new Size(74, 20);
            lblMLitros.TabIndex = 21;
            lblMLitros.Text = "Mili litros:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(478, 143);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(181, 27);
            txtDescripcion.TabIndex = 22;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = Color.White;
            lblDescripcion.Location = new Point(382, 147);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 20);
            lblDescripcion.TabIndex = 23;
            lblDescripcion.Text = "Descripcion:";
            // 
            // cmbTipoDeBebida
            // 
            cmbTipoDeBebida.FormattingEnabled = true;
            cmbTipoDeBebida.Location = new Point(478, 274);
            cmbTipoDeBebida.Name = "cmbTipoDeBebida";
            cmbTipoDeBebida.Size = new Size(181, 28);
            cmbTipoDeBebida.TabIndex = 24;
            // 
            // cmbContieneAzuc
            // 
            cmbContieneAzuc.FormattingEnabled = true;
            cmbContieneAzuc.Location = new Point(478, 209);
            cmbContieneAzuc.Name = "cmbContieneAzuc";
            cmbContieneAzuc.Size = new Size(181, 28);
            cmbContieneAzuc.TabIndex = 25;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.ForeColor = Color.White;
            lblTipo.Location = new Point(358, 278);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(114, 20);
            lblTipo.TabIndex = 26;
            lblTipo.Text = "Tipo de bebida:";
            // 
            // lblContieneAzuc
            // 
            lblContieneAzuc.AutoSize = true;
            lblContieneAzuc.ForeColor = Color.White;
            lblContieneAzuc.Location = new Point(354, 216);
            lblContieneAzuc.Name = "lblContieneAzuc";
            lblContieneAzuc.Size = new Size(118, 20);
            lblContieneAzuc.TabIndex = 27;
            lblContieneAzuc.Text = "Contiene azucar:";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.CadetBlue;
            btnReset.Cursor = Cursors.Hand;
            btnReset.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(544, 359);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(115, 38);
            btnReset.TabIndex = 28;
            btnReset.Text = "Resetear";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.CadetBlue;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(478, 403);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(181, 78);
            btnAceptar.TabIndex = 29;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.CadetBlue;
            btnCancelar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(345, 434);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 47);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormAltaBebidaNoAlc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(687, 511);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnReset);
            Controls.Add(lblContieneAzuc);
            Controls.Add(lblTipo);
            Controls.Add(cmbContieneAzuc);
            Controls.Add(cmbTipoDeBebida);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(lblMLitros);
            Controls.Add(txtMLitros);
            Controls.Add(lblStock);
            Controls.Add(txtStock);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(lblMarca);
            Controls.Add(txtMarca);
            Controls.Add(lblAlta);
            Name = "FormAltaBebidaNoAlc";
            Text = "FormAltaBebidaNoAlc";
            Load += FormAltaBebidaAlc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblAlta;
        public TextBox txtMarca;
        public Label lblMarca;
        public TextBox txtPrecio;
        public Label lblPrecio;
        public TextBox txtStock;
        public Label lblStock;
        public TextBox txtMLitros;
        public Label lblMLitros;
        public TextBox txtDescripcion;
        public Label lblDescripcion;
        private ComboBox cmbTipoDeBebida;
        private ComboBox cmbContieneAzuc;
        public Label lblTipo;
        public Label lblContieneAzuc;
        public Button btnReset;
        public Button btnAceptar;
        public Button btnCancelar;
    }
}