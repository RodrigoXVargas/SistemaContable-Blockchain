using capaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;
using MySql.Data.MySqlClient;

namespace capaPresentacion
{
    public partial class new_Seat : Form
    {
        AccountNegocio accountNegocio = new AccountNegocio();
        AccountCrud accountCrud = new AccountCrud();
        Base Base = new Base();
        public new_Seat()
        {
            InitializeComponent();
        }

        private void btn_NewAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            frAccount frAccount = new frAccount();
            frAccount.Show();
        }

        private void new_Seat_Load(object sender, EventArgs e)
        {
            comboCuentas.Items.Clear();
            MySqlConnection conn = Base.Conectar();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM accounts", conn);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                comboCuentas.Items.Add(reader[1]);
            }
            conn.Close();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
