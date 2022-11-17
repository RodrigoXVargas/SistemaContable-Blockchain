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
                return true;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static bool PersistAccount(List<Account> account)
        {
            try
            {
                file = new FileStream("account.txt", FileMode.OpenOrCreate, FileAccess.Write);
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

        public void Carga_de_datos()
        {
            //Blockchain blockchain = new Blockchain();
            //Account caja = new Account("Caja", 0, 200, 0, "20/11/2022");
            //Account banco = new Account("Banco galicia", 0, 300, 0, "21/11/2022");
            //List<Account> listaCuentas = new List<Account>();
            //listaCuentas.Add(caja);
            //blockchain._TempAccount.Add(caja);
            //blockchain._TempAccount.Add(banco);


            List<Account> listaCuentas = new List<Account>();
            listaCuentas.Add(new Account("CAJA"));
            listaCuentas.Add(new Account("BANCO XXX C/C"));
            listaCuentas.Add(new Account("BANCO XXX C/A"));
            listaCuentas.Add(new Account("VALORES A DEPOSITAR"));
            listaCuentas.Add(new Account("VALORES DIFERIDOS A DEPOSITAR"));
            listaCuentas.Add(new Account("CHEQUES RECHAZADOS"));
            listaCuentas.Add(new Account("MONEDA EXTRANJERA"));
            listaCuentas.Add(new Account("TARJETA DE CREDITO XXX"));
            listaCuentas.Add(new Account("MERCADERIAS"));
            listaCuentas.Add(new Account("MATERIAS PRIMAS"));
            listaCuentas.Add(new Account("MUEBLES Y ÚTILES"));
            listaCuentas.Add(new Account("INSTALACIONES"));
            listaCuentas.Add(new Account("INMUEBLES"));
            listaCuentas.Add(new Account("RODADOS"));
            listaCuentas.Add(new Account("MAQUINARIAS"));
            listaCuentas.Add(new Account("EQUIPOS DE COMPUTACIÓN"));
            listaCuentas.Add(new Account("DEUDORES POR VENTAS"));
            listaCuentas.Add(new Account("DEUDORES VARIOS"));
            listaCuentas.Add(new Account("DEUDORES MOROSOS"));
            listaCuentas.Add(new Account("DEUDORES EN GESTIÓN JUDICIAL"));
            listaCuentas.Add(new Account("PREVISION DEUDORES INCOBRALES"));
            listaCuentas.Add(new Account("PREVISION POR DESVALORIZACIÓN DE BIENES DE CAMBIO"));
            listaCuentas.Add(new Account("DOCUMENTOS A COBRAR"));
            listaCuentas.Add(new Account("IVA A FAVOR"));


            if (Base.PersistAccount(listaCuentas))
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
