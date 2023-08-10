using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCafe.DAL
{
    public class Database
    {
        static string conn_string =
            @"Data Source=khaipahm\SQLEXPRESS;Initial Catalog=QUANLYCAFECNPM;Integrated Security=True";
        static SqlConnection conn;
        static SqlCommand command;

        public Database()
        {
            conn = new SqlConnection(conn_string);
        }

        public static SqlConnection CreateConnection()
        {
            try
            {
                conn = new SqlConnection(conn_string);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch (Exception err)
            {
                conn = null;
            }
            return conn;
        }

        public static SqlCommand CreateCommand(string strCommand)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command = new SqlCommand(strCommand, conn);
                return command;
            }
            catch (Exception err)
            {
                command = null;
                conn.Close();
                throw new Exception("Execute query erorr: " + err.Message);
            }
    
        }

        public static DataTable SelectQuery(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command = CreateCommand(sql);
                SqlDataAdapter adt = new SqlDataAdapter(command);
                adt.Fill(dt);
                command.Dispose();
                adt.Dispose();
                return dt;
            }
            catch (Exception err)
            {
                throw new Exception("Execute query erorr: " + err.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
