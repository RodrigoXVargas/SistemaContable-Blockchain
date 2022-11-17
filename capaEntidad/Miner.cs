using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    /// <summary>
    /// filter of seat and block
    /// </summary>
    public class Miner
    {



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

        public static String MineBlock(Seat seat, int difficulty)
        {
            String hash = "";

            String initialText = String.Format("{0}{1}", seat._Date, seat._HashSeat);
            int proof = 0;
            String text = String.Format("{0}{1}", initialText, proof);
            String zeros = String.Empty.PadLeft(difficulty, '0');

            do
            {
                proof++;
                text = String.Format("{0}{1}", initialText, proof);
                hash = Miner.CalculateHash(text);
            } while (!hash.StartsWith(zeros));

            return hash;
        }

    }
}
