using capaDatos;
using System.Windows.Forms;
using capaDatos;
using System.Data;

namespace capaNegocio
{
    public class AccountNegocio
    {
        AccountCrud accountCrud = new AccountCrud();
        public bool ValidarDatos(Account account)
        {
            bool resultado = true;

            if (account.Name == String.Empty)
            {
                resultado = false;
                MessageBox.Show("El nombre es obligatorio");
            }

            return resultado;

        }

        public void PruebaMySQL()
        {
            accountCrud.PruebaConexion();
        }

        public void CrearCliente(Account ce)
        {
            accountCrud.Crear(ce);
        }
        public void EditarCliente(Account ce)
        {
            accountCrud.Editar(ce);
        }
        public void EliminarCliente(Account ce)
        {
            accountCrud.Eliminar(ce);
        }

        public DataSet ObtenerDatos()
        {
            return accountCrud.Listar();
        }
    }
}