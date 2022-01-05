using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Data;

namespace eOPS
{
    class Networksetup
    {
        public void network()
        {
            /*
            OdbcConnection conn = new OdbcConnection();
            conn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};" + "Server=185.245.96.234; Database=flights" + "User=Herz;Passwort=02109989";
            
            OdbcCommand comand = new OdbcCommand();
            comand.Connection = conn;
            comand.CommandText = "insert into duty (DOF, FLT) value ('01.09.2021', 'DLH400')";
            OdbcDataAdapter data = new OdbcDataAdapter();
            data.SelectCommand = comand;

            DataSet ds = new DataSet();
            conn.Open();
            data.Fill(ds, "CommandText");
            conn.Close();

            
                    }
       
            */

        }
    }
}
// IP: 185.245.96.234
//flights