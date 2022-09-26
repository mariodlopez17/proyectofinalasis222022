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
    public partial class imprimir_repbancos : Form
    {
        public imprimir_repbancos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ver_reporte rep = new ver_reporte();
            rep.ShowDialog();
        }
    }
}
