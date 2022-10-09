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
    public partial class ControlBajas : Form
    {
        public ControlBajas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //880; 587

            if (ListaDatos.Visible == false)
            {
                ListaDatos.Visible = true;
                Size = new Size(880, 587);
            }
            else
            {
                //556; 587
                ListaDatos.Visible = false;
                Size = new Size(556, 587);
            }
        }

        private void ControlBajas_Load(object sender, EventArgs e)
        {
            Size = new Size(556, 587);
        }
    }
}
