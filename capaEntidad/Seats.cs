using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace capaDatos
{
    public class Seats
    {

        private long id;
        private DateTime date;
        private List<Account> account = new List<Account>();

        public long _Id { get => id; set => id = value; }
        public DateTime _Date { get => date; set => date = value; }
        public List<Account> _Account { get => account; set => account = value; }
        internal Seats(int id, DateTime date, List<Account> account)
        {
            _Id = id;
            _Date = date;
            _Account = account;
        }

        public Seats()
        {
        }

    }
}
