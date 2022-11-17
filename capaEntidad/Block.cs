﻿using capaEntidad;
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

        public Block(long id, Seat seat, string hash, string previousHash, Blockchain blockchain)
        {
            this.id = id;
            this.seat = seat;
            this.hash = Miner.MineBlock(seat);
            if (blockchain._Blocks.Count == 0)
            {
                this.previousHash = "cero";
            }
            else
            {
                this.previousHash = blockchain._Blocks[blockchain._Blocks.Count - 1]._Hash;
            }
        }


        
    }
}
