using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDatos;
using capaEntidad;

namespace capaPresentacion
{
    public partial class DiaryBook : Form
    {
        Blockchain bc = Base.ReadBlockchain();
        public DiaryBook()
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
            List<Seat> seats = new List<Seat>();

            if (from > to) MessageBox.Show("Introduzca bien las fechas");
            else
            {
                for (int i = 0; i < bc._Blocks.Count; i++)
                {
                    if (bc._Blocks[i]._Seat._Date >= from && bc._Blocks[i]._Seat._Date <= to) seats.Add(bc._Blocks[i]._Seat);
                }

                dgSeat.DataSource = seats;
            }

        }

        private void dgSeat_SelectionChanged(object sender, EventArgs e)
        {
            Seat s = (Seat)dgSeat.CurrentRow.DataBoundItem;
            dgMoves.DataSource = s._Account;
        }
    }
}
