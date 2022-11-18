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

namespace capaPresentacion
{
    public partial class LedgerTotal : Form
    {
        public LedgerTotal()
        {
            InitializeComponent();
        }

        private void bBack_Click(object sender, EventArgs e)
        {

        }

        private void LedgerTotal_Load(object sender, EventArgs e)
        {
            Base Base = new Base();
            List<String> listNames = Base.carga_combo();
            Blockchain blockchain = Base.ReadBlockchain();
            List<Account> accounts = new List<Account>();

            foreach (String nameAccount in listNames)
            {
                Account account = new Account();
                account._Nombre = nameAccount;
                account._Haber = 0;
                account._Debe = 0;
                foreach (Block block in blockchain._Blocks)
                {
                    foreach (Account a in block._Seat._Account)
                    {
                        if (a._Nombre.Equals(account._Nombre))
                        {
                            account._Debe += a._Debe;
                            account._Haber += a._Haber;
                        }
                    }
                }
                accounts.Add(account);

            }
            float total = 0;
            foreach (Account account in accounts)
            {
                total += account._Haber - account._Debe;
            }
            


        }
    }
}
