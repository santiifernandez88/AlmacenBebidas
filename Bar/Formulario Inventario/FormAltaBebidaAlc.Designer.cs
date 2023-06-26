namespace Bar.Formulario_Inventario
{
    partial class FormAltaBebidaAlc
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
            components = new System.ComponentModel.Container();
            lblAlta = new Label();
            txtMarca = new TextBox();
            lblMarca = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblPrecio = new Label();
            lblStock = new Label();
            lblMLitros = new Label();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            txtMLitros = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblGradoAlc = new Label();
            txtGradoAlc = new TextBox();
            cmbTipoDeBebida = new ComboBox();
            lblTipo = new Label();
            btnReset = new Button();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblAlta
            // 
            lblAlta.AutoSize = true;
            lblAlta.BorderStyle = BorderStyle.Fixed3D;
            lblAlta.Font = new Font("Microsoft Himalaya", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlta.ForeColor = Color.White;
            lblAlta.Location = new Point(206, 30);
            lblAlta.Name = "lblAlta";
            lblAlta.Size = new Size(320, 46);
            lblAlta.TabIndex = 1;
            lblAlta.Text = "Alta de bebida alcoholica";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(126, 138);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(181, 27);
            txtMarca.TabIndex = 9;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.ForeColor = Color.White;
            lblMarca.Location = new Point(63, 145);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(53, 20);
            lblMarca.TabIndex = 10;
            lblMarca.Text = "Marca:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.ForeColor = Color.White;
            lblPrecio.Location = new Point(63, 193);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 12;
            lblPrecio.Text = "Precio:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.ForeColor = Color.White;
            lblStock.Location = new Point(68, 241);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(48, 20);
            lblStock.TabIndex = 13;
            lblStock.Text = "Stock:";
            // 
            // lblMLitros
            // 
            lblMLitros.AutoSize = true;
            lblMLitros.ForeColor = Color.White;
            lblMLitros.Location = new Point(42, 297);
            lblMLitros.Name = "lblMLitros";
            lblMLitros.Size = new Size(74, 20);
            lblMLitros.TabIndex = 14;
            lblMLitros.Text = "Mili litros:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(126, 190);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(181, 27);
            txtPrecio.TabIndex = 15;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(126, 241);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(181, 27);
            txtStock.TabIndex = 16;
            // 
            // txtMLitros
            // 
            txtMLitros.Location = new Point(126, 294);
            txtMLitros.Name = "txtMLitros";
            txtMLitros.Size = new Size(181, 27);
            txtMLitros.TabIndex = 17;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = Color.White;
            lblDescripcion.Location = new Point(409, 145);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 20);
            lblDescripcion.TabIndex = 18;
            lblDescripcion.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(505, 138);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(181, 27);
            txtDescripcion.TabIndex = 19;
            // 
            // lblGradoAlc
            // 
            lblGradoAlc.AutoSize = true;
            lblGradoAlc.ForeColor = Color.White;
            lblGradoAlc.Location = new Point(373, 193);
            lblGradoAlc.Name = "lblGradoAlc";
            lblGradoAlc.Size = new Size(126, 20);
            lblGradoAlc.TabIndex = 20;
            lblGradoAlc.Text = "Grado alcoholico:";
            // 
            // txtGradoAlc
            // 
            txtGradoAlc.Location = new Point(505, 186);
            txtGradoAlc.Name = "txtGradoAlc";
            txtGradoAlc.Size = new Size(181, 27);
            txtGradoAlc.TabIndex = 21;
            // 
            // cmbTipoDeBebida
            // 
            cmbTipoDeBebida.FormattingEnabled = true;
            cmbTipoDeBebida.Location = new Point(505, 241);
            cmbTipoDeBebida.Name = "cmbTipoDeBebida";
            cmbTipoDeBebida.Size = new Size(181, 28);
            cmbTipoDeBebida.TabIndex = 22;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.ForeColor = Color.White;
            lblTipo.Location = new Point(385, 248);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(114, 20);
            lblTipo.TabIndex = 23;
            lblTipo.Text = "Tipo de bebida:";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.CadetBlue;
            btnReset.Cursor = Cursors.Hand;
            btnReset.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(571, 328);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(115, 38);
            btnReset.TabIndex = 24;
            btnReset.Text = "Resetear";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.CadetBlue;
            btnCancelar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(348, 403);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 47);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.CadetBlue;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(505, 372);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(181, 78);
            btnAceptar.TabIndex = 26;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FormAltaBebidaAlc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(711, 474);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(btnReset);
            Controls.Add(lblTipo);
            Controls.Add(cmbTipoDeBebida);
            Controls.Add(txtGradoAlc);
            Controls.Add(lblGradoAlc);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtMLitros);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(lblMLitros);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblMarca);
            Controls.Add(txtMarca);
            Controls.Add(lblAlta);
            ForeColor = Color.Transparent;
            Name = "FormAltaBebidaAlc";
            Text = "FormAltaBebidaAlc";
            Load += FormAltaBebidaAlc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblAlta;
        public TextBox txtMarca;
        public Label lblMarca;
        private ContextMenuStrip contextMenuStrip1;
        public Label lblPrecio;
        public Label lblStock;
        public Label lblMLitros;
        public TextBox txtPrecio;
        public TextBox txtStock;
        public TextBox txtMLitros;
        public Label lblDescripcion;
        public TextBox txtDescripcion;
        public Label lblGradoAlc;
        public TextBox txtGradoAlc;
        private ComboBox cmbTipoDeBebida;
        public Label lblTipo;
        public Button btnReset;
        public Button btnCancelar;
        public Button btnAceptar;
    }
}