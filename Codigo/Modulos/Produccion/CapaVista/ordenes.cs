using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CapaVistaProduccion
{
    public partial class ordenes : Form
    {
       
        public ordenes()
        {
            InitializeComponent();
        }


        void Clear()
        {
           /* textBox2.Text = textBox3.Text = textBox4.Text = dateTimePicker3.Text = textBox1.Text = dateTimePicker1.Text = dateTimePicker2.Text = comboBox1.Text = "";
            pk_idordenes_tbl_ordenes = 0;*/

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ordenes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           /* using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("pa_produccion_ordenes_agregareditar", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_pk_idordenes_tbl_ordenes", pk_idordenes_tbl_ordenes);
                mySqlCmd.Parameters.AddWithValue("_fk_idrecetas_tbl_recetas", textBox2.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_prioridad_tbl_ordenes", comboBox1.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_producto_fabricar_tbl_ordenes", textBox3.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_cantidad_tbl_ordenes", textBox4.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_fechaini_tbl_ordenes", dateTimePicker1.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_fechaentrega_tbl_ordenes", dateTimePicker2.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_fechacreacion_orden_tbl_ordenes", dateTimePicker3.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_detalle_tbl_ordenes", textBox1.Text.Trim());
                mySqlCmd.ExecuteNonQuery();

                MessageBox.Show("Registro ingresado!");

                Clear();

            }*/
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        void textbox()
        {
         

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
           /* fechacrea.Text = dateTimePicker3.Text;
            num_receta.Text= textBox2.Text;
            prioridadtxt.Text= comboBox1.Text;
            prod_fabricar.Text= textBox3.Text;
            fechainic.Text= dateTimePicker1.Text;
            textBox5.Text= textBox4.Text;
            fechaent.Text= dateTimePicker2.Text;
            detalle.Text= textBox1.Text;*/
        }

        private void dateTimePicker3_CloseUp(object sender, EventArgs e)
        {
            /* fechacrea.Text = dateTimePicker3.Text;
                num_receta.Text= textBox2.Text;
                prioridadtxt.Text= comboBox1.Text;
                prod_fabricar.Text= textBox3.Text;
                fechainic.Text= dateTimePicker1.Text;
                textBox5.Text= textBox4.Text;
                fechaent.Text= dateTimePicker2.Text;
                detalle.Text= textBox1.Text;*/
        }


        private void navegador1_Load_2(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "5102";
            TextBox[] Grupotextbox = { num_orden, num_receta, prioridadtxt, prod_fabricar, textBox4, fechainic, fechaent, fechacrea, detalle };
            TextBox[] Idtextbox = { num_orden, num_receta };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "colchoneria");
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            fechacrea.Text = dateTimePicker1.Text;
            prioridadtxt.Text = comboBox1.Text;
            fechainic.Text = dateTimePicker2.Text;
            fechaent.Text = dateTimePicker3.Text;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            fechacrea.Text = dateTimePicker1.Text;
            prioridadtxt.Text = comboBox1.Text;
            fechainic.Text = dateTimePicker2.Text;
            fechaent.Text = dateTimePicker3.Text;
        }

        private void detalle_TextChanged(object sender, EventArgs e)
        {
            fechacrea.Text = dateTimePicker1.Text;
            prioridadtxt.Text = comboBox1.Text;
            fechainic.Text = dateTimePicker2.Text;
            fechaent.Text = dateTimePicker3.Text;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            fechacrea.Text = dateTimePicker1.Text;
            prioridadtxt.Text = comboBox1.Text;
            fechainic.Text = dateTimePicker2.Text;
            fechaent.Text = dateTimePicker3.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fechacrea.Text = dateTimePicker1.Text;
            prioridadtxt.Text = comboBox1.Text;
            fechainic.Text = dateTimePicker2.Text;
            fechaent.Text = dateTimePicker3.Text;
        }

        private void prod_fabricar_TextChanged(object sender, EventArgs e)
        {
            fechacrea.Text = dateTimePicker1.Text;
            prioridadtxt.Text = comboBox1.Text;
            fechainic.Text = dateTimePicker2.Text;
            fechaent.Text = dateTimePicker3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            fechacrea.Text = dateTimePicker1.Text;
            prioridadtxt.Text = comboBox1.Text;
            fechainic.Text = dateTimePicker2.Text;
            fechaent.Text = dateTimePicker3.Text;
        }

        private void num_receta_TextChanged(object sender, EventArgs e)
        {
            fechacrea.Text = dateTimePicker1.Text;
            prioridadtxt.Text = comboBox1.Text;
            fechainic.Text = dateTimePicker2.Text;
            fechaent.Text = dateTimePicker3.Text;
        }
    }
}
