using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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


                myHashCalculated = BitConverter.ToString(myHashArray).Replace("-", String.Empty);          //Replace("-", string.Empty) ==> el byte array tiene guines en medio(segun el que explica en el video), esta funcion quita los guiones

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
            String text = String.Format("{0}{1}{2}", seat._Date, seat._HashSeat, proof);
            
            String zeros = String.Empty.PadLeft(dificultad, '0');

            do
            {

                text = String.Format("{0}{1}{2}", seat._Date, seat._HashSeat, proof);
                hash = Miner.CalculateHash(text);
                proof++;
            } while (!hash.StartsWith(zeros));

            return hash;
        }


        public static bool Validator(Seat seat)
        {
            return true;
        }
    }
}
