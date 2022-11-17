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
        //atributos
        private List<Block> blocks;
        private List<Account> tempAccount;
        private const int difficulty = 4;

        //getters and setters
        public List<Block> _Blocks { get => blocks; set => blocks = value; }
        public List<Account> _TempAccount { get => tempAccount; set => tempAccount = value; }
        public int _Difficulty => difficulty;

        public Blockchain()
        {
            blocks = new List<Block>();
            tempAccount = new List<Account>();
        }

    }
}
