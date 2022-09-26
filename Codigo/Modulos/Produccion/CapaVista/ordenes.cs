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
    public partial class ordenes : Form
    {
        public ordenes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ver_ordenes rep = new ver_ordenes();
            rep.Show();
        }
    }
}
