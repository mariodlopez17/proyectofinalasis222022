using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaNomina
{
    public partial class PuestosTrabajo : Form
    {
        public PuestosTrabajo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPuesto b = new AgregarPuesto();
            b.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
