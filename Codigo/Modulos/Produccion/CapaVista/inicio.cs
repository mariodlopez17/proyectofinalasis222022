using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaProduccion
{
    public partial class inicio : Form
    {
        public int prueba = 0;
        public inicio()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panel2.Visible == true)
                panel2.Visible = false;
            if (panel3.Visible == true)
                panel3.Visible = false;
            if (panel4.Visible == true)
                panel4.Visible = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            showSubMenu(panel3);
            prueba = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            showSubMenu(panel2);
            prueba = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showSubMenu(panel4);
            prueba = 3;


        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            


            bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Recetas")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                Recetas rep = new Recetas();
                rep.MdiParent = this;
                rep.Show();
            }
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            


            bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Recetas")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                ver_receta rep = new ver_receta();
                rep.MdiParent = this;
                rep.Show();
            }
            hideSubMenu();

        }

        private void button9_Click(object sender, EventArgs e)
        {
        }
    }
}
