using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    [Serializable]
    public class Block
    {

        private long id;
        private Seat seat;
        private String hash;
        private String previousHash;

        public long _Id { get => id; set => id = value; }
        public Seat _Seat { get => seat; set => seat = value; }
        public string _Hash { get => hash; set => hash = value; }
        public string _PreviousHash { get => previousHash; set => previousHash = value; }

        public Block()
        {
        }

        public Block(long id, Seat seat, string hash, string previousHash)
        {
            _Id = id;
            _Seat = seat;
            _Hash = hash;
            _PreviousHash = previousHash;
        }

    }
}
