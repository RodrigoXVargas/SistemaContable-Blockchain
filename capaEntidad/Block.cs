using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Block
    {

        private long id;
        private string hash;
        private string previusHash;
        private List<Seats> fk_seats;

        internal Block(long id, string hash, string previusHash, List<Seats> fk_seats)
        {
            this.id = id;
            this.hash = hash;
            this.previusHash = previusHash;
            this.fk_seats = fk_seats;
        }

        internal Block()
        {
        }

        public long Id { get => id; set => id = value; }
        public string Hash { get => hash; set => hash = value; }
        public string PreviusHash { get => previusHash; set => previusHash = value; }
        internal List<Seats> Fk_seats { get => fk_seats; set => fk_seats = value; }


    }
}
