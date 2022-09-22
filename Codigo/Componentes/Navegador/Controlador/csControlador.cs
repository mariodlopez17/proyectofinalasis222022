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

        private int opcionboton;

        public int Opcionboton
        {
            get { return this.opcionboton; }
            set { this.opcionboton = value; }
        }
       
        public void llenartablaa(string ntabla, DataGridView tabla)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenartabla(ntabla);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
           catch(Exception e)
            {
                MessageBox.Show("Error:" +e);
            }
            


        }

        public int buscarposicion(DataGridView tabla)
        {
            int posicionamiento = 0;
            try
            {
                posicionamiento = tabla.CurrentRow.Index;
            }

            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }
            return posicionamiento;
        }
        public void llenartablaa(string ntabla, DataGridView tabla, int posicion, TextBox[] textbox)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenartabla(ntabla);
                DataTable table = new DataTable();
                dt.Fill(table);


                for (int x = 0; x < table.Columns.Count; x++)
                {
                    textbox[x].Text = table.Rows[posicion][x].ToString();


                }
            }
            
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }


        }

        public void limpiar(Control control)// limpia Componentes
        {
            try
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
            

            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }
        }

        public void activar(Control control)// Activa componentes
        {
            try
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
            

            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }
        }


        public void desactivar(Control control)//Desactiva componentes
        {
            try
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
            
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }
        }

        public void enfocar(TextBox[] textbox)//desabilita el primer textbox y enfoca el segundo
        {
            try
            {
                textbox[0].Enabled = false;
                textbox[1].Focus();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }
            
        }

        public void enfocarEliminar(TextBox[] textbox) //disabled todos los textbox y enfoca el primer textbox
        {
            try
            {
                textbox[0].Focus();
                textbox[1].Enabled = false;
                textbox[2].Enabled = false;
                textbox[3].Enabled = false;
                textbox[4].Enabled = false;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }
           
        }

        public void llenartxt(TextBox[] textbox, DataGridView tabla)//Llena los textbox con datos del datagriedview

        {
            try
            {
                for (int x = 0; x < tabla.ColumnCount; x++)
                {
                    textbox[x].Text = tabla.CurrentRow.Cells[x].Value.ToString();
                    MessageBox.Show(textbox[x].Text + "    " + tabla.CurrentRow.Cells[x].Value.ToString());

                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }
            

        }

        


         public void moverseIF(DataGridView tabla, string mover)//Metodo para moverse al inicio, final, siguiente, anterior
        {
            try
            {
                int fin = (tabla.Rows.Count - 2); ;
                int posicion;

                if (mover.Equals("i"))
                {
                    posicion = 0;
                    tabla.CurrentCell = tabla.Rows[posicion].Cells[tabla.CurrentCell.ColumnIndex];

                }
                else if (mover.Equals("f"))
                {
                    posicion = fin;
                    tabla.CurrentCell = tabla.Rows[posicion].Cells[tabla.CurrentCell.ColumnIndex];

                }
                else if (mover.Equals("b"))
                {
                    mov = tabla.CurrentRow.Index - 1;
                    if (mov >= 0)
                    {
                        tabla.CurrentCell = tabla.Rows[mov].Cells[tabla.CurrentCell.ColumnIndex];

                    }


                }
                else if (mover.Equals("s"))
                {
                    next = tabla.CurrentRow.Index + 1;
                    if (next < tabla.Rows.Count - 1)
                    {
                        tabla.CurrentCell = tabla.Rows[next].Cells[tabla.CurrentCell.ColumnIndex];

                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            


        }

      
        public void delete(TextBox[] textbox, DataGridView tabla)
        {
            try
            {
                string campo = textbox[0].Tag.ToString();
                int clave = int.Parse(textbox[0].Text);

                sn.eliminar(clave, campo, tabla.Tag.ToString());
                MessageBox.Show("Dato Eliminado");
                for (int x = 0; x < textbox.Length; x++)
                {
                    textbox[x].Enabled = false;


                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }

            
               
        }
        public void ingresar(TextBox[] textbox, DataGridView tabla)//Crea cadenas de datos para la insercion
        {
            try
            {
                string autorizazcion = evaluarcampos(textbox);


                if (autorizazcion == "si")
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
                    MessageBox.Show("Dato Insertado");
                    for (int x = 0; x < textbox.Length; x++)
                    {
                        textbox[x].Enabled = false;
                    }

                }
                else if (autorizazcion == "no")
                {

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            
           
            


        }


        public void crearid(TextBox[] textbox, DataGridView tabla)//Crea el id siguiente a ingresar
        {
            try
            {
                int incremento = 0;
                textbox[0].Enabled = false;
                textbox[1].Focus();
                string resultado = sn.buscarid(tabla.Tag.ToString(), textbox[0].Tag.ToString());
                incremento = Convert.ToInt32(resultado) + 1;
                textbox[0].Text = incremento.ToString();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            

            
        }

        public void actualizar(TextBox[] textbox, DataGridView tabla)//Crea cadenas de datos para la actualizacion
        {
            try
            {
                string autorizazcion = evaluarcampos(textbox);
                bool comporbar = comprobaractualizacion(tabla, textbox);

                if (autorizazcion == "no" && comporbar == false)
                {



                }
                else if (autorizazcion == "si" && comporbar == true)
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
                    for (int x = 0; x < textbox.Length; x++)
                    {
                        textbox[x].Enabled = false;
                    }


                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            


        }

        public void bloquearbotones(IconButton[] boton, bool bloqueo)//bloquea botones
        {
            try
            {
                if (bloqueo == true)//activa el boton guardar y cancelar
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
                else if (bloqueo == false)//bloque el boton guardar y cancelar
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
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            
        }
        
        string evaluarcampos(TextBox[] textbox)//metodo para evaluar campos vacios
        {
            string autorizacion = " ";
            try
            {
                for (int x = 0; x < textbox.Length; x++)
                {
                    if (textbox[x].Text.Length == 0)
                    {
                        MessageBox.Show("Por favor llenar el campo: " + textbox[x].Tag.ToString());
                        autorizacion = "no";
                        break;

                    }
                    else if (textbox[x].Text.Length != 0)
                    {
                        autorizacion = "si";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
           
            

            return autorizacion;
        }

       public void evaluartags(TextBox[] textbox, DataGridView tabla, string BD, Form formulario)//Metodo para evaluar los tags
        {

            try
            {
                OdbcDataAdapter dt = sn.buscarnombretabla(tabla.Tag.ToString(), textbox.Length, BD);
                DataTable table = new DataTable();
                dt.Fill(table);



                for (int x = 0; x < textbox.Length; x++)
                {
                    if (textbox[x].Tag.ToString() != table.Rows[x][0].ToString())
                    {


                        MessageBox.Show("Por favor Verificar el nombre de la columna: " + textbox[x].Tag.ToString() + ", Debe de ser: " + table.Rows[x][0].ToString());
                        formulario.Close();
                        break;
                        

                    }
                    else
                    {

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }

            


        }
        
            bool comprobaractualizacion (DataGridView tabla, TextBox[] textbox)
        {
            bool permiso = false;
            try
            {
                
                int conteo = 0;
                string[] datos = new string[textbox.Length];
                datos = sn.comprobaciondellenado(tabla.Tag.ToString(), textbox[0].Tag.ToString(), textbox[0].Text, textbox.Length);

                for (int x = 0; x < textbox.Length; x++)
                {
                    if (datos[x].Equals(textbox[x].Text))
                    {
                        conteo += 1;
                    }
                }

                if (conteo.Equals(textbox.Length))
                {
                    permiso = false;
                    MessageBox.Show("No ha realizado ninguna modificación");

                }
                else
                {
                    permiso = true;

                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            

            return permiso;
        }



    }
}
