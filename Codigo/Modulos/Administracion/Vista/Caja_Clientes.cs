using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace   ComprasVista
{
    public partial class Caja_Clientes : Form
    {
        public Caja_Clientes()
        {
            InitializeComponent();
        }

        private void Caja_Clientes_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "3103";
            TextBox[] Grupotextbox = { txtIdCaja, txtSaldo, txtIdCliente, txtAbono };
            TextBox[] Idtextbox = { txtIdCaja, txtIdCliente };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = Dgv_CajaClientes;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(Dgv_CajaClientes, Grupotextbox, "colchoneria");
        }
    }
}
