namespace AvicolaVentas
{
    partial class FormBajaModificacionProveedor : Form
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
            dataGridViewProveedores = new DataGridView();
            button1 = new Button();
            buttonEliminarProveedor = new Button();
            buttonModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProveedores
            // 
            dataGridViewProveedores.BackgroundColor = Color.Gainsboro;
            dataGridViewProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProveedores.Location = new Point(34, 53);
            dataGridViewProveedores.Name = "dataGridViewProveedores";
            dataGridViewProveedores.Size = new Size(646, 338);
            dataGridViewProveedores.TabIndex = 0;
            dataGridViewProveedores.CellContentClick += dataGridViewProveedores_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(34, 12);
            button1.Name = "button1";
            button1.Size = new Size(43, 23);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonEliminarProveedor
            // 
            buttonEliminarProveedor.BackColor = Color.Silver;
            buttonEliminarProveedor.Location = new Point(430, 462);
            buttonEliminarProveedor.Name = "buttonEliminarProveedor";
            buttonEliminarProveedor.Size = new Size(107, 38);
            buttonEliminarProveedor.TabIndex = 2;
            buttonEliminarProveedor.Text = "Eliminar";
            buttonEliminarProveedor.UseVisualStyleBackColor = false;
            buttonEliminarProveedor.Click += buttonEliminarProveedor_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.BackColor = Color.Silver;
            buttonModificar.Location = new Point(573, 462);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(107, 38);
            buttonModificar.TabIndex = 3;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = false;
            buttonModificar.Click += buttonModificar_Click_1;
            // 
            // FormBajaModificacionProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(704, 522);
            Controls.Add(buttonModificar);
            Controls.Add(buttonEliminarProveedor);
            Controls.Add(button1);
            Controls.Add(dataGridViewProveedores);
            MinimumSize = new Size(720, 561);
            Name = "FormBajaModificacionProveedor";
            Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProveedores;
        private Button button1;
        private Button buttonEliminarProveedor;
        private Button buttonModificar;
    }
}