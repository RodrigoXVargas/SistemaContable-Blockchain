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
using capaEntidad;

namespace capaPresentacion
{
    public partial class Ledger : Form
    {
        Blockchain bc = Base.ReadBlockchain();
        public Ledger()
        {
            InitializeComponent();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            DateTime from = dateFrom.Value.Date;
            DateTime to = dateTo.Value.Date;
            string acc = comboCuentas.SelectedItem.ToString();
            List<AccountLedger> accounts = new List<AccountLedger>();

            if (from > to && acc == null) MessageBox.Show("Introduzca bien los valores");
            else
            {
                for (int i = 0; i < bc._Blocks.Count; i++)
                {
                    if (bc._Blocks[i]._Seat._Date >= from && bc._Blocks[i]._Seat._Date <= to)
                    {
                        for(int z = 0; z < bc._Blocks[i]._Seat._Account.Count; z++)
                        {
                            if (bc._Blocks[i]._Seat._Account[z]._Nombre == acc) 
                                accounts.Add(new AccountLedger(bc._Blocks[i]._Seat._Account[z]._Debe, bc._Blocks[i]._Seat._Account[z]._Haber));
                        }
                    }
                }

                dgLedger.DataSource = accounts;
                
            }

        }
    }
}
