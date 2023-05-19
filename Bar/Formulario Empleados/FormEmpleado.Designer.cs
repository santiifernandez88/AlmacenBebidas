namespace Bar.Formulario_Empleados
{
    partial class FormEmpleado
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
            dtgEmpleado = new DataGridView();
            btnAltaEmp = new Button();
            btnBajaEmp = new Button();
            btnModEmp = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgEmpleado).BeginInit();
            SuspendLayout();
            // 
            // dtgEmpleado
            // 
            dtgEmpleado.BackgroundColor = Color.LightGray;
            dtgEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEmpleado.Location = new Point(276, 44);
            dtgEmpleado.Name = "dtgEmpleado";
            dtgEmpleado.RowHeadersWidth = 51;
            dtgEmpleado.RowTemplate.Height = 29;
            dtgEmpleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgEmpleado.Size = new Size(928, 654);
            dtgEmpleado.TabIndex = 2;
            dtgEmpleado.CellClick += dtgEmpleado_CellClick;
            // 
            // btnAltaEmp
            // 
            btnAltaEmp.BackColor = Color.DarkSlateGray;
            btnAltaEmp.ForeColor = Color.White;
            btnAltaEmp.Location = new Point(37, 137);
            btnAltaEmp.Name = "btnAltaEmp";
            btnAltaEmp.Size = new Size(175, 76);
            btnAltaEmp.TabIndex = 3;
            btnAltaEmp.Text = "Agregar";
            btnAltaEmp.UseVisualStyleBackColor = false;
            btnAltaEmp.Click += btnAltaEmp_Click;
            // 
            // btnBajaEmp
            // 
            btnBajaEmp.BackColor = Color.DarkSlateGray;
            btnBajaEmp.ForeColor = Color.White;
            btnBajaEmp.Location = new Point(37, 289);
            btnBajaEmp.Name = "btnBajaEmp";
            btnBajaEmp.Size = new Size(175, 84);
            btnBajaEmp.TabIndex = 4;
            btnBajaEmp.Text = "Eliminar";
            btnBajaEmp.UseVisualStyleBackColor = false;
            btnBajaEmp.Click += btnBajaEmp_Click;
            // 
            // btnModEmp
            // 
            btnModEmp.BackColor = Color.DarkSlateGray;
            btnModEmp.ForeColor = Color.White;
            btnModEmp.Location = new Point(37, 457);
            btnModEmp.Name = "btnModEmp";
            btnModEmp.Size = new Size(175, 89);
            btnModEmp.TabIndex = 5;
            btnModEmp.Text = "Modificar";
            btnModEmp.UseVisualStyleBackColor = false;
            btnModEmp.Click += btnModEmp_Click;
            // 
            // FormEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gris;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1231, 738);
            Controls.Add(btnModEmp);
            Controls.Add(btnBajaEmp);
            Controls.Add(btnAltaEmp);
            Controls.Add(dtgEmpleado);
            Name = "FormEmpleado";
            Text = "FormEmpleado";
            Load += FormEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)dtgEmpleado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dtgEmpleado;
        public Button btnAltaEmp;
        public Button btnBajaEmp;
        public Button btnModEmp;
    }
}