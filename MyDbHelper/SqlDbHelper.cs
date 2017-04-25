using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Collections;

namespace MyDbHelper
{
    //Sql Server数据库访问类，封装访问数据库的一系列方法
    public  class SqlDbHelper:IDisposable
    {
        private static string _connStr = "";

        //这个地方不应该使用静态字段，多线程访问单个连接时会出现错误
        private SqlConnection _conn;

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        static public void GetConnStr()
        {
            var encrypt = Convert.ToBoolean(ConfigurationManager.AppSettings["ConnEncrypt"]);
            _connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.Trim();
            if (encrypt)
                _connStr = Encrypt.DecryptDES(_connStr);
        }

        //得到当前连接对象
        static public SqlConnection GetConn()
        {
            if (_connStr == "")
                GetConnStr();
            var conn = new SqlConnection(_connStr);
            return conn;            
        }

        public void OpenConnection()
        {
            _conn = GetConn();
            _conn.Open();
        }

        public void CloseConnection()
        {
            if(_conn.State!=ConnectionState.Closed)
            {
                _conn.Close();
            }
        }

        //-----------------执行命令------------------
        public bool ExecuteNonQuery(string strCmd)
        {
            var cmd = new SqlCommand(strCmd);
            try
            {
                OpenConnection();
                cmd.Connection = _conn;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        //-----------返回一个值----------------
        public object ExecuteScalar(string strCmd)
        {
            var cmd = new SqlCommand(strCmd);
            try
            {
                OpenConnection();
                cmd.Connection = _conn;
                return cmd.ExecuteNonQuery();
            }
            catch(Exception)
            {
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }

        //--------------返回DataReader---------------
        public SqlDataReader ExecuteReader(string strCmd)
        {
            var cmd = new SqlCommand(strCmd);
            try
            {
                OpenConnection();
                cmd.Connection = _conn;
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);

            }
            catch(Exception)
            {
                CloseConnection();
                return null;
            }
        }

    }
}
