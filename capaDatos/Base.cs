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
        private static FileStream file;
        private static BinaryFormatter formatter;
        public static bool PersistBlockchain(Blockchain block)
        {
            try
            {
                file = new FileStream(@"C:\Users\Usuario\Desktop\a\block.txt", FileMode.OpenOrCreate, FileAccess.Write);
                formatter = new BinaryFormatter();
                formatter.Serialize(file, block);
                return true;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static Blockchain ReadBlockchain()
        {
            Blockchain chain = null;

            try
            {
                file = new FileStream(@"C:\Users\Usuario\Desktop\a\block.txt", FileMode.Open, FileAccess.Read);
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
