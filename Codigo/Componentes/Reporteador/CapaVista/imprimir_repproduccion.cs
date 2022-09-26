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
    public partial class imprimir_repproduccion : Form
    {
        public imprimir_repproduccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ver_reporteproduccion rep = new ver_reporteproduccion();
            rep.ShowDialog();
        }
    }
}
