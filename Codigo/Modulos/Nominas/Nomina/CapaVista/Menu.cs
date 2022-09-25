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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            paninvent1.Visible = false;
            paninvent2.Visible = false;
            paninvent3.Visible = false;
            paninvent4.Visible = false;
            paninvent5.Visible = false;
        }

        private void hideSubMenu()
        {
            if (paninvent1.Visible == true)
                paninvent1.Visible = false;
            if (paninvent2.Visible == true)
                paninvent2.Visible = false;
            if (paninvent3.Visible == true)
                paninvent3.Visible = false;
            if (paninvent4.Visible == true)
                paninvent4.Visible = false;
            if (paninvent5.Visible == true)
                paninvent5.Visible = false;
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

        private void btnMenu1_Click(object sender, EventArgs e)
        {
            showSubMenu(paninvent1);
        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            showSubMenu(paninvent2);
        }

        private void btnMenu3_Click(object sender, EventArgs e)
        {
            showSubMenu(paninvent3);
        }

        private void btnMenu4_Click(object sender, EventArgs e)
        {
            showSubMenu(paninvent4);
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            Contrato b = new Contrato();
            b.Show();
            hideSubMenu();
        }

        private void paninvent4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnmovinvent_Click(object sender, EventArgs e)
        {
            tipoContrato b = new tipoContrato();
            b.Show();
            hideSubMenu();
        }

        private void btnCierre_Click(object sender, EventArgs e)
        {
            PuestosTrabajos b = new PuestosTrabajos();
            b.Show();
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BajasEmpleados b = new BajasEmpleados();
            b.Show();
            hideSubMenu();
        }

        private void btnMenu5_Click(object sender, EventArgs e)
        {
            showSubMenu(paninvent5);
        }


        private void btnPlanilla_Click(object sender, EventArgs e)
        {
            Planilla b = new Planilla();
            b.Show();
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnBajaE_Click(object sender, EventArgs e)
        {
            PuestosTrabajos b = new PuestosTrabajos();
            b.MdiParent = this;
            b.Show();
            pictureBox2.Visible = false;
            hideSubMenu();
            Size = new Size(762, 367);
        }

        private void btnGestionarC_Click(object sender, EventArgs e)
        {
            Contrato b = new Contrato();
            b.MdiParent = this;
            b.Show();
            pictureBox2.Visible = false;
            hideSubMenu();
            Size = new Size(875, 575);
        }

        private void btnTipoC_Click(object sender, EventArgs e)
        {
            tipoContrato b = new tipoContrato();
            b.MdiParent = this;
            b.Show();
            pictureBox2.Visible = false;
            hideSubMenu();
            Size = new Size(735, 395);
        }

        private void btnBajaE_Click_1(object sender, EventArgs e)
        {

            BajasEmpleados b = new BajasEmpleados();
            b.MdiParent = this;
            b.Show();
            pictureBox2.Visible = false;
            hideSubMenu();
            Size = new Size(765, 400);
        }
    }
}
