﻿using System;
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
        private List<Seat> tempAccount = new List<Seat>();
        private const int difficulty = 4;

        //getters and setters
        public List<Block> _Blocks { get => blocks; set => blocks = value; }
        public int _Difficulty => difficulty;
        public List<Seat> _TempAccount { get => tempAccount; set => tempAccount = value; }

        public Blockchain()
        {
        }

        public Blockchain(List<Block> blocks, List<Seat> tempAccount)
        {
            _Blocks = blocks;
            _TempAccount = tempAccount;
            _Blocks = blocks;
            _TempAccount = tempAccount;
        }
    }
}
