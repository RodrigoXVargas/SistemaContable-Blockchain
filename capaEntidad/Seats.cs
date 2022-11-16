using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;

namespace capaEntidad
{
    internal class Seats
    {

        private long id;
        private DateTime date;
        private List<Movement> fk_movement;

        public long Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public List<Movement> Fk_movement { get => fk_movement; set => fk_movement = value; }
        public Seats(int id, DateTime date, List<Movement> fk_movement)
        {
            this.id = id;
            this.date = date;
            this.fk_movement = fk_movement;
        }

        public Seats()
        {
        }
    }
}
