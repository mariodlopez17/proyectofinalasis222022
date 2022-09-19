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
    public partial class Reportes : Form
    {
        
        public Reportes()
        {
            InitializeComponent();
            String direc = textBox1.Text;
    }

        public void button1_Click(object sender, EventArgs e)
        {
            InformacionReporte inforep = new InformacionReporte();
            OpenFileDialog abrirdocumento = new OpenFileDialog();
            if (abrirdocumento.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = abrirdocumento.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InformacionReporte inforep = new InformacionReporte();
            inforep.Show();
            inforep.axAcroPDF1_reporteria.src = textBox1.Text;
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
