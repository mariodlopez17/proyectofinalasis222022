using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CapaVistaProduccion
{
    public partial class ordenes : Form
    {
        string connectionString = @"Server=localhost;Database=colchoneria;Uid=root;Pwd=root;";
        int idordenes_tbl_ordenes = 0;
        public ordenes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("pa_produccion_ordenes_agregareditar", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_idordenes_tbl_ordenes", idordenes_tbl_ordenes);
                mySqlCmd.Parameters.AddWithValue("_idreceta_tbl_ordenes", textBox2.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_prioridad_tbl_ordenes", comboBox1.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_producto_fabricar_tbl_ordenes", textBox3.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_cantidad", textBox4.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_fechaini_tbl_ordenes", dateTimePicker1.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_fechaent", dateTimePicker2.Text.Trim());
                mySqlCmd.ExecuteNonQuery();

                MessageBox.Show("Registro ingresado!");

                Clear();
            }
        }

        void Clear()
        {
            textBox2.Text  = textBox3.Text = textBox4.Text = dateTimePicker1.Text= dateTimePicker2.Text= comboBox1.Text = "";
            idordenes_tbl_ordenes = 0;

        }
      

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }

      

        
    }
}
