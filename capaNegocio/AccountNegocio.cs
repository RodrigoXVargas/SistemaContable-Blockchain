using capaEntidad;
using System.Windows.Forms;
using capaDatos;
using System.Data;

namespace capaNegocio
{
    public class AccountNegocio
    {
        AccountData accountData = new AccountData();
        public bool ValidarDatos(Account account)
        {
            bool resultado = true;

            if (account.name == String.Empty)
            {
                resultado = false;
                MessageBox.Show("El nombre es obligatorio");
            }

            return resultado;

        }

        public void PruebaMySQL()
        {
            accountData.PruebaConexion();
        }

        public void CrearCliente(Account ce)
        {
            accountData.Crear(ce);
        }
        public void EditarCliente(Account ce)
        {
            accountData.Editar(ce);
        }
        public void EliminarCliente(Account ce)
        {
            accountData.Eliminar(ce);
        }

        public DataSet ObtenerDatos()
        {
            return accountData.Listar();
        }
    }
}