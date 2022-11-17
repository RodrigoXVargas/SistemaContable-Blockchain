using capaDatos;
using capaEntidad;

namespace capaDatos
{
    [Serializable]
    public class Account
    {
        private String fecha;
        private String nombre;
        private float debe;
        private float haber;

        public String _fecha { get => _fecha; set { _fecha = value; } }
        public String _nombre { get => _nombre; set { _nombre = value; } }
        public float _debe { get => _debe; set { _debe = value; } }
        public float _haber { get => _haber; set { _haber = value; } }

        public Account(string nombre)
        {
            this.nombre = nombre;
        }

        public Account(string nombre, int tipo, float monto, int debeOHaber, string fecha)
        {
            this.fecha = fecha;
            this.nombre = nombre;

            if (debeOHaber == 0)
            {
                this.debe = monto;
            }
            else
            {
                this.haber = monto;
            }

        }

    }
}