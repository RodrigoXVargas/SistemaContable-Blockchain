using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using System.Security.Principal;

namespace capaEntidad
{
    public class Miner
    {

        static int dificultad = 4;



        /// <summary>
        /// Calcula el HASH
        /// </summary>
        /// <param name="text"></param>
        /// <returns>calculo del HASH</returns>
        public static String CalculateHash(String text)
        {

            String myHashCalculated = String.Empty;
            using (SHA256 mySHA256 = SHA256.Create())
            {
                byte[] encodedText = new UTF8Encoding().GetBytes(text);
                byte[] myHashArray = mySHA256.ComputeHash(encodedText);
                myHashCalculated = BitConverter.ToString(myHashArray).Replace("-", String.Empty);

            }
            return myHashCalculated;
        }


        /// <summary>
        /// Generar y alcular el HASH del bloque
        /// </summary>
        /// <param name="seat"></param>
        /// <returns>el HASH validado</returns>
        public static String MineBlock(Seat seat)
        {
            String hash = "";
            int proof = 0;            
            String zeros = String.Empty.PadLeft(dificultad, '0');

            do
            {
                String text = String.Format("{0}{1}{2}", seat._Date, seat._HashSeat, proof);
                hash = Miner.CalculateHash(text);
                proof++;
            } while (!hash.StartsWith(zeros));

            return hash;
        }


        public static bool Validator(Seat seat, Blockchain blockchain, List<String> accountNames)
        {
            bool resultado = true;
            List<Account> accounts = new List<Account>();
            foreach (String accountName in accountNames)
            {
                Account a = new Account();
                a._Nombre = accountName;
                a._Haber += 0;
                a._Debe += 0;
                foreach (Block block in blockchain._Blocks)
                {
                    foreach (Account account in block._Seat._Account)
                    {
                        if (account._Nombre.Equals(accountName))
                        {
                            a._Haber += account._Haber;
                            a._Debe += account._Debe;
                        }
                    }

                }
                foreach (Account accountSeat in seat._Account)
                {
                    if (accountSeat._Nombre.Equals(a._Nombre))
                    {
                        a._Haber += accountSeat._Haber;
                        a._Debe += accountSeat._Debe;

                    }
                    
                }
                accounts.Add(a);
            }

            float total = 0;
            foreach (Account a in accounts)
            {
                total += a._Haber - a._Debe;
            }

            if (total == 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
