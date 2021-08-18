using Edeeste.IRepository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        public static DbConnectionObj GetDbConnectionSQL()
        {
            const string key = "CSL_Ventas.Win.Properties.Settings.ConexionSQL";
            return GetDbConnection(key);
        }


        private static DbConnectionObj GetDbConnection(string key)
        {
            var keyTimeout = key + "Timeout";
            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings[key].ConnectionString);
            int timeOut;
            if (!int.TryParse(ConfigurationManager.AppSettings[keyTimeout], out timeOut)) timeOut = 8;
            var dbConnection = new DbConnectionObj
            {
                DbConnection = connection,
                TimeOut = timeOut
            };
            return dbConnection;
        }
    }
}
