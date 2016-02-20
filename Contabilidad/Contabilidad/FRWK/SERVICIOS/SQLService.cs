using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Contabilidad.FRWK.SERVICES
{
    public class SQLService : FRWK.INTERFACES.ISQLService
    {
        public static string _strConn = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString + "";

        private System.Data.SqlClient.SqlConnection _conn = null;

        public SQLService() {}

        public System.Data.SqlClient.SqlConnection getService()
        {
            _conn = new System.Data.SqlClient.SqlConnection(_strConn);
            _conn.Open();

            return _conn;
        }

        public void closeService(System.Data.SqlClient.SqlConnection _conn)
        {
            if (_conn != null && _conn.State != System.Data.ConnectionState.Closed)
            {
                _conn.Dispose();
                _conn.Close();
            }
        }




        //public SQLService()
        //{
        //    if (_conn == null)               
        //        _conn = openConnection();
        //}

        //public System.Data.SqlClient.SqlConnection openConnection()
        //{
        //    _conn = new System.Data.SqlClient.SqlConnection(_strConn);
        //    _conn.Open();

        //    return _conn;
        //}
    }
}
