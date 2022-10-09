using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLLEjecucion
{
    public partial class DLLfinal : Form
    {
        public DLLfinal()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, txtestado};
            TextBox[] textboxi = { textBox1, textBox2};
            navegador1.textbox = textbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = textboxi;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, textbox, "controlempleados");
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void navegador1_Load_1(object sender, EventArgs e)
        {
            TextBox[] Grupotextbox = { textBox1, textBox2, textBox3, textBox4, txtestado };
            TextBox[] Idtextbox = { textBox1, textBox2 };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "controlempleados");
        }
    }
}
