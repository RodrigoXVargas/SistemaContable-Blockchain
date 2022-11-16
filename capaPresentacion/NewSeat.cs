using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class new_Seat : Form
    {
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
