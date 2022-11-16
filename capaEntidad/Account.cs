using capaDatos;

namespace capaDatos
{
    
    public class Account
    {
        public string fecha { get; set; }
        public string nombre { get; set; }
        public float debe { get; set; }
        public float haber { get; set; }
        public int tipo { get; set; }

        public string Hash { get { return HashHelper.CalculateHash(string.Format("{0}{1}{2}{3}{4}", nombre, tipo, debe, haber, fecha)); } }

        public Account(string nombre, int tipo, float monto, int debeOHaber, string fecha)
        {
            this.fecha = fecha;
            this.nombre = nombre;
            this.tipo = tipo;

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