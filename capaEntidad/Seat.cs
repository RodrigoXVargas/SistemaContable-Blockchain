using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace capaDatos
{
    [Serializable]
    public class Seat
    {

        private long id;
        private DateTime date;
        private String name;
        private List<Account> account = new List<Account>();

        public long _Id { get => id; set => id = value; }
        public DateTime _Date { get => date; set => date = value; }
        public List<Account> _Account { get => account; set => account = value; }
        public string _Name { get => name; set => name = value; }

        internal Seat(int id, DateTime date, String name, List<Account> account)
        {
            _Id = id;
            _Date = date;
            _Name = name;
            _Account = account;
        }

        public Seat()
        {
        }

    }
}
