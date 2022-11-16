using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class HashHelper
    {
        /// <summary>
        /// calculate HASH for the blocks with SHA-256
        /// </summary>
        /// <param name="text">contain the param for hashing</param>
        /// <returns>a string with the Hash</returns>
        public static string CalculateHash(string text)
        {

            string myHashCalculated = string.Empty;

            using (SHA256 mySHA256 = SHA256.Create())
            {
                byte[] encodedText = new UTF8Encoding().GetBytes(text);
                byte[] myHashArray = mySHA256.ComputeHash(encodedText);
                myHashCalculated = BitConverter.ToString(myHashArray).Replace("-", string.Empty);
            }


            return myHashCalculated;
        }

    }
}

