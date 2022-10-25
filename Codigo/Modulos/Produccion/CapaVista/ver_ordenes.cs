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
    
    public partial class ver_ordenes : Form
    {
        string connectionString = @"Server=localhost;Database=colchoneria;Uid=root;Pwd=root;";
        int idordenes_tbl_ordenes = 0;
        public ver_ordenes()
        {
            InitializeComponent();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            idordenes_tbl_ordenes = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                string deleteQuery = "DELETE FROM colchoneria.tbl_ordenes WHERE idordenes_tbl_ordenes = " + textBox1.Text;
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand(deleteQuery, mysqlCon);
                mySqlCmd.ExecuteNonQuery();

                MessageBox.Show("Eliminado Correctamente");

                Clear();
            }
        }
        void Clear()
        {
            textBox1.Text  = "";
            idordenes_tbl_ordenes = 0;

        }
        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("pa_produccion_ordenes_ver", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbregistro = new DataTable();
                sqlDa.Fill(dtbregistro);
                dataGridView1.DataSource = dtbregistro;
                dataGridView1.Columns[0].Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }
    }
}
