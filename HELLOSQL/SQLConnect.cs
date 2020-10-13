using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELLOSQL
{
    class SQLConnect
    {
        public string LastExceptionString = string.Empty;
        public string ConnectionString = string.Empty;
        public string Address = string.Empty;
        public string Port = string.Empty;

        public static string oracle_address { get; set; }
        public static string oracle_port { get; set; }
        public static string oracle_service { get; set; }
        public static string oracle_id { get; set; }
        public static string oracle_pw { get; set; }

        public OracleConnection Connection { get; private set; }

        public bool GetConnection()
        {
            try
            {
                if (this.Connection != null)
                {
                    this.Connection.Close();
                    this.Connection.Dispose();
                    this.Connection = null;
                }

                if (ConnectionString == string.Empty)
                    SetConnectionString(oracle_id, oracle_pw, oracle_address, oracle_port, oracle_service);

                Connection = new OracleConnection(ConnectionString);
                Connection.Open();

                if (this.Address != string.Empty) //주소가 없을 경우 그냥 리턴
                    Connection.Open();
            }
            catch (Exception ex)
            {
                System.Reflection.MemberInfo info = System.Reflection.MethodInfo.GetCurrentMethod();
                string id = string.Format("{0}.{1}", info.ReflectedType.Name, info.Name);
                Console.WriteLine(id);
                Console.WriteLine(ex);
                return false;
            }

            if (Connection.State == ConnectionState.Open)
                return true;
            else
                return false;
        }

        private void SetConnectionString(string id, string pw, string oracle_address, string oracle_prot, string oracle_service)
        {
            this.ConnectionString = "User id=" + id + ";Password=" + pw + ";" +
                "Data Source=(DESCRIPTION=(ADDRESS=" +
                "(PROTOCOL=tcp)(HOST=" + oracle_address + ")" +
                "(PORT=" + oracle_prot + "))(CONNECT_DATA=" +
                "(SERVICE_NAME=" + oracle_service + ")))";
        }
    }
}
