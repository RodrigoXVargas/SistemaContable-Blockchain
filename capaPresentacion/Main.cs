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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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
    }
}
