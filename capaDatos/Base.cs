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
                "BANCO XXX C/C",
                "BANCO XXX C/A",
                "VALORES A DEPOSITAR",
                "VALORES DIFERIDOS A DEPOSITAR",
                "CHEQUES RECHAZADOS",
                "MONEDA EXTRANJERA",
                "TARJETA DE CREDITO XXX",
                "MERCADERIAS",
                "MATERIAS PRIMAS",
                "MUEBLES Y ÚTILES",
                "INSTALACIONES",
                "INMUEBLES",
                "RODADOS",
                "MAQUINARIAS",
                "EQUIPOS DE COMPUTACIÓN",
                "DEUDORES POR VENTAS",
                "DEUDORES VARIOS",
                "DEUDORES MOROSOS",
                "DEUDORES EN GESTIÓN JUDICIAL",
                "PREVISION DEUDORES INCOBRALES",
                "PREVISION POR DESVALORIZACIÓN DE BIENES DE CAMBIO",
                "DOCUMENTOS A COBRAR",
                "IVA A FAVOR"
            };
        }
    }
}
