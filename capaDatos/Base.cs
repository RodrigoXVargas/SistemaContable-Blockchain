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
                file = new FileStream(@"C:\Users\rodri\Desktop\contabilidad\block.txt", FileMode.OpenOrCreate, FileAccess.Write);
                formatter = new BinaryFormatter();
                formatter.Serialize(file, block);
                return true;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static bool PersistBlockchain(Account account)
        {
            try
            {
                file = new FileStream(@"C:\Users\rodri\Desktop\contabilidad\block.txt", FileMode.OpenOrCreate, FileAccess.Write);
                formatter = new BinaryFormatter();
                formatter.Serialize(file, account);
                return true;
            }
            catch (Exception e)
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
                file = new FileStream(@"C:\Users\rodri\Desktop\contabilidad\block.txt", FileMode.Open, FileAccess.Read);
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

        public void Carga_de_datos()
        {
            Blockchain blockchain = new Blockchain();
            Account caja = new Account("Caja", 0, 200, 0, "20/11/2022");
            Account banco = new Account("Banco galicia", 0, 300, 0, "21/11/2022");
            List<Account> listaCuentas = new List<Account>();
            listaCuentas.Add(caja);
            blockchain._TempAccount.Add(caja);
            blockchain._TempAccount.Add(banco);
            if (Base.PersistBlockchain(blockchain))
            {
                MessageBox.Show("datos guardados");
            }
            else
            {
                MessageBox.Show("datos no guardados");
            }
            
        }
    }
}
