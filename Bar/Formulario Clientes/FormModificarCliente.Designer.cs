namespace Bar.Formulario_Clientes
{
    partial class FormModificarCliente
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
            SuspendLayout();
            // 
            // cmbBebidaFavorita
            // 
            cmbBebidaFavorita.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBebidaFavorita.Items.AddRange(new object[] { Entidades.Clientes.Estatus.Activo, Entidades.Clientes.Estatus.PocoFrecuente, Entidades.Clientes.Estatus.Inactivo, Entidades.Clientes.Estatus.Activo, Entidades.Clientes.Estatus.PocoFrecuente, Entidades.Clientes.Estatus.Inactivo });
            // 
            // lblAlta
            // 
            lblAlta.Size = new Size(224, 46);
            lblAlta.Text = "Modificar cliente";
            // 
            // lblPuesto
            // 
            lblPuesto.Location = new Point(337, 178);
            lblPuesto.Size = new Size(82, 20);
            lblPuesto.Text = "Frecuencia:";
            // 
            // FormModificarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 435);
            Name = "FormModificarCliente";
            Text = "FormModificarCliente";
            Load += FormModificarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}