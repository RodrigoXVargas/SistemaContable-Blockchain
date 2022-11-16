using capaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class Base
    {
        private FileStream file;
        private BinaryFormatter formatter;

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

        public bool PersistBlockchain(Blockchain block)
        {
            try
            {
                file = new FileStream("file.txt", FileMode.OpenOrCreate, FileAccess.Write);
                formatter = new BinaryFormatter();
                formatter.Serialize(file, block);
                return true;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public Blockchain ReadBlockchain()
        {
            Blockchain chain = null;

            try
            {
                file = new FileStream("file.txt", FileMode.Open, FileAccess.Read);
                formatter = new BinaryFormatter();
                chain = (Blockchain)formatter.Deserialize(file);
                file.Close();
                return chain;
            }catch(Exception e)
            {
                Blockchain newBc = new Blockchain();
                return newBc;
            }
        }
    }
}
