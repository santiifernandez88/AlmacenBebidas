namespace Bar
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lbl_Login = new Label();
            lbl_NombreUsuario = new Label();
            txt_NombreUsuario = new TextBox();
            lbl_Contraseña = new Label();
            txt_Contraseña = new TextBox();
            btn_Ingresar = new Button();
            picAutoLogeo = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAutoLogeo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 516);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.copaVino;
            pictureBox1.Location = new Point(123, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 469);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_Login
            // 
            lbl_Login.AutoSize = true;
            lbl_Login.BackColor = Color.Transparent;
            lbl_Login.Font = new Font("Microsoft Himalaya", 40F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Login.ForeColor = Color.White;
            lbl_Login.Location = new Point(655, 60);
            lbl_Login.Name = "lbl_Login";
            lbl_Login.Size = new Size(134, 67);
            lbl_Login.TabIndex = 1;
            lbl_Login.Text = "Login";
            // 
            // lbl_NombreUsuario
            // 
            lbl_NombreUsuario.AutoSize = true;
            lbl_NombreUsuario.BackColor = Color.Transparent;
            lbl_NombreUsuario.Font = new Font("Microsoft Himalaya", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NombreUsuario.ForeColor = Color.White;
            lbl_NombreUsuario.Location = new Point(655, 167);
            lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            lbl_NombreUsuario.Size = new Size(132, 24);
            lbl_NombreUsuario.TabIndex = 2;
            lbl_NombreUsuario.Text = "Nombre de usuario";
            // 
            // txt_NombreUsuario
            // 
            txt_NombreUsuario.BorderStyle = BorderStyle.None;
            txt_NombreUsuario.ForeColor = Color.Black;
            txt_NombreUsuario.Location = new Point(607, 194);
            txt_NombreUsuario.Name = "txt_NombreUsuario";
            txt_NombreUsuario.Size = new Size(234, 20);
            txt_NombreUsuario.TabIndex = 3;
            txt_NombreUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_Contraseña
            // 
            lbl_Contraseña.AutoSize = true;
            lbl_Contraseña.BackColor = Color.Transparent;
            lbl_Contraseña.Font = new Font("Microsoft Himalaya", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Contraseña.ForeColor = Color.White;
            lbl_Contraseña.Location = new Point(680, 282);
            lbl_Contraseña.Name = "lbl_Contraseña";
            lbl_Contraseña.Size = new Size(81, 24);
            lbl_Contraseña.TabIndex = 4;
            lbl_Contraseña.Text = "Contraseña";
            lbl_Contraseña.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Contraseña
            // 
            txt_Contraseña.BorderStyle = BorderStyle.None;
            txt_Contraseña.ForeColor = Color.Black;
            txt_Contraseña.Location = new Point(607, 309);
            txt_Contraseña.Name = "txt_Contraseña";
            txt_Contraseña.PasswordChar = '*';
            txt_Contraseña.Size = new Size(234, 20);
            txt_Contraseña.TabIndex = 5;
            txt_Contraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.BackColor = Color.DarkSlateGray;
            btn_Ingresar.FlatAppearance.BorderColor = Color.White;
            btn_Ingresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 64);
            btn_Ingresar.FlatStyle = FlatStyle.Flat;
            btn_Ingresar.Font = new Font("Microsoft Himalaya", 24F, FontStyle.Underline, GraphicsUnit.Point);
            btn_Ingresar.ForeColor = Color.White;
            btn_Ingresar.Location = new Point(607, 397);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(234, 67);
            btn_Ingresar.TabIndex = 6;
            btn_Ingresar.Text = "Ingresar";
            btn_Ingresar.UseVisualStyleBackColor = false;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // picAutoLogeo
            // 
            picAutoLogeo.BackColor = Color.Black;
            picAutoLogeo.BackgroundImageLayout = ImageLayout.Stretch;
            picAutoLogeo.Image = Properties.Resources.Arrroba;
            picAutoLogeo.Location = new Point(885, 12);
            picAutoLogeo.Name = "picAutoLogeo";
            picAutoLogeo.Size = new Size(19, 11);
            picAutoLogeo.SizeMode = PictureBoxSizeMode.StretchImage;
            picAutoLogeo.TabIndex = 7;
            picAutoLogeo.TabStop = false;
            picAutoLogeo.Click += picAutoLogeo_Click;
            // 
            // Login
            // 
            AcceptButton = btn_Ingresar;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(916, 500);
            Controls.Add(picAutoLogeo);
            Controls.Add(btn_Ingresar);
            Controls.Add(txt_Contraseña);
            Controls.Add(lbl_Contraseña);
            Controls.Add(txt_NombreUsuario);
            Controls.Add(lbl_NombreUsuario);
            Controls.Add(lbl_Login);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += Login_FormClosed;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAutoLogeo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lbl_Login;
        private Label lbl_NombreUsuario;
        private TextBox txt_NombreUsuario;
        private Label lbl_Contraseña;
        private TextBox txt_Contraseña;
        private Button btn_Ingresar;
        private PictureBox picAutoLogeo;
    }
}