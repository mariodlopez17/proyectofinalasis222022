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
    public partial class Cheque : Form
    {
        private static Cheque instancia = null;

        public static Cheque ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new Cheque();
                return instancia;
            }
            return instancia;
        }
        public Cheque()
        {
            InitializeComponent();
        }

        public static implicit operator Cheque(dummie v)
        {
            throw new NotImplementedException();
        }
    }
}
