using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControladorLogistica;

namespace VistaLogistica
{
    public partial class ExistenciaBodega : Form
    {






        Controlador cn = new Controlador();
        string table = "tbl_exisbodega";
        int cont = 1;





        public ExistenciaBodega()
        {
            InitializeComponent();
        }



        public void getId()
        {
            try
            {
                string dato;
                dato = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtIdBodega.Text = dato;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener el valor");
            }
        }

        public void getIds()
        {
            try
            {
                string dato;
                dato = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (txtIdProducto.Text == "")
                {
                    txtIdProducto.Text = dato;
                }
                else
                {
                    string valor = txtIdProducto.Text;
                    txtIdProducto.Text = valor + "," + dato;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener las aplicaciones del perfil");
            }
        }

       /* public void actualizardatagriew()
        {
            string id = txtIdBodega.Text;
            cn.llenarListAsignaciones(dtgExisBodega.Tag.ToString(), dtgExisBodega, id);
        }*/


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExistenciaBodega_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
           
        }

        private void AsignacionPuestoDepto_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            cn.llenarListPuestos(dataGridView1.Tag.ToString(), dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cont = 1;
           // dataGridView1.Columns.Clear();
            cn.llenarListPuestos(dataGridView1.Tag.ToString(), dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cont == 1)
            {
                //Metodo que lleva valor Unico
                getId();
            }
            else if (cont == 2)
            {
                //Metodo que lleva valor con coma 1,2,3
                getIds();
            }

            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] delimiterChars = { ',' };
            string text = txtIdProducto.Text;
            string[] words = text.Split(delimiterChars);

            foreach (var word in words)
            {
                textBox1.Text = word;
                TextBox[] textbox = { txtIdBodega, textBox1, txtExistencia };
                cn.ingresar(textbox, table);
            }
            string message = "Registro Guardado";
            //actualizardatagriew();
           
            MessageBox.Show(message);
        }
    }
}
