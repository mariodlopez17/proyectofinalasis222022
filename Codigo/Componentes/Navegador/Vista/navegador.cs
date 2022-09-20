using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Controlador;

namespace Vista
{
    public partial class navegador : Form
    {
        csControlador cn = new csControlador();
        public navegador()
        {
            InitializeComponent();
        }
        int opcion=0;
        //si opcion es true será insercion
        //si opcion es false será actualizacion
        private void btnInsert_Click(object sender, EventArgs e)
        {
            opcion = 1;
            IconButton[] boton = { btnSave, btnCancelar, btnInsert, btnModificar, btnDelete, btnUpdate, btnConsultar, btnReporte,
                                   btnNext, btnBack, btnStart, btnEnd, btnExit, btnHelp };
            cn.bloquearbotones(boton, true);
            cn.limpiar(this);
            cn.activar(this);
            TextBox[] textbox = { textBox1, textBox2 };
            cn.crearid(textbox, dgv_tabla);
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            opcion = 2;
            IconButton[] boton = { btnSave, btnCancelar, btnInsert, btnModificar, btnDelete, btnUpdate, btnConsultar, btnReporte,
                                   btnNext, btnBack, btnStart, btnEnd, btnExit, btnHelp };
            cn.bloquearbotones(boton, true);
            TextBox[] textbox = { textBox1, textBox2 };
            cn.activar(this);
            cn.enfocar(textbox);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            opcion = 3;
            IconButton[] boton = { btnSave, btnCancelar, btnInsert, btnModificar, btnDelete, btnUpdate, btnConsultar, btnReporte,
                                   btnNext, btnBack, btnStart, btnEnd, btnExit, btnHelp };
            cn.bloquearbotones(boton, true);
            cn.activar(this);
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            cn.enfocarEliminar(textbox);
            MessageBox.Show("Esta Seguro de eliminar el registro, si es así seleccione Guardar.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            cn.moverseIF(textbox, dgv_tabla, "i");
            cn.llenartablaa(dgv_tabla.Tag.ToString(), dgv_tabla);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IconButton[] boton = { btnSave, btnCancelar, btnInsert, btnModificar, btnDelete, btnUpdate, btnConsultar, btnReporte,
                                   btnNext, btnBack, btnStart, btnEnd, btnExit, btnHelp };

            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            if (opcion == 1)//Insercion
            {
                cn.ingresar(textbox, dgv_tabla, boton);
                

            }
            else if (opcion == 2)//actualizacion
            {
                cn.actualizar(textbox, dgv_tabla,boton);
               
               
                
            }
            else if (opcion == 3)//eliminar
            {
                cn.delete(textbox, dgv_tabla, boton);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IconButton[] boton = { btnSave, btnCancelar, btnInsert, btnModificar, btnDelete, btnUpdate, btnConsultar, btnReporte,
                                   btnNext, btnBack, btnStart, btnEnd, btnExit, btnHelp };
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            cn.bloquearbotones(boton, false);
            cn.limpiar(this);
            cn.desactivar(this);
            cn.llenartxt(textbox, dgv_tabla);

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            cn.moverseIF(textbox,dgv_tabla,"i");
            cn.desactivar(this);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            cn.moverseIF(textbox, dgv_tabla, "f");
            cn.desactivar(this);
        }

        private void bnNext_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            cn.moverseIF(textbox, dgv_tabla, "b");
            cn.desactivar(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            cn.moverseIF(textbox, dgv_tabla, "s");
            cn.desactivar(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //Menú de Ayuda hecho por Ester López
            menuAyuda frm = new menuAyuda();
            frm.Show();
        }

        private void navegador_Load(object sender, EventArgs e)
        {
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            cn.llenartablaa(dgv_tabla.Tag.ToString(), dgv_tabla);
            cn.desactivar(this);
            cn.llenartxt(textbox, dgv_tabla);
            IconButton[] boton = { btnSave, btnCancelar, btnInsert, btnModificar, btnDelete, btnUpdate, btnConsultar, btnReporte,
                                   btnNext, btnBack, btnStart, btnEnd, btnExit, btnHelp };
            cn.bloquearbotones(boton,false);
            
        }
    }
}
