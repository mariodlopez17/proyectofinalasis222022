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
    public partial class Reportes_ : Form
    {
        
        public Reportes_()
        {
            InitializeComponent();
            String direc = textBox1.Text;
    }

        public void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirdocumento = new OpenFileDialog();
            if (abrirdocumento.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = abrirdocumento.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ver_reporte rep = new ver_reporte();
            rep.ShowDialog();


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

        private void button5_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                reportDocument.Load(Application.StartupPath + "\\CrystalReport1.rpt");
                reportDocument.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName;
                reportDocument.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate, printDialog.PrinterSettings.FromPage, printDialog.PrinterSettings.ToPage);
            }
        }
    }
}
