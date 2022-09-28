using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class repproduccion : Form
    {
        public repproduccion()
        {
            InitializeComponent();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprimir_repproduccion rep = new imprimir_repproduccion();
            rep.ShowDialog();
        }

        private void repproduccion_Load(object sender, EventArgs e)
        {

        }
    }
}
