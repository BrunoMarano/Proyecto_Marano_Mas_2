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
    public partial class Baja_ModificarUsuario : Form
    {
        public Baja_ModificarUsuario()
        {
            InitializeComponent();
        }

        private void BModificarUsuario_Click(object sender, EventArgs e)
        {
            ModificarUsuario FModificarUsuario = new ModificarUsuario();

            FModificarUsuario.Show();
        }
    }
}
