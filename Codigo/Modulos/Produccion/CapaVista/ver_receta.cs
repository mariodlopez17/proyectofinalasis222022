﻿using System;
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
    public partial class ver_receta : Form
    {
        public ver_receta()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "5000";
            TextBox[] Grupotextbox = { textBoxidreceta, textBoxproducto, textBoxmaterial, textBoxcantidad, textBoxmedida};
            TextBox[] Idtextbox = { textBoxidreceta, textBoxproducto };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "tbl_recetas");
        }
    }
}
