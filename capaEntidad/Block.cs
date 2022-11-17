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
        private String descripcion;
        private String fecha;
        private DateTime timestamp;
        private Seat seat;
        private String hash;
        private String previousHash;
        private int proof;

        public long _Id { get => id; set => id = value; }
        public string _Descripcion { get => descripcion; set => descripcion = value; }
        public string _Fecha { get => fecha; set => fecha = value; }
        public DateTime _Timestamp { get => timestamp; set => timestamp = value; }
        public Seat _Seat { get => seat; set => seat = value; }
        public string _Hash { get => hash; set => hash = value; }
        public string _PreviousHash { get => previousHash; set => previousHash = value; }
        public int _Proof { get => proof; set => proof = value; }

        public Block()
        {
        }

        public Block(long id, string descripcion, string fecha, DateTime timestamp, Seat seat, string hash, string previousHash, int proof)
        {
            _Id = id;
            _Descripcion = descripcion;
            _Fecha = fecha;
            _Timestamp = timestamp;
            _Seat = seat;
            _Hash = hash;
            _PreviousHash = previousHash;
            _Proof = proof;
        }

    }
}
