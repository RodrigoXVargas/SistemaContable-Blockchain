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
        private Seats[] seats;
        private String hash;
        private String previousHash;
        private int proof;

        public long Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public DateTime Timestamp { get => timestamp; set => timestamp = value; }
        public Seats[] Seats { get => seats; set => seats = value; }
        public string Hash { get => hash; set => hash = value; }
        public string PreviousHash { get => previousHash; set => previousHash = value; }
        public int Proof { get => proof; set => proof = value; }

        public Block()
        {
        }

        public Block(long id, string descripcion, string fecha, DateTime timestamp, Seats[] seats, string hash, string previousHash, int proof)
        {
            Id = id;
            Descripcion = descripcion;
            Fecha = fecha;
            Timestamp = timestamp;
            Seats = seats;
            Hash = hash;
            PreviousHash = previousHash;
            Proof = proof;
        }

    }
}
