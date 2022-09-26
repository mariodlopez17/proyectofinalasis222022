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
    public partial class imprimir_repcompras : Form
    {
        public imprimir_repcompras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ver_reportecompras rep = new ver_reportecompras();
            rep.ShowDialog();
        }
    }
}
