using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComprasVista
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            /*NavegadorVista.Navegador.idApp = "3001";
            TextBox[] Grupotextbox = { txtid,txtDpi,TxtNit,txtnombre,txtdomicilio,
            txttelefono,txtcorreo};
            TextBox[] Idtextbox = { txtid,txtDpi };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "modulo_comprasbd");*/
        }

        private void navegador1_Load_1(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "3001";
            TextBox[] Grupotextbox = { txtid,txtDpi,TxtNit,txtnombre,txtdomicilio,
            txttelefono,txtcorreo};
            TextBox[] Idtextbox = { txtid,txtDpi };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "colchoneria");
        }
    }
}
