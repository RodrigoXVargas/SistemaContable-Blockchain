using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class AccountLedger
    {
        private float debe;
        private float haber;

        public float _Debe { get => debe; set => debe = value; }
        public float _Haber { get => haber; set => haber = value; }

        public AccountLedger (float debe, float haber)
        {
            _Debe = debe;
            _Haber = haber;
        }
    }
}
