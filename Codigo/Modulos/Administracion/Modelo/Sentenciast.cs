using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace ComprasModelo
{
    public class Sentenciast
    {
        Conexion con = new Conexion();

        public OdbcDataAdapter llenartabla(string tabla)
        {


            string sql = "select * from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());



            return datatable;
        }

        public OdbcDataAdapter llenarcomboproducto(string nombre)
        {


            string sql = "select medidas from tbl_Producto where descripcion = '" + nombre + "';";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());



            return datatable;
        }

        public string[] camposcombo(string dato, string dato2)
        {

            string[] datos = new string[3];
            string sql = "select c.descripcion, c.precio_venta, a.nombre_linea from tbl_Producto as c inner join tbl_linea as a  on c.fk_linea_inventario = a.pk_codigo_linea  where  c.medidas = '" + dato + "' and c.descripcion = '" + dato2 + "'";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {

                datos[0] = lr.GetString(0);
                datos[1] = lr.GetString(1);
                datos[2] = lr.GetString(2);

            }



            return datos;
        }

        public OdbcDataAdapter filtro(string tabla, string tipodato, string dato)
        {


            string sql = "select * from " + tabla + " where " + tipodato + " like ('" + dato + "%');";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());



            return datatable;
        }
        public string buscardescripcion(string dato)
        {

            string datos = "";
            string sql = "select descripcion from tbl_producto where pk_codigo_producto = '" + dato + "'";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {
                datos = lr.GetString(0);
            }

            return datos;
        }

        public string buscaridproducto(string medicion, string descripcion)
        {

            string datos = "";
            string sql = "select pk_codigo_producto from tbl_producto where medidas = '" + medicion + "' and descripcion = '" + descripcion + "'";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {
                datos = lr.GetString(0);
            }

            return datos;
        }

        public OdbcDataAdapter tablavendedor(string dato)
        {

            string sql = "select * from tblEmpleados where FKId_Tipoempleado = '" + dato + "'";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());

            return datatable;
        }

        public string verificarexistencia(string codigo)
        {

            string datos = "";
            string sql = "select existencia from tbl_Producto where pk_codigo_producto = '" + codigo + "'";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {
                datos = lr.GetString(0);
            }

            return datos;
        }

        public int estadotabla(string tabla)
        {
            int dato = 0;
            string sql = "select count(*) as total from " + tabla;
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {

                dato = lr.GetInt32(0);


            }
            return dato;
        }

        public string buscarid(string tabla, string tipo)
        {
            string dato = " ";
            try
            {

                string sql = "select " + tipo + " from " + tabla + " Order by " + tipo + " Desc Limit 1";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader lr = cmd.ExecuteReader();
                while (lr.Read())
                {
                    dato = lr.GetString(0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }


            return dato;
        }
        public void insertar(string dato, string tipo, string tabla)
        {
            try
            {
                string sql = "insert into " + tabla + "(" + tipo + ") values (" + dato + ")";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }


        }

        public OdbcDataAdapter formadortablareserva(string dato)
        {

            string sql = "select pe.PkId_EncabezadoPedido, dpe.FkId_Producto, dpe.CantidadDetalle_DetallePedido, dpe.TotalDetalle_DetallePedido, pro.existencia from tbldetallepedido as dpe inner join tblencabezadopedido as pe on dpe.PkId_EncabezadoPedido = pe.PkId_EncabezadoPedido inner join tbl_producto as pro on dpe.FkId_Producto = pro.pk_codigo_producto where dpe.PkId_EncabezadoPedido = '" + dato + "'";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());

            return datatable;
        }

        public string verificarexistenciaasociacion(string empleado, string cliente)
        {

            string datos = "";
            string sql = "select PkId_Asociacion from tblasociacion where FkId_Empleados = '" + empleado + "' and FkId_Clientes = '" + cliente + "'";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {
                datos = lr.GetString(0);
            }

            return datos;
        }

        public void actualizarexistenciaproducto(string dato, string existencia)
        {
            try
            {
                string sql = "update tbl_producto set existencia = '" + existencia + "' where pk_codigo_producto = '" + dato + "'";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }


        }

    }

}
