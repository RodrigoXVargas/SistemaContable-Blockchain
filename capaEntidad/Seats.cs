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
        private List<Account> account;

        public long Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        //public List<Account> account { get => account; set => account = value; }
        internal Seats(int id, DateTime date, List<Account> account)
        {
            this.id = id;
            this.date = date;
            this.account = account;
        }

        public Seats()
        {
        }

    }
}
