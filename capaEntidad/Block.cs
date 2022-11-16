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

        public long Id { get; set; }
        public string Descripcion;
        public string Fecha;
        public DateTime Timestamp { get; set; }
        public Account[] Account { get; set; }
        public string Hash { get; set; }
        public string PreviousHash { get; set; }
        public int proof { get; set; }


        public Block(int index, List<Account> cuentas, string previousHash, String descripcion, String fecha)
        {
            Fecha = fecha;
            Descripcion = descripcion;
            Id = index;
            Account = cuentas != null ? cuentas.ToArray() : new Account[0];
            Timestamp = DateTime.Now;
            PreviousHash = previousHash;

        }
    }
}
