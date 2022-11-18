using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class AccountTotal
    {
        private String nombre;
        private float debe;
        private float haber;
        private float total;


        public string _Nombre { get => nombre; set => nombre = value; }
        public float _Debe { get => debe; set => debe = value; }
        public float _Haber { get => haber; set => haber = value; }
        public float _Total { get => total; set => total = value; }

        public AccountTotal()
        {
        }
        

        public AccountTotal(string nombre, float debe, float haber)
        {
            this.nombre = nombre;
            this.haber = haber;
            this.debe = debe;
        }
    }
}
