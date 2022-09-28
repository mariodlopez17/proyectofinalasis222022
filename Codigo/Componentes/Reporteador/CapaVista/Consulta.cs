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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes_ rep= new Reportes_();
            rep.ShowDialog();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "repbancos")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                repbancos rep = new repbancos();
                rep.MdiParent = this;
                rep.Show();
            }
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "repcompras")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                repcompras rep = new repcompras();
                rep.MdiParent = this;
                rep.Show();
            }
            
        }

        private void contabilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "repcontabilidad")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                repcontabilidad rep = new repcontabilidad();
                rep.MdiParent = this;
                rep.Show();
            }
            
        }

        private void nominasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "repnominas")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                repnominas rep = new repnominas();
                rep.MdiParent = this;
                rep.Show();
            }
            
        }

        private void logisticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "replogistica")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                replogistica rep = new replogistica();
                rep.MdiParent = this;
                rep.Show();
            }
            
        }

        private void produccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "repproduccion")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                repproduccion rep = new repproduccion();
                rep.MdiParent = this;
                rep.Show();
            }
        }
    }
}
