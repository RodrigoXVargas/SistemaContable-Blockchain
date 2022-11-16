using capaDatos;
using capaNegocio;
using capaDatos;

namespace capaPresentacion
{
    public partial class frAccount : Form
    {
        AccountNegocio accountNegocio = new AccountNegocio();

        public frAccount()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void LimpiarForm()
        {
            txtID.Value = 0;
            txtNombre.Text = String.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool resultado;
            Account account = new Account();

            account.Id = (int)txtID.Value;
            account.Name = txtNombre.Text;

            resultado = accountNegocio.ValidarDatos(account);

            if (resultado == false)
            {
                return;
            }

            if (account.Id == 0)
            {
                accountNegocio.CrearCliente(account);
            }
            else
            {
                accountNegocio.EditarCliente(account);
            }

            CargarDatos();
            LimpiarForm();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Value == 0) return;

            if (MessageBox.Show("Deseas eliminar el registro?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Account account = new Account();
                account.Id = (int)txtID.Value;
                accountNegocio.EliminarCliente(account);
            }
            CargarDatos();
            LimpiarForm();
        }

        private void frClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            gridDatos.DataSource = accountNegocio.ObtenerDatos().Tables["accounts"];
        }

        private void gridDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtID.Value = (int)gridDatos.CurrentRow.Cells["id"].Value;
                txtNombre.Text = gridDatos.CurrentRow.Cells["name"].Value.ToString();
            }
            catch
            {
                txtID.Value = 0;
                txtNombre.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new_Seat new_Seat = new new_Seat();
            new_Seat.Show();
        }
    }
}