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
using capaEntidad;

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
            Blockchain blockchain = Base.ReadBlockchain();
            /*Account caja = new Account("Caja", 0, 200, 0, "20/11/2022");
            Account banco = new Account("Banco galicia", 0, 300, 0, "21/11/2022");
            List<Account> list = new List<Account>();
            list.Add(caja);
            list.Add(banco);*/
            foreach (Account account in blockchain._TempAccount)
            {
                comboCuentas.Items.Add(account._nombre);
            }
            

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
