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
    public partial class repbancos : Form
    {
        public repbancos()
        {
            InitializeComponent();
        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprimir_repbancos rep = new imprimir_repbancos();
            rep.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
