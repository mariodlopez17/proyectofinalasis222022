using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Odbc;
using FontAwesome.Sharp;
using Modelo;

namespace Controlador
{
 
    public class csControlador
    {
        Sentencias sn = new Sentencias();

        int next, mov;

        public void llenartablaa(string ntabla, DataGridView tabla)//Funcion para llenar tabla
        {
            OdbcDataAdapter dt = sn.llenartabla(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
            


        }

        public void limpiar(Control control)// limpia Componentes
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedItem = 0;
                }
                else if (txt is CheckBox)
                {
                    ((CheckBox)txt).Checked = false;
                }
            }
        }

        public void activar(Control control)// Activa componentes
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Enabled = true;
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).Enabled = true;
                }
                else if (txt is CheckBox)
                {
                    ((CheckBox)txt).Enabled = true;
                }
            }
        }


        public void desactivar(Control control)//Desactiva componentes
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Enabled = false;
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).Enabled = false;
                }
                else if (txt is CheckBox)
                {
                    ((CheckBox)txt).Enabled = false;
                }
            }
        }

        public void enfocar(TextBox[] textbox)//desabilita el primer textbox y enfoca el segundo
        {
            textbox[0].Enabled = false;
            textbox[1].Focus();
        }

        public void enfocarEliminar(TextBox[] textbox) //disabled todos los textbox y enfoca el primer textbox
        {
            textbox[0].Focus();
            textbox[1].Enabled = false;
            textbox[2].Enabled = false;
            textbox[3].Enabled = false;
            textbox[4].Enabled = false;
        }

        public void llenartxt(TextBox[] textbox, DataGridView tabla)//Llena los textbox con datos del datagriedview

        {
            
            for (int x = 0; x < tabla.ColumnCount; x++)
            {
                textbox[x].Text = tabla.CurrentRow.Cells[x].Value.ToString();
                
            }

        }

        public void moverseIF(TextBox[] textbox, DataGridView tabla, string mover)//Metodo para moverse al inicio y final
        {
            int fin = (tabla.Rows.Count - 2); ;
            int posicion;

            if (mover.Equals("i"))
            {
                posicion = 0;
                cursor(tabla, posicion);
                tabla.CurrentCell.Selected = true;
                for (int x = 0; x < tabla.ColumnCount; x++)
                {
                    textbox[x].Text = tabla.Rows[posicion].Cells[x].Value.ToString();
                    
                }
            }
            else if(mover.Equals("f"))
            {
                posicion = fin;
                cursor(tabla, posicion);
                for (int x = 0; x < tabla.ColumnCount; x++)
                {
                     
                    textbox[x].Text = tabla.Rows[posicion].Cells[x].Value.ToString();
                    
                }
            }
            else if (mover.Equals("b"))
            {
                mov = tabla.CurrentRow.Index - 1;
                if (mov >= 0)
                {
                    tabla.CurrentCell = tabla.Rows[mov].Cells[tabla.CurrentCell.ColumnIndex];
                    for (int x = 0; x < tabla.ColumnCount; x++)
                    {

                        textbox[x].Text = tabla.Rows[mov].Cells[x].Value.ToString();

                    }
                }



            }
            else if (mover.Equals("s"))
            {
                next = tabla.CurrentRow.Index + 1;
                if (next < tabla.Rows.Count)
                {
                    tabla.CurrentCell = tabla.Rows[next].Cells[tabla.CurrentCell.ColumnIndex];
                    for (int x = 0; x < tabla.ColumnCount; x++)
                    {

                        textbox[x].Text = tabla.Rows[next].Cells[x].Value.ToString();

                    }
                }
            }


        }

         void cursor(DataGridView tabla, int puntero)//ubica el cursor y marca la fila en el datagriedview
        {
            tabla.CurrentCell = tabla.Rows[puntero].Cells[0];
            tabla.CurrentRow.Selected = true;

        }

        public void delete(TextBox[] textbox, DataGridView tabla, IconButton[] boton)
        {
            string autorizazcion = evaluarcampos(textbox);


            if (autorizazcion == "no")
            {
                boton[0].Enabled = true;
                boton[1].Enabled = true;
                boton[2].Enabled = false;
                boton[3].Enabled = false;
                boton[4].Enabled = false;
                boton[5].Enabled = false;
                boton[6].Enabled = false;
                boton[7].Enabled = false;
                boton[8].Enabled = false;
                boton[9].Enabled = false;
                boton[10].Enabled = false;
                boton[11].Enabled = false;
                boton[12].Enabled = false;
                boton[13].Enabled = false;


            }
            else if (autorizazcion == "si")
            {
                string campo = textbox[0].Tag.ToString();
                int clave = int.Parse(textbox[0].Text);

                sn.eliminar( clave, campo, tabla.Tag.ToString());
                MessageBox.Show("Dato Eliminado");
                for (int x = 0; x < textbox.Length; x++)
                {
                    textbox[x].Enabled = false;


                }
                boton[0].Enabled = false;
                boton[1].Enabled = false;
                boton[2].Enabled = true;
                boton[3].Enabled = true;
                boton[4].Enabled = true;
                boton[5].Enabled = true;
                boton[6].Enabled = true;
                boton[7].Enabled = true;
                boton[8].Enabled = true;
                boton[9].Enabled = true;
                boton[10].Enabled = true;
                boton[11].Enabled = true;
                boton[12].Enabled = true;
                boton[13].Enabled = true;
            }


        }
        public void ingresar(TextBox[] textbox, DataGridView tabla, IconButton[] boton)//Crea cadenas de datos para la insercion
        {
            string autorizazcion = evaluarcampos(textbox);

            if(autorizazcion == "si")
            {


                string dato = " ";
                string tipo = " ";
                for (int x = 0; x < textbox.Length; x++)
                {

                    if (x == textbox.Length - 1)
                    {
                        dato += "'" + textbox[x].Text + "'";
                        tipo += textbox[x].Tag.ToString();
                    }
                    else
                    {
                        dato += "'" + textbox[x].Text + "',";
                        tipo += textbox[x].Tag.ToString() + ",";
                    }

                }

                sn.insertar(dato, tipo, tabla.Tag.ToString());
                //MessageBox.Show("Dato Insertado");
                for (int x = 0; x < textbox.Length; x++)
                {
                    textbox[x].Enabled = false;
                }
                boton[0].Enabled = false;
                boton[1].Enabled = false;
                boton[2].Enabled = true;
                boton[3].Enabled = true;
                boton[4].Enabled = true;
                boton[5].Enabled = true;
                boton[6].Enabled = true;
                boton[7].Enabled = true;
                boton[8].Enabled = true;
                boton[9].Enabled = true;
                boton[10].Enabled = true;
                boton[11].Enabled = true;
                boton[12].Enabled = true;
                boton[13].Enabled = true;
            }
            else if (autorizazcion == "no")
            {
                boton[0].Enabled = true;
                boton[1].Enabled = true;
                boton[2].Enabled = false;
                boton[3].Enabled = false;
                boton[4].Enabled = false;
                boton[5].Enabled = false;
                boton[6].Enabled = false;
                boton[7].Enabled = false;
                boton[8].Enabled = false;
                boton[9].Enabled = false;
                boton[10].Enabled = false;
                boton[11].Enabled = false;
                boton[12].Enabled = false;
                boton[13].Enabled = false;
            }
           
            


        }


        public void crearid(TextBox[] textbox, DataGridView tabla)//Crea el id siguiente a ingresar
        {
            
            int incremento = 0;
            textbox[0].Enabled = false;
            textbox[1].Focus();
            string resultado = sn.buscarid(tabla.Tag.ToString(), textbox[0].Tag.ToString());
            incremento = Convert.ToInt32(resultado) + 1;
            textbox[0].Text = incremento.ToString();

            
        }

        public void actualizar(TextBox[] textbox, DataGridView tabla, IconButton[] boton)//Crea cadenas de datos para la actualizacion
        {

            string autorizazcion = evaluarcampos(textbox);

            if (autorizazcion == "no")
            {
                boton[0].Enabled = true;
                boton[1].Enabled = true;
                boton[2].Enabled = false;
                boton[3].Enabled = false;
                boton[4].Enabled = false;
                boton[5].Enabled = false;
                boton[6].Enabled = false;
                boton[7].Enabled = false;
                boton[8].Enabled = false;
                boton[9].Enabled = false;
                boton[10].Enabled = false;
                boton[11].Enabled = false;
                boton[12].Enabled = false;
                boton[13].Enabled = false;


            }
            else if(autorizazcion == "si")
            {
               string dato = " ";
                string condicion = "(" + textbox[0].Tag.ToString() + " = '" + textbox[0].Text + "')";

                for (int x = 1; x < textbox.Length; x++)
                {

                    if (x == textbox.Length - 1)
                    {
                        dato += " " + textbox[x].Tag.ToString() + " = '" + textbox[x].Text + "' ";

                    }
                    else if (x == 1)
                    {
                        dato += "SET " + textbox[x].Tag.ToString() + " = '" + textbox[x].Text + "', ";

                    }
                    else
                    {
                        dato += " " + textbox[x].Tag.ToString() + " = '" + textbox[x].Text + "', ";

                    }

                }

                sn.actualizar(dato, condicion, tabla.Tag.ToString());
                MessageBox.Show("Dato actualizado");
                for(int x = 0; x < textbox.Length; x++)
                {
                    textbox[x].Enabled = false;
                }
                boton[0].Enabled = false;
                boton[1].Enabled = false;
                boton[2].Enabled = true;
                boton[3].Enabled = true;
                boton[4].Enabled = true;
                boton[5].Enabled = true;
                boton[6].Enabled = true;
                boton[7].Enabled = true;
                boton[8].Enabled = true;
                boton[9].Enabled = true;
                boton[10].Enabled = true;
                boton[11].Enabled = true;
                boton[12].Enabled = true;
                boton[13].Enabled = true;
            }


        }

        public void bloquearbotones(IconButton[] boton, bool bloqueo)//bloquea botones
        {
            if(bloqueo == true)//activa el boton guardar y cancelar
            {
                boton[0].Enabled = true;
                boton[1].Enabled = true;
                boton[2].Enabled = false;
                boton[3].Enabled = false;
                boton[4].Enabled = false;
                boton[5].Enabled = false;
                boton[6].Enabled = false;
                boton[7].Enabled = false;
                boton[8].Enabled = false;
                boton[9].Enabled = false;
                boton[10].Enabled = false;
                boton[11].Enabled = false;
                boton[12].Enabled = false;
                boton[13].Enabled = false;




            }
            else if(bloqueo == false)//bloque el boton guardar y cancelar
            {
                boton[0].Enabled = false;
                boton[1].Enabled = false;
                boton[2].Enabled = true;
                boton[3].Enabled = true;
                boton[4].Enabled = true;
                boton[5].Enabled = true;
                boton[6].Enabled = true;
                boton[7].Enabled = true;
                boton[8].Enabled = true;
                boton[9].Enabled = true;
                boton[10].Enabled = true;
                boton[11].Enabled = true;
                boton[12].Enabled = true;
                boton[13].Enabled = true;



            }
        }
        
        string evaluarcampos(TextBox[] textbox)
        {
            string autorizacion = " ";
            for(int x = 0; x < textbox.Length; x++)
            {
                if(textbox[x].Text.Length == 0 )
                {
                    MessageBox.Show("Por favor llenar el campo: "+textbox[x].Tag.ToString());
                    autorizacion = "no";
                    break;
                    
                }
                else if (textbox[x].Text.Length != 0)
                {
                    autorizacion = "si";
                }
            }

            return autorizacion;
        }

        

        
    }
}
