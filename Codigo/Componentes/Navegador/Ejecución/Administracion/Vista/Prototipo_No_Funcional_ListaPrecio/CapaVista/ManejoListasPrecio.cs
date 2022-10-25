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
    public partial class ManejoListasPrecio : Form
    {
        public ManejoListasPrecio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarProducto cons = new AgregarProducto();
            cons.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListaPrecios cons = new ListaPrecios();
            cons.Show();
            this.Hide();
        }
    }
}
