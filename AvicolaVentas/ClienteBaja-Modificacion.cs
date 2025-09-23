using ModificaciónProductos;
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
    public partial class FormClienteBajaModificacion : Form
    {
        public FormClienteBajaModificacion()
        {
            InitializeComponent();
        }

        private void buttonSalirUsuarioBaja_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModificacionCliente_Click(object sender, EventArgs e)
        {
            ModificarCliente FModificarCliente = new ModificarCliente();

            FModificarCliente.Show();
        }
    }
}
