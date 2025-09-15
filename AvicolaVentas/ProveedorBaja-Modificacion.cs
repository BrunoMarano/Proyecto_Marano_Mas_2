using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvicolaVentas
{
    public partial class FormBajaModificacionProveedor : Form
    {
        public FormBajaModificacionProveedor()
        {
            InitializeComponent();
        }

        // Método requerido por el DataGridView
        private void dataGridViewProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Por ahora vacío, podés agregar lógica después
        }

        // Evento para cerrar el formulario
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento para eliminar proveedor
        private void buttonEliminarProveedor_Click(object sender, EventArgs e)
        {
            // Lógica para eliminar proveedor
        }

        // Evento para modificar proveedor
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            // Lógica para modificar proveedor
        }
    }
}
