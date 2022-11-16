using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace capaDatos
{
    public class Movement
    {
        private int id { get => id; set => id = value; }
        private Account account { get; set; }

        private double mount { get => mount; set => mount = value; }

        public Movement(int id, Account account, double mount)
        {
            this.id = id;
            this.account = account;
            this.mount = mount;
        }

        public Movement()
        {
        }
    }
}
