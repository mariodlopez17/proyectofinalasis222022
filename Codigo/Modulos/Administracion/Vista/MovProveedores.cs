using System;
using ComprasControlador;
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
    public partial class MovProveedores : Form
    {
        string emp = "tblCajaProveedores";
        //Estamos instanciando
        csContralador cn = new csContralador();
        //Controlador cn = new Controlador();
        public MovProveedores()
        {
            InitializeComponent();
        }
        public void actualizardatagriew2()
        {
            //le pasamos el parametro de la tabla a consultar
            DataTable dt = cn.llenarTbl2(emp);
            dataGridView1.DataSource = dt;

        }
        public void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            actualizardatagriew2();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
      
            TextBox[] Grupo = { textBox1, textBox2, textBox3};
            cn.delete(Grupo, dataGridView1);
            cn.ingresar(Grupo, dataGridView1);
            actualizardatagriew2();
            limpiar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            TextBox[] Grupo = { textBox1, textBox2, textBox3};
            cn.delete(Grupo, dataGridView1);
            actualizardatagriew2();
            limpiar();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
         
            TextBox[] Grupo = { textBox1, textBox2, textBox3};
            cn.ingresar(Grupo, dataGridView1);
            actualizardatagriew2();
            limpiar();
        }
    }
}
