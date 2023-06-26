namespace Bar
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            perfilToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            pnlDatos = new Panel();
            lblTipoUsuario = new Label();
            lblUsuario = new Label();
            label1 = new Label();
            lblId = new Label();
            lblApellido = new Label();
            picFotoUser = new PictureBox();
            lblNombre = new Label();
            menuStrip1.SuspendLayout();
            pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoUser).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkSlateGray;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, clientesToolStripMenuItem, empleadosToolStripMenuItem, inventarioToolStripMenuItem, perfilToolStripMenuItem, cerrarSesionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1347, 38);
            menuStrip1.TabIndex = 5;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("Microsoft Himalaya", 18F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripMenuItem1.ForeColor = Color.White;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(84, 34);
            toolStripMenuItem1.Text = "Ventas";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Font = new Font("Microsoft Himalaya", 18F, FontStyle.Regular, GraphicsUnit.Point);
            clientesToolStripMenuItem.ForeColor = Color.White;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(94, 34);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.Font = new Font("Microsoft Himalaya", 18F, FontStyle.Regular, GraphicsUnit.Point);
            empleadosToolStripMenuItem.ForeColor = Color.White;
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(117, 34);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.Font = new Font("Microsoft Himalaya", 18F, FontStyle.Regular, GraphicsUnit.Point);
            inventarioToolStripMenuItem.ForeColor = Color.White;
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(111, 34);
            inventarioToolStripMenuItem.Text = "Inventario";
            inventarioToolStripMenuItem.Click += inventarioToolStripMenuItem_Click;
            // 
            // perfilToolStripMenuItem
            // 
            perfilToolStripMenuItem.Font = new Font("Microsoft Himalaya", 18F, FontStyle.Regular, GraphicsUnit.Point);
            perfilToolStripMenuItem.ForeColor = Color.White;
            perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            perfilToolStripMenuItem.Size = new Size(73, 34);
            perfilToolStripMenuItem.Text = "Perfil";
            perfilToolStripMenuItem.Click += perfilToolStripMenuItem_Click;
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Font = new Font("Microsoft Himalaya", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cerrarSesionToolStripMenuItem.ForeColor = Color.White;
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(135, 34);
            cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // pnlDatos
            // 
            pnlDatos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlDatos.AutoSize = true;
            pnlDatos.BackColor = Color.DarkSlateGray;
            pnlDatos.BorderStyle = BorderStyle.Fixed3D;
            pnlDatos.Controls.Add(lblTipoUsuario);
            pnlDatos.Controls.Add(lblUsuario);
            pnlDatos.Controls.Add(label1);
            pnlDatos.Controls.Add(lblId);
            pnlDatos.Controls.Add(lblApellido);
            pnlDatos.Controls.Add(picFotoUser);
            pnlDatos.Controls.Add(lblNombre);
            pnlDatos.Cursor = Cursors.Hand;
            pnlDatos.Location = new Point(0, 708);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(275, 135);
            pnlDatos.TabIndex = 7;
            pnlDatos.Click += pnlDatos_Click;
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.ForeColor = Color.White;
            lblTipoUsuario.Location = new Point(168, 11);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(55, 20);
            lblTipoUsuario.TabIndex = 12;
            lblTipoUsuario.Text = "asdasd";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BorderStyle = BorderStyle.Fixed3D;
            lblUsuario.FlatStyle = FlatStyle.Popup;
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(82, 10);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(61, 22);
            lblUsuario.TabIndex = 11;
            lblUsuario.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(142, 88);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 10;
            label1.Text = "ID: ";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.ForeColor = Color.White;
            lblId.Location = new Point(168, 88);
            lblId.Name = "lblId";
            lblId.Size = new Size(64, 20);
            lblId.TabIndex = 9;
            lblId.Text = "asddsad";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.ForeColor = Color.White;
            lblApellido.Location = new Point(82, 68);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(64, 20);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "asddsad";
            // 
            // picFotoUser
            // 
            picFotoUser.BackgroundImage = (Image)resources.GetObject("picFotoUser.BackgroundImage");
            picFotoUser.BackgroundImageLayout = ImageLayout.Stretch;
            picFotoUser.Location = new Point(3, 24);
            picFotoUser.Name = "picFotoUser";
            picFotoUser.Size = new Size(73, 67);
            picFotoUser.TabIndex = 7;
            picFotoUser.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(82, 39);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "asddsad";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1347, 843);
            Controls.Add(pnlDatos);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            FormClosed += MenuPrincipal_FormClosed;
            Load += MenuPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem perfilToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private Panel pnlDatos;
        private Label lblTipoUsuario;
        private Label lblUsuario;
        private Label label1;
        private Label lblId;
        private Label lblApellido;
        private PictureBox picFotoUser;
        private Label lblNombre;
    }
}