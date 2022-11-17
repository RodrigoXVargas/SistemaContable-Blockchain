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
using MySql.Data.MySqlClient;
using capaEntidad;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using System.ComponentModel.DataAnnotations;
using TextBox = System.Windows.Forms.TextBox;

namespace capaPresentacion
{
    public partial class new_Seat : Form
    {
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


            List<Account> accountList = new List<Account>();

            Account account = new Account();

            try
            {
                if (string.IsNullOrEmpty(textBox1.Text)) { throw new InvalidOperationException(""); }
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {


                    account._Nombre = (string)dataGridView1.Rows[i].Cells[0].FormattedValue;

                    if (dataGridView1.Rows[i].Cells[1].FormattedValue.Equals("Debe"))
                    {
                        account._Debe = Convert.ToSingle(dataGridView1.Rows[i].Cells[2].FormattedValue);
                        account._Haber = 0;
                    }
                    else if (dataGridView1.Rows[i].Cells[1].FormattedValue.Equals("Haber"))
                    {
                        account._Haber = Convert.ToSingle(dataGridView1.Rows[i].Cells[2].FormattedValue);
                        account._Debe = 0;
                    }
                    else
                    {
                        throw new InvalidOperationException("");
                    }

                    accountList.Add(account);
                }

                Seat seat = new Seat(date_Seat.Value.Date, textBox1.Text, accountList);
                if (Miner.Validator(seat))
                {
                    Blockchain blockchain = Base.ReadBlockchain();
                    Block block = new Block(seat, blockchain);

                    blockchain._Blocks.Add(block);

                    Base.PersistBlockchain(blockchain);
                    MessageBox.Show("Carga exitosa");
                }
                else
                {
                    MessageBox.Show("Datos erroneos");
                }

                                

            }
            catch
            {
                MessageBox.Show("Hay una celda vacia");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void date_Seat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
