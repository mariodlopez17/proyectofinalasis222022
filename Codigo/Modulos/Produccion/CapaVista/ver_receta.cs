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
    public partial class ver_receta : Form
    {
        string connectionString = @"Server=localhost;Database=colchoneria;Uid=root;Pwd=root";
        int pk_idrecetas_tbl_recetas = 0;
        public ver_receta()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("pa_recetas_viewall", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblreceta = new DataTable();
                sqlDa.Fill(dtblreceta);
                dataGridView1.DataSource = dtblreceta;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridFill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                string deleteQuery = "DELETE FROM colchoneria.tbl_recetas WHERE pk_idrecetas_tbl_recetas = " + textBox1.Text;
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand(deleteQuery, mysqlCon);
                mySqlCmd.ExecuteNonQuery();

                MessageBox.Show("Eliminado Correctamente");

                
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
           {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                pk_idrecetas_tbl_recetas = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
 
            }
        }
    }
}
