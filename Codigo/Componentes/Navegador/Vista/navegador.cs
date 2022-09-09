using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class navegador : Form
    {
        csControlador cn = new csControlador();
        public navegador()
        {
            InitializeComponent();
        }
        bool opcion;
        //si opcion es true será insercion
        //si opcion es false será actualizacion
        private void btnInsert_Click(object sender, EventArgs e)
        {
            opcion = true;
            cn.limpiar(this);
            cn.activar(this);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            opcion = false;
            TextBox[] textbox = { textBox1, textBox2 };
            cn.activar(this);
            cn.enfocar(textbox);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cn.llenartablaa(dgv_tabla.Tag.ToString(), dgv_tabla);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            if (opcion == true)//Insercion
            {
                cn.ingresar(textbox, dgv_tabla);
                MessageBox.Show("Dato agregado");
            }
            else if (opcion == false)
            {
                cn.actualizar(textbox, dgv_tabla);
                MessageBox.Show("Dato actualizado");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {

        }

        private void bnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }
    }
}
