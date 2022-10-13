using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaNomina
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelCatalogos.Visible = false;
            panelProcesos.Visible = false;
            panelReportes.Visible = false;
            panelSeguridad.Visible = false;
            panelAyuda.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelCatalogos.Visible == true)
                panelCatalogos.Visible = false;
            if (panelProcesos.Visible == true)
                panelProcesos.Visible = false;
            if (panelReportes.Visible == true)
                panelReportes.Visible = false;
            if (panelSeguridad.Visible == true)
                panelSeguridad.Visible = false; 
            if (panelAyuda.Visible == true)
                panelAyuda.Visible = false;
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

        private void btnCatalogos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCatalogos);
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProcesos);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReportes);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSeguridad);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAyuda);
        }

        private void btnTrabajadores_Click(object sender, EventArgs e)
        {
            TrabajadoresInfo b = new TrabajadoresInfo();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnAsPlanilla_Click(object sender, EventArgs e)
        {
            AsignacionTrabajadoresPlanillas b = new AsignacionTrabajadoresPlanillas();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnPuestos_Click(object sender, EventArgs e)
        {
            PuestosTrabajo b = new PuestosTrabajo();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnDepto_Click(object sender, EventArgs e)
        {
            Departamentos b = new Departamentos();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            Contrato b = new Contrato();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnLiquidacion_Click(object sender, EventArgs e)
        {

        }

        private void btnHoras_Click(object sender, EventArgs e)
        {
            AsignacionHorasExtra b = new AsignacionHorasExtra();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnFaltas_Click(object sender, EventArgs e)
        {
            ControlFaltas b = new ControlFaltas();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnPercepciones_Click(object sender, EventArgs e)
        {

        }

        private void btnDeducciones_Click(object sender, EventArgs e)
        {

        }

        private void btnRplanilla_Click(object sender, EventArgs e)
        {

        }

        private void btnBajas_Click(object sender, EventArgs e)
        {
            ControlBajas b = new ControlBajas();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }
    }
}
