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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using System.Windows.Controls;

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

            debeHaber.Items.Add("Debe");
            debeHaber.Items.Add("Haber");
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

        private void btn_newSeat_Click(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            int selectedIndex = cmb.SelectedIndex;
            int selectedValue = (int)cmb.SelectedValue;

            ComboboxItem selectedAccount = (ComboboxItem)cmb.SelectedItem;

            Account account = new Account(cuentas.Items.);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
