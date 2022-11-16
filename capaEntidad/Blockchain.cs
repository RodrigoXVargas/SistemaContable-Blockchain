using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    [Serializable]
    public class Blockchain
    {

        public List<Block> Blocks { get; set; }

        public List<Account> TempAccount { get; set; }

        public const int Difficulty = 4;


        public Blockchain()
        {

            Blocks = new List<Block>();
            TempAccount = new List<Account>();
        }

    }
}
