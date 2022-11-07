using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using ComprasModelo;
using System.Data;
using System.Windows.Forms;

namespace ComprasControlador
{
    
    public class csControladort
    {
        Sentenciast sn = new Sentenciast();
        private static string ids;
        public string IDS
        {
            get { return ids; }
            set { ids = value; }
        }


        static DataTable inventario = new DataTable();





        public void llenartablaa(string ntabla, DataGridView tabla)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenartabla(ntabla);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        }

        public void llenartablaa(DataGridView tabla)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.tablavendedor("1");
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        }

        public void llenarcombo(string nombre, ComboBox combo)
        {
            try
            {

                string descripcion = sn.buscardescripcion(nombre);

                OdbcDataAdapter dt = sn.llenarcomboproducto(descripcion);
                DataTable table = new DataTable();
                dt.Fill(table);

                int contador = 0;
                combo.Items.Clear();

                foreach (DataRow row in table.Rows)
                {
                    combo.Items.Add(table.Rows[contador][0].ToString());

                    contador++;
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(" " + e);
            }
        }

        public void llenardatoscombo(string medida, TextBox[] textbox, string nombre)
        {
            try
            {

                string descripcion = sn.buscardescripcion(nombre);
                string[] datos = sn.camposcombo(medida, descripcion);
                for (int x = 0; x < 3; x++)
                {
                    textbox[x].Text = datos[x];
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);

            }

        }

        public void llenarfiltro(string ntabla, DataGridView tabla, string tipo, string dato)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.filtro(ntabla, tipo, dato);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        }

        public void insertardatagrid(DataGridView tabla, string scantidad, string sprecio, string medida, string descripcion, TextBox total, string idpedido, GroupBox group)
        {

            string[] datos = new string[5];
            bool permiso = Verificarcamposvacios(group);

            if (permiso == true)
            {
                datos[1] = sn.buscaridproducto(medida, descripcion);
                string existencia = verificarexistencia(datos[1]);
                double cantidad = Convert.ToDouble(scantidad);
                double cantidadactual;

                if (existencia.Equals(0))
                {
                    cantidadactual = 0;
                }
                else
                {
                    bool verificacion = verificarvaciodatatable();

                    if (verificacion == true)//existen datos
                    {
                        var (cantidadactualtabla, acceso) = disminuircantidad(datos[1], cantidad);

                        if (acceso == true)
                        {
                            cantidadactual = cantidadactualtabla;
                        }
                        else
                        {
                            cantidadactual = Convert.ToDouble(existencia) - cantidad;
                            llenartablaconstante(datos[1], Convert.ToDouble(existencia), cantidadactual);
                        }

                    }
                    else
                    {
                        cantidadactual = Convert.ToDouble(existencia) - cantidad;
                        llenartablaconstante(datos[1], Convert.ToDouble(existencia), cantidadactual);


                    }
                }


                datos[0] = idpedido;
                datos[2] = cantidad.ToString();
                datos[3] = sprecio.ToString();
                double precio = Convert.ToDouble(sprecio);
                datos[4] = (cantidad * precio).ToString();

                if (existencia.Equals(0))
                {
                    string mensaje = "El Producto: " + descripcion + " no tiene existencia";
                    MessageBox.Show(mensaje, " Falta de Existencia  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidadactual >= 0)
                {
                    tabla.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4]);
                    double suma = 0;
                    foreach (DataGridViewRow row in tabla.Rows)
                    {
                        suma += Convert.ToDouble(row.Cells["TotalDetalle_DetallePedido"].Value);
                        total.Text = suma.ToString();
                    }

                }

                else
                {

                    string mensaje = "El Producto: " + descripcion + " no tiene existencia";
                    MessageBox.Show(mensaje, " Falta de Existencia  ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                limpiardetallepedido(group);
            }


        }

        public void eliminarfilagrid(DataGridView tabla, TextBox total, GroupBox group)
        {
            int fila = tabla.Rows.Count - 1;

            if (fila > 0 && tabla.CurrentRow.Index < fila)
            {
                aumentarcantidad(tabla);
                tabla.Rows.RemoveAt(tabla.CurrentRow.Index);

                double suma = 0;
                foreach (DataGridViewRow row in tabla.Rows)
                {
                    suma += Convert.ToDouble(row.Cells["TotalDetalle_DetallePedido"].Value);
                    total.Text = suma.ToString();
                }

            }
            limpiardetallepedido(group);

        }

        public string verificarexistencia(string codigo)
        {
            string existencia = sn.verificarexistencia(codigo);

            return existencia;
        }

        void llenartablaconstante(string idproducto, double existencia, double nuevaexistencia)
        {


            int fila = inventario.Rows.Count;
            inventario.Rows.Add();

            inventario.Rows[fila][0] = idproducto;
            inventario.Rows[fila][1] = existencia;
            inventario.Rows[fila][2] = nuevaexistencia;

        }

        bool verificarvaciodatatable()
        {
            int fila = inventario.Rows.Count;
            bool permiso = false;
            if (fila > 0)
            {
                permiso = true;
            }

            return permiso;
        }

        (double, bool) disminuircantidad(string idproducto, double cantidad)
        {
            double nuevacantidad = 0;
            bool acceso = false; //no encontro el id

            for (int x = 0; x < inventario.Rows.Count; x++)
            {
                if (inventario.Rows[x][0].Equals(idproducto))
                {

                    if (cantidad > Convert.ToDouble(inventario.Rows[x][2]))
                    {


                        nuevacantidad = -1;
                    }
                    else if (cantidad == Convert.ToDouble(inventario.Rows[x][2]))
                    {
                        inventario.Rows[x][2] = 0;
                        nuevacantidad = 0;
                    }
                    else
                    {
                        nuevacantidad = Convert.ToDouble(inventario.Rows[x][2]) - cantidad;
                        inventario.Rows[x][2] = nuevacantidad;


                    }
                    acceso = true;
                }
                else
                {
                    acceso = false;
                }

            }



            return (nuevacantidad, acceso);
        }

        public void llenarcolumnasdatatable()
        {

            inventario.Columns.Add("Idproducto");
            inventario.Columns.Add("Existenciaincial");
            inventario.Columns.Add("Existencianueva");

        }

        void aumentarcantidad(DataGridView tabla)
        {
            double nuevacantidad;

            for (int x = 0; x < inventario.Rows.Count; x++)
            {

                if (inventario.Rows[x][0].Equals(tabla.CurrentRow.Cells[1].Value.ToString()))
                {
                    nuevacantidad = Convert.ToDouble(inventario.Rows[x][2]) + Convert.ToDouble(tabla.CurrentRow.Cells[2].Value);
                    inventario.Rows[x][2] = nuevacantidad;



                }

            }

        }

        void limpiardetallepedido(GroupBox group)
        {


            foreach (Control c in group.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }

            }
        }

        bool Verificarcamposvacios(GroupBox group)
        {
            bool permiso = false;

            foreach (Control c in group.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text.Length == 0)
                    {
                        string mensaje = "Por Favor llenar Todos los campos";
                        MessageBox.Show(mensaje, " Campos Vacios  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        permiso = false;
                        break;
                    }
                    else
                    {
                        permiso = true;
                    }
                }
                if (c is ComboBox)
                {
                    if (c.Text.Length == 0)
                    {

                        string mensaje = "Por Favor llenar Todos los campos";
                        MessageBox.Show(mensaje, " Campos Vacios  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        permiso = false;
                        break;
                    }
                    else
                    {
                        permiso = true;
                    }

                }

            }
            return permiso;
        }


        DateTime fechavencimineto()
        {
            DateTime fechaactual = DateTime.Now.Date;
            DateTime fechavencimineto = fechaactual.AddDays(7);

            return fechavencimineto;
        }

        public void inicio(DateTimePicker vencimineto, TextBox id, TextBox descripcion, TextBox precio, TextBox linea, TextBox total)
        {
            descripcion.Enabled = false;
            precio.Enabled = false;
            linea.Enabled = false;
            total.Enabled = false;
            vencimineto.Value = fechavencimineto();
            vencimineto.Enabled = false;


            id.Enabled = false;

            //crearid(id, "tbl_Producto","p");
            crearid(id, "tblencabezadopedido", " ", "PkId_EncabezadoPedido");


        }

        public void crearid(TextBox textbox, string tabla, string codigo, string campo)//Crea el id siguiente a ingresar
        {

            try
            {
                int incremento = 0;

                int permiso = comprobacionvacio(tabla);
                if (permiso != 0)
                {
                    string resultado = sn.buscarid(tabla, campo);
                    incremento = Convert.ToInt32(resultado) + 1;
                    textbox.Text = incremento.ToString();
                }
                else
                {
                    incremento = 1;
                    textbox.Text = incremento.ToString();
                }



            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }

        }

        public void crearidstring(TextBox textbox, string tabla, string codigo, string campo)//Crea el id siguiente a ingresar
        {

            try
            {
                int incremento = 0;
                textbox.Enabled = false;
                int permiso = comprobacionvacio(tabla);
                if (permiso != 0)
                {
                    string resultado = sn.buscarid(tabla, campo);
                    string numero = resultado.Substring(1, 1);
                    codigo = resultado.Substring(0, 1);


                    incremento = Convert.ToInt32(numero) + 1;
                    textbox.Text = codigo + incremento.ToString();
                }
                else
                {

                    textbox.Text = codigo;
                }



            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
        }


        public string crearidstring(string textbox, string tabla, string codigo, string campo)//Crea el id siguiente a ingresar
        {

            try
            {
                int incremento = 0;

                int permiso = comprobacionvacio(tabla);
                if (permiso != 0)
                {
                    string resultado = sn.buscarid(tabla, campo);
                    resultado += "   ";
                    codigo = resultado.Substring(0, 3);
                    string numero = resultado.Substring(3, 4);



                    incremento = Convert.ToInt32(numero) + 1;
                    textbox = codigo + incremento.ToString();
                }
                else
                {

                    textbox = codigo + "1";

                }

                return textbox;


            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            return textbox;
        }
        public int comprobacionvacio(string tabla)
        {
            int resultado = 0;
            resultado = sn.estadotabla(tabla);

            return resultado;
        }

        public void insertarbddetalle(DataGridView tabla)
        {

            if (tabla.Rows.Count > 1)
            {
                string idpedidoo = tabla.Rows[0].Cells[0].Value.ToString();
                for (int x = 0; x < tabla.Rows.Count - 1; x++)
                {
                    string idpedido = tabla.Rows[x].Cells[0].Value.ToString();
                    string idproducto = tabla.Rows[x].Cells[1].Value.ToString();
                    string cantidad = tabla.Rows[x].Cells[2].Value.ToString();
                    string precio = tabla.Rows[x].Cells[3].Value.ToString();
                    string total = tabla.Rows[x].Cells[4].Value.ToString();
                    string fila = x.ToString();
                    string consultadetallepe = "'" + idpedido + "', '" + idproducto + "', '" + cantidad + "', '" + precio + "', '" + total + "', '" + fila + "'";
                    string consultadetallepe_campos = "PkId_EncabezadoPedido, FkId_Producto, CantidadDetalle_DetallePedido, CostoDetalle_DetallePedido, TotalDetalle_DetallePedido, linea";
                    sn.insertar(consultadetallepe, consultadetallepe_campos, "tbldetallepedido");
                }

                OdbcDataAdapter dt = sn.formadortablareserva(idpedidoo);
                DataTable table = new DataTable();
                dt.Fill(table);

                string[] idsproductos = new string[table.Rows.Count];
                int[] cantidadesproducto = new int[table.Rows.Count];
                int[] existenciaproducto = new int[table.Rows.Count];



                int current = 0;
                foreach (DataRow row in table.Rows)
                {
                    string idproducto = row[1].ToString();
                    int cantidad = Convert.ToInt32(row[2]);
                    int existencia = Convert.ToInt32(row[4]);

                    idsproductos[current] = idproducto;
                    cantidadesproducto[current] = cantidad;
                    existenciaproducto[current] = existencia;
                    current++;
                }

                for (int y = 0; y < idsproductos.Length; y++)
                {
                    for (int z = 0; z < idsproductos.Length; z++)
                    {
                        if (idsproductos[z].Equals(idsproductos[y]) && y < z)
                        {

                            cantidadesproducto[y] += cantidadesproducto[z];
                            idsproductos[z] = "";
                            cantidadesproducto[z] = 0;


                        }

                    }

                }

                string idreserva = sn.buscarid("tblEncabezadoReservacionPedido", "PkId_Reserva");
                for (int x = 0; x < idsproductos.Length; x++)
                {

                    if (idsproductos[x] != null && idsproductos[x] != "")
                    {
                        string consultadetallereserva = "'" + idreserva + "', '" + idsproductos[x] + "', " + cantidadesproducto[x] + ", " + existenciaproducto[x] + ", " + (existenciaproducto[x] - cantidadesproducto[x]) + ", " + x;
                        string consultadetallereserva_campos = "Pk_Reserva, Id_producto, Cantidad_Descontar, Existencia_anterior, Existencia_nueva, linea";
                        sn.insertar(consultadetallereserva, consultadetallereserva_campos, "tbldetallereservacionpedido");
                        sn.actualizarexistenciaproducto(idsproductos[x], (existenciaproducto[x] - cantidadesproducto[x]).ToString());
                    }



                }
            }

        }

        public void insertardbencabezado(TextBox[] textbox, DateTimePicker dtp, GroupBox groupBox)
        {

            bool permiso = Verificarcamposvacios(groupBox);
            if (permiso == true)
            {
                string idasociado = verificarasociacion(textbox[0].Text, textbox[1].Text);


                string consultaenpedido = textbox[2].Text + ", '" + idasociado + "', '" + dtp.Value.ToString("yyyyMMdd") + "',  '" + DateTime.Now.Date.ToString("yyyyMMdd") + "', " + textbox[3].Text + ", 0";
                string consultaenpedido_campos = "PkId_EncabezadoPedido, FkIdAsociacion, FechaVencimineto, FechaEmision, Total, EstatusOrdenCompra_EncabezadoPedido";
                sn.insertar(consultaenpedido, consultaenpedido_campos, "tblencabezadopedido");
                string mensaje = "Pedido Exitoso, tiene hasta: " + dtp.Value.ToString("dd-MM-YY") + " para realizar el pago de: Q" + textbox[3].Text;
                MessageBox.Show(mensaje, " Pedido Exitoso  ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //Reservacion de producto

                string idencabezadopedido = crearidstring("", "tblEncabezadoReservacionPedido", "Rsp", "PkId_Reserva");
                string consultaencabezadopedido = "'" + idencabezadopedido + "', '" + textbox[2].Text + "', 0";
                string consultaencabezadopedido_campos = "PkId_Reserva, FkId_pedido, estatus";
                sn.insertar(consultaencabezadopedido, consultaencabezadopedido_campos, "tblEncabezadoReservacionPedido");

                textbox[3].Clear();
            }





        }

        public string verificarasociacion(string empleado, string cliente)
        {
            string idasociado;
            string verificador = sn.verificarexistenciaasociacion(empleado, cliente);

            if (verificador == "")
            {
                idasociado = crearidstring("", "tblasociacion", "Asc", "PkId_Asociacion");
                string consulta = "'" + idasociado + "' , " + empleado + " , " + cliente;
                string consulta_campos = "PkId_Asociacion, FkId_Empleados, FkId_Clientes";

                sn.insertar(consulta, consulta_campos, "tblasociacion");
            }
            else
            {
                idasociado = verificador;
            }



            return idasociado;
        }


        public void limpiarpedido(GroupBox[] group)
        {
            limpiardetallepedido(group[0]);
            limpiardetallepedido(group[1]);
            inventario.Clear();
        }
    }




}
