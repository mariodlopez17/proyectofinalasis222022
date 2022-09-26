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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Recetas rep = new Recetas();
            rep.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ordenes rep = new ordenes();
            rep.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            proceso_de_produccion rep = new proceso_de_produccion();
            rep.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reportes rep = new reportes();
            rep.Show();
        }
    }
}
