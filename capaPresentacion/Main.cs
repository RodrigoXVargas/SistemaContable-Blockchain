using capaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class Main : Form
    {
        Base Base = new Base();
        Blockchain block = new Blockchain();
        public Main()
        {
            InitializeComponent();
            block = Base.ReadBlockchain();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            new_Seat new_Seat = new new_Seat();
            new_Seat.Show();
        }

        private void btnLibroDiario_Click(object sender, EventArgs e)
        {
            this.Hide();
            DiaryBook dBook = new DiaryBook();
            dBook.Show();
        }

        private void btnLibroMayor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ledger ledger = new Ledger();
            ledger.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            if (Base.PersistBlockchain(block))
            {
                MessageBox.Show("Hasta Luego");
            }
            else
            {
                MessageBox.Show("No Persistido. Bye");
            }
            this.Close();
        }
    }
}
