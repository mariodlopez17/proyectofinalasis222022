using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_ModeloConsultas;
using System.Data.Odbc;
using System.Data;

namespace Capa_ControladorConsultas 
{
    public class clscontrolador
    {
        Sentencias sn = new Sentencias();
        //rellena tabla controlador

        //datagread
        public DataTable llenartb2()
        {
            string consulta = "select * from tbl_consultainteligente";
            OdbcDataAdapter dt = sn.llenartb2(consulta);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable llenartb3(string condicion)
        {
            string consulta = "select * from tbl_consultainteligente where nombre= " + '"' + condicion + '"';
            OdbcDataAdapter dt = sn.llenartb2(consulta);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public void ejecutarconsulta(string condicion)
        {
            string sql = "DELETE FROM tbl_consultainteligente where nombre = " + '"' + condicion + '"' + ";";
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }

        public void editarconsulta(string nombre, string campos)
        {
            string sql = "update tbl_consultainteligente set campos ='" + campos + "'" + "where nombre = '" + nombre + "' ;";
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }
        //jonathan Xuya 
        OdbcConnection con = new OdbcConnection("FIL=MS Acces;DSN=Colchoneria");
        public bool InsertBusqueda(string _nomb, string _cons, string _area, string _camp, string _IDE)
        {
            using (con)
            {
                OdbcCommand cmd = new OdbcCommand();
                con.Open();
                cmd.Connection = con;

                #region Query
                String query = @"INSERT INTO tbl_consultainteligente(nombre_consulta,tabla_consulta,campos_consultas,alias_consultas, PkId) VALUE(?,?,?,?,?);";
                #endregion
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                cmd.Parameters.Add("@nombre_consulta", OdbcType.VarChar).Value = _nomb;
                cmd.Parameters.Add("@tabla_consulta", OdbcType.VarChar).Value = _cons;
                cmd.Parameters.Add("@campos_consultas", OdbcType.VarChar).Value = _area;
                cmd.Parameters.Add("@alias_consultas", OdbcType.VarChar).Value = _camp;
                cmd.Parameters.Add("@PkId", OdbcType.Int).Value = _IDE;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            return true;
        }
        public bool InsertBusquedaCompleja(string _ope, string _camp, string _valo, string _IDE)
        {

            using (con)
            {
                OdbcCommand cmda = new OdbcCommand();
                con.Open();
                cmda.Connection = con;

                #region Query


                String query = @"INSERT INTO tbl_consultainteligente1 (operador_consulta,campos_consulta,valor_consultas,PkId) VALUE(?,?,?,?);";

                #endregion
                cmda.CommandType = CommandType.Text;
                cmda.CommandText = query;
                cmda.Parameters.Add("@operador_consulta", OdbcType.VarChar).Value = _ope;
                cmda.Parameters.Add("@campos_consulta", OdbcType.VarChar).Value = _camp;
                cmda.Parameters.Add("@valor_consultas", OdbcType.VarChar).Value = _valo;
                cmda.Parameters.Add("@PkId", OdbcType.Int).Value = _IDE;


                cmda.ExecuteNonQuery();
                con.Close();
            }
            return true;
        }
        public bool InsertBusquedaCompleja1(string _ope, string _camp, string _IDE)
        {
            using (con)
            {
                OdbcCommand cmd = new OdbcCommand();
                con.Open();
                cmd.Connection = con;

                #region Query
                String query = @"INSERT INTO tbl_consultainteligente2 (PkId,ordenar_consulta, campo_consulta) VALUE(?,?,?);";
                #endregion
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.Add("@PkId", OdbcType.VarChar).Value = _ope;
                cmd.Parameters.Add("@ordenar_consulta", OdbcType.VarChar).Value = _camp;
                cmd.Parameters.Add("@campo_consulta", OdbcType.Int).Value = _IDE;


                cmd.ExecuteNonQuery();
                con.Close();
            }
            return true;
        }
    }
}

