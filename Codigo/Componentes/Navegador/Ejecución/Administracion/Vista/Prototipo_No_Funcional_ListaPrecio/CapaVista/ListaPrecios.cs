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
    public partial class ListaPrecios : Form
    {
        public ListaPrecios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarListaPrecio cons = new AgregarListaPrecio();
            cons.Show();
            this.Hide();
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            ManejoListasPrecio cons = new ManejoListasPrecio();
            cons.Show();
            this.Hide();
        }
    }
}
