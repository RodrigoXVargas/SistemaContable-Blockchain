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
        private List<Block> blocks = new List<Block>();
        private List<Account> tempAccount = new List<Account>();
        private const int difficulty = 4;

        //getters and setters
        public List<Block> _Blocks { get => blocks; set => blocks = value; }
        public List<Account> _TempAccount { get => tempAccount; set => tempAccount = value; }
        public int _Difficulty => difficulty;

        public Blockchain()
        {
        }

        public Blockchain(List<Block> blocks, List<Account> tempAccount)
        {
            _Blocks = blocks;
            _TempAccount = tempAccount;
            _Blocks = blocks;
            _TempAccount = tempAccount;
        }
    }
}
