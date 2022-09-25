using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            paninvent.Visible = false;
            panelTranportes.Visible = false;
            PanelAuditoria.Visible = false;
          //  panManteniminetos.Visible = false;
            panelayuda.Visible = false;
            panelseguridad.Visible = false;
            //PANELARCHIVO.Visible = false;
        }


        public void imagen()
        {
            GRIMAGEN.Visible = true;
        }


        private void hideSubMenu()
        {
            if (paninvent.Visible == true)
                paninvent.Visible = false;
            if (panelTranportes.Visible == true)
                panelTranportes.Visible = false;
            if (PanelAuditoria.Visible == true)
                PanelAuditoria.Visible = false;
           // if (panManteniminetos.Visible == true)
               // panManteniminetos.Visible = false;
            if (panelseguridad.Visible == true)
                panelseguridad.Visible = false;
            if (panelayuda.Visible == true)
                panelayuda.Visible = false;
            //if (PANELARCHIVO.Visible == true)
               // PANELARCHIVO.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnInventarios_Click(object sender, EventArgs e)
        {
            showSubMenu(paninvent);
        }
        
        
        private void btnmovinvent_Click(object sender, EventArgs e)
        {
            Mov_inventa b = new Mov_inventa();
            b.MdiParent = this;
            b.Show();
            GRIMAGEN.Visible = false;
            hideSubMenu();
        }

        private void btnCierre_Click(object sender, EventArgs e)
        {
            Cierre b = new Cierre();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reportes b = new Reportes();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }

        private void btnTransporte_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTranportes);
        }

        private void btnTraslados_Click(object sender, EventArgs e)
        {
            Traslado b = new Traslado();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }

        private void btnContactoClientes_Click_1(object sender, EventArgs e)
        {
            Transporte b = new Transporte();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }

        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelAuditoria);
        }

        private void btnMuestreo_Click(object sender, EventArgs e)
        {
            Muestreo b = new Muestreo();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }

        private void btaudito_Click(object sender, EventArgs e)
        {
            Auditoria b = new Auditoria();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }

        private void btnmanteniminetos_Click(object sender, EventArgs e)
        {
           // showSubMenu(panManteniminetos);
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPendiente_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnmodulos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnseguridad_Click(object sender, EventArgs e)
        {
            showSubMenu(panelseguridad);
        }

        private void btnayu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelayuda);
        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   showSubMenu(PANELARCHIVO);
        }

        private void Menu_Activated(object sender, EventArgs e)
        {
            GRIMAGEN.Visible = true;
        }
    }
}
