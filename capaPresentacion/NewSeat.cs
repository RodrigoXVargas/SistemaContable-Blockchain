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
        { }

        private void new_Seat_Load(object sender, EventArgs e)
        {
            Base persistence = new Base();

            foreach (string item in persistence.carga_combo())
                cuentas.Items.Add(item);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void comboCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboCuentas_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
