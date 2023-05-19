namespace Bar.Formulario_Empleados
{
    partial class FormAltaEmpleado
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblEdad = new Label();
            lblDni = new Label();
            lblSueldo = new Label();
            lblPuesto = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEdad = new TextBox();
            txtDni = new TextBox();
            txtSueldo = new TextBox();
            btnAceptar = new Button();
            btnReset = new Button();
            cmbPuesto = new ComboBox();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            lblContraseña = new Label();
            lblNombreUsuario = new Label();
            txtContraseña = new TextBox();
            txtNombreUsuario = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // lblAlta
            // 
            lblAlta.AutoSize = true;
            lblAlta.BorderStyle = BorderStyle.Fixed3D;
            lblAlta.Font = new Font("Microsoft Himalaya", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlta.ForeColor = Color.White;
            lblAlta.Location = new Point(173, 18);
            lblAlta.Name = "lblAlta";
            lblAlta.Size = new Size(228, 46);
            lblAlta.TabIndex = 0;
            lblAlta.Text = "Alta de empleado";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(32, 128);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.ForeColor = Color.White;
            lblApellido.Location = new Point(30, 182);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.ForeColor = Color.White;
            lblEdad.Location = new Point(53, 237);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(46, 20);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.ForeColor = Color.White;
            lblDni.Location = new Point(61, 284);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(38, 20);
            lblDni.TabIndex = 4;
            lblDni.Text = "DNI:";
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.ForeColor = Color.White;
            lblSueldo.Location = new Point(352, 128);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(58, 20);
            lblSueldo.TabIndex = 6;
            lblSueldo.Text = "Sueldo:";
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.ForeColor = Color.White;
            lblPuesto.Location = new Point(345, 187);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(56, 20);
            lblPuesto.TabIndex = 7;
            lblPuesto.Text = "Puesto:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(121, 121);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(181, 27);
            txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(121, 175);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(181, 27);
            txtApellido.TabIndex = 9;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(121, 230);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(180, 27);
            txtEdad.TabIndex = 10;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(121, 284);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(181, 27);
            txtDni.TabIndex = 11;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(416, 121);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(157, 27);
            txtSueldo.TabIndex = 13;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.CadetBlue;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(366, 478);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(210, 72);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.CadetBlue;
            btnReset.Cursor = Cursors.Hand;
            btnReset.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(416, 270);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(139, 47);
            btnReset.TabIndex = 16;
            btnReset.Text = "Resetear";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // cmbPuesto
            // 
            cmbPuesto.FormattingEnabled = true;
            cmbPuesto.Location = new Point(416, 179);
            cmbPuesto.Name = "cmbPuesto";
            cmbPuesto.Size = new Size(157, 28);
            cmbPuesto.TabIndex = 17;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.CadetBlue;
            btnCancelar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(53, 503);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 47);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(368, 221);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 263);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 20;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.ForeColor = Color.White;
            lblContraseña.Location = new Point(66, 426);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(86, 20);
            lblContraseña.TabIndex = 21;
            lblContraseña.Text = "Contraseña:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.ForeColor = Color.White;
            lblNombreUsuario.Location = new Point(7, 385);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(142, 20);
            lblNombreUsuario.TabIndex = 22;
            lblNombreUsuario.Text = "Nombre de Usuario:";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(155, 423);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(157, 27);
            txtContraseña.TabIndex = 23;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(155, 382);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(157, 27);
            txtNombreUsuario.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Microsoft Himalaya", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(173, 329);
            label5.Name = "label5";
            label5.Size = new Size(88, 36);
            label5.TabIndex = 25;
            label5.Text = "Usuario";
            // 
            // FormAltaEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(599, 574);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(cmbPuesto);
            Controls.Add(btnReset);
            Controls.Add(btnAceptar);
            Controls.Add(txtSueldo);
            Controls.Add(txtDni);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblPuesto);
            Controls.Add(lblSueldo);
            Controls.Add(lblDni);
            Controls.Add(lblEdad);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblAlta);
            ForeColor = Color.Black;
            Name = "FormAltaEmpleado";
            ShowIcon = false;
            Text = "FormAlta";
            Load += FormAlta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        public Label lblAlta;
        public Label lblNombre;
        public Label lblApellido;
        public Label lblEdad;
        public Label lblDni;
        public Label lblSueldo;
        public Label lblPuesto;
        public TextBox txtNombre;
        public TextBox txtApellido;
        public TextBox txtEdad;
        public TextBox txtDni;
        public TextBox txtSueldo;
        public Button btnAceptar;
        public Button btnReset;
        public ComboBox cmbPuesto;
        public Button btnCancelar;
        public Label lblContraseña;
        public Label lblNombreUsuario;
        public TextBox txtContraseña;
        public TextBox txtNombreUsuario;
        public Label label5;
    }
}