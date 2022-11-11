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
    public partial class Recetas : Form
    {
        string connectionString = @"Server=colchoneria.mysql.database.azure.com;Database=colchoneria;Uid=administrador;Pwd=Jm123456;";
        int pk_idrecetas_tbl_recetas = 0;
        public Recetas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("pa_recetas_agregareditar", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_pk_idrecetas_tbl_recetas", pk_idrecetas_tbl_recetas);
                mySqlCmd.Parameters.AddWithValue("_producto_tbl_recetas", textBox2.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_nombre_material_tbl_recetas", textBox4.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_cantidad_tbl_recetas", comboBox1.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_medida_tbl_recetas", textBox1.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Guardado Correctamente");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
