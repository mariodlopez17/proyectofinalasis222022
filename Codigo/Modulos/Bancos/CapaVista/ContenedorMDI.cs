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
    public partial class ContenedorMDI : Form
    {
        private Bancos1 forma;
        public ContenedorMDI()
        {
            InitializeComponent();
        }

        private void ContenedorMDI_Load(object sender, EventArgs e)
        {

        }

        private void modulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bancosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (forma == null)
            {
                forma = new Bancos1();
                forma.MdiParent = this;
                forma.FormClosed += new FormClosedEventHandler(CerrarForma);
                forma.Show();
            }
            else
            {
                forma.Activate();
            }
        }
        void CerrarForma(object sender, FormClosedEventArgs e)
        {
            forma = null;
        }
    }
}
