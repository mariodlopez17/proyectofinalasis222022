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
    public partial class Bancos1 : Form
    {
        private dummie forma;
        public Bancos1()
        {
            InitializeComponent();
            HideStart();
        }
        private void HideStart()
        {
            //Metodo para cubrir los paneles
            panelConceptosBanc.Visible = false;
            panelPartidasCont.Visible = false;
            panelRepBanc.Visible = false;
        }
        private void hideSubMenu()
        {
              if (panelConceptosBanc.Visible == true)
                panelConceptosBanc.Visible = false;
            if (panelPartidasCont.Visible == true)
                panelPartidasCont.Visible = false;
            if (panelRepBanc.Visible == true)
                panelRepBanc.Visible = false;

            /*if (panelClientes.Visible == true)
                panelClientes.Visible = false;
            if (panel1.Visible == true)
                panel1.Visible = false;
            if (panel2.Visible == true)
                panel2.Visible = false;*/
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = true;
        }

        private void Bancos1_Load(object sender, EventArgs e)
        {

        }
        private void btnCompras_Click(object sender, EventArgs e)
        {
            showSubMenu(panelConceptosBanc);
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            /*if (forma == null)
            {
                forma = new dummie();
                //forma.MdiParent = this;
                forma.FormClosed += new FormClosedEventHandler(CerrarForma);
                forma.Show();
            }
            else
            {
                forma.Activate();
            }*/
        }

        private void btnPartidasCont_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPartidasCont);
        }

        private void btnPolizas_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnRepBanc_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRepBanc);
        }
        void CerrarForma(object sender, FormClosedEventArgs e)
        {
            forma = null;
        }

        private void btnMovBanc_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
    }
}
