using capaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                file = new FileStream("block.txt", FileMode.OpenOrCreate, FileAccess.Write);
                formatter = new BinaryFormatter();
                formatter.Serialize(file, block);
                file.Close();
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
                file = new FileStream("block.txt", FileMode.Open, FileAccess.Read);
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

        public List<string> carga_combo()
        {
            return new List<string>
            {
                "CAJA",
                "DEUDORES VARIOS",
                "MERCADERIAS",
                "RODADOS",
                "MUEBLES Y UTILES",
                "INSTALACIONES",
                "CAPITAL",
                "BANCO NACIÓN CTA/CTE",
                "VENTAS",
                "COSTO MERCADERIA VENDIDA",
                "LUZ, GAS Y TELEFONO",
                "SEGUROS PERDIDOS",
                "LIBRERIA Y PAPELERIA",
                "ALQUILERES PERDIDOS",
                "BANCO TROPICAL CTA/CTE",
                "GASTOS VARIOS",
                "SINIESTROS"
            };
        }
    }
}
