namespace Bar
{
    partial class FormVentas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblSaldo = new Label();
            btnIniciarVenta = new Button();
            lblCantidad = new Label();
            label1 = new Label();
            btnBorrarVenta = new Button();
            lblHistorial = new Label();
            dtgVentas = new DataGridView();
            btnGenerarComprobante = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgVentas).BeginInit();
            SuspendLayout();
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.BackColor = Color.DarkSlateGray;
            lblSaldo.Font = new Font("Microsoft Himalaya", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.White;
            lblSaldo.Location = new Point(35, 44);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(180, 40);
            lblSaldo.TabIndex = 3;
            lblSaldo.Text = "GANANCIAS:";
            // 
            // btnIniciarVenta
            // 
            btnIniciarVenta.BackColor = Color.DarkSlateGray;
            btnIniciarVenta.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciarVenta.Location = new Point(35, 185);
            btnIniciarVenta.Name = "btnIniciarVenta";
            btnIniciarVenta.Size = new Size(218, 101);
            btnIniciarVenta.TabIndex = 4;
            btnIniciarVenta.Text = "Iniciar venta";
            btnIniciarVenta.UseVisualStyleBackColor = false;
            btnIniciarVenta.Click += btnIniciarVenta_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.DarkSlateGray;
            lblCantidad.BorderStyle = BorderStyle.Fixed3D;
            lblCantidad.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidad.ForeColor = Color.White;
            lblCantidad.Location = new Point(79, 95);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(117, 34);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "1.000.000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 95);
            label1.Name = "label1";
            label1.Size = new Size(29, 34);
            label1.TabIndex = 6;
            label1.Text = "$";
            // 
            // btnBorrarVenta
            // 
            btnBorrarVenta.BackColor = Color.DarkSlateGray;
            btnBorrarVenta.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrarVenta.Location = new Point(35, 329);
            btnBorrarVenta.Name = "btnBorrarVenta";
            btnBorrarVenta.Size = new Size(218, 101);
            btnBorrarVenta.TabIndex = 7;
            btnBorrarVenta.Text = "Borrar venta";
            btnBorrarVenta.UseVisualStyleBackColor = false;
            btnBorrarVenta.Click += btnBorrarVenta_Click;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.BackColor = Color.DarkSlateGray;
            lblHistorial.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblHistorial.Location = new Point(297, 22);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(211, 32);
            lblHistorial.TabIndex = 8;
            lblHistorial.Text = "Historial de ventas";
            // 
            // dtgVentas
            // 
            dtgVentas.BackgroundColor = Color.LightGray;
            dtgVentas.ColumnHeadersHeight = 45;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dtgVentas.DefaultCellStyle = dataGridViewCellStyle1;
            dtgVentas.Location = new Point(297, 66);
            dtgVentas.Name = "dtgVentas";
            dtgVentas.RowHeadersWidth = 51;
            dtgVentas.RowTemplate.Height = 29;
            dtgVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgVentas.Size = new Size(1029, 592);
            dtgVentas.TabIndex = 2;
            dtgVentas.CellClick += dtgVentas_CellClick;
            // 
            // btnGenerarComprobante
            // 
            btnGenerarComprobante.BackColor = Color.DarkSlateGray;
            btnGenerarComprobante.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerarComprobante.Location = new Point(52, 478);
            btnGenerarComprobante.Name = "btnGenerarComprobante";
            btnGenerarComprobante.Size = new Size(181, 82);
            btnGenerarComprobante.TabIndex = 9;
            btnGenerarComprobante.Text = "Generar comprobante";
            btnGenerarComprobante.UseVisualStyleBackColor = false;
            btnGenerarComprobante.Click += btnGenerarComprobante_Click;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gris;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1338, 697);
            Controls.Add(btnGenerarComprobante);
            Controls.Add(dtgVentas);
            Controls.Add(lblHistorial);
            Controls.Add(btnBorrarVenta);
            Controls.Add(label1);
            Controls.Add(lblCantidad);
            Controls.Add(btnIniciarVenta);
            Controls.Add(lblSaldo);
            ForeColor = Color.White;
            Name = "FormVentas";
            Text = "vControlador.AcumuladorVentas();";
            Load += FormVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dtgVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSaldo;
        private Button btnIniciarVenta;
        private Label lblCantidad;
        private Label label1;
        private Button btnBorrarVenta;
        private Label lblHistorial;
        public DataGridView dtgVentas;
        private Button btnGenerarComprobante;
    }
}