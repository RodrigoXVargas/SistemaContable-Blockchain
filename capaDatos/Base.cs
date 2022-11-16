using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class Base
    {
        public string CadenaConexion = "Server=localhost;User=root;Password=;Port=3306;database=contabilidad_db";

        public MySqlConnection Conectar()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            return mySqlConnection;
        }

        public void Desconectar(MySqlConnection mySqlConnection)
        {
            mySqlConnection.Close();
        }
    }
}
