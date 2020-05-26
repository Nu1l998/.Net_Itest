using Chloe.Infrastructure;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chloe_test
{
    class MySqlConnectionFactory : IDbConnectionFactory
    {
        string _connString = "server=127.0.0.1;port=23306;user=root;password=987426; database=mario2;Charset=utf8;";
        public MySqlConnectionFactory(string connString)
        {
            this._connString = connString;
        }
        public IDbConnection CreateConnection()
        {
            IDbConnection conn = new MySqlConnection(this._connString);
            /*如果有必要需要包装一下驱动的 MySqlConnection*/
            //conn = new Chloe.MySql.ChloeMySqlConnection(conn); 
            return conn;

        }
    }
}
