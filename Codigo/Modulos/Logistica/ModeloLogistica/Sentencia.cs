using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloLogistica
{
    public class Sentencia
    {
        Conexion con = new Conexion();

        public OdbcDataAdapter llenartabla(string tabla)
        {
            Conexion con = new Conexion();

            string sql = "select * from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());

            return datatable;
        }


        public OdbcDataAdapter llenarListaPuesto(string tabla)
        {
            string sql = "select  pk_codigo_bodega as ID, nombre_bodega AS Bodega, estado_bodega as Estado from tbl_bodega where estado_bodega != 0;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }


        public void insertar(string dato, string tipo, string tabla)
        {
            string sql = "insert into " + tabla + "(" + tipo + ") values (" + dato + ")";
            try
            {

                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener");
            }
        }

        public OdbcDataAdapter llenarListaAsignaciones(string tabla, string id)
        {
            string sql = "Select *from " + tabla + " where ID = " + id + " ;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

    }
}
