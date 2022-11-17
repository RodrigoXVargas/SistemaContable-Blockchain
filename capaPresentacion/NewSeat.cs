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
            List<string> listaCuentas = new List<string>
        {
            "CAJA",
            "BANCO XXX C/C",
            "BANCO XXX C/A",
            "VALORES A DEPOSITAR",
            "VALORES DIFERIDOS A DEPOSITAR",
            "CHEQUES RECHAZADOS",
            "MONEDA EXTRANJERA",
            "TARJETA DE CREDITO XXX",
            "MERCADERIAS",
            "MATERIAS PRIMAS",
            "MUEBLES Y ÚTILES",
            "INSTALACIONES",
            "INMUEBLES",
            "RODADOS",
            "MAQUINARIAS",
            "EQUIPOS DE COMPUTACIÓN",
            "DEUDORES POR VENTAS",
            "DEUDORES VARIOS",
            "DEUDORES MOROSOS",
            "DEUDORES EN GESTIÓN JUDICIAL",
            "PREVISION DEUDORES INCOBRALES",
            "PREVISION POR DESVALORIZACIÓN DE BIENES DE CAMBIO",
            "DOCUMENTOS A COBRAR",
            "IVA A FAVOR"
        };

            foreach (string item in listaCuentas)
                comboCuentas.Items.Add(item);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void comboCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> listaCuentas = new List<string>
        {
            "CAJA",
            "BANCO XXX C/C",
            "BANCO XXX C/A",
            "VALORES A DEPOSITAR",
            "VALORES DIFERIDOS A DEPOSITAR",
            "CHEQUES RECHAZADOS",
            "MONEDA EXTRANJERA",
            "TARJETA DE CREDITO XXX",
            "MERCADERIAS",
            "MATERIAS PRIMAS",
            "MUEBLES Y ÚTILES",
            "INSTALACIONES",
            "INMUEBLES",
            "RODADOS",
            "MAQUINARIAS",
            "EQUIPOS DE COMPUTACIÓN",
            "DEUDORES POR VENTAS",
            "DEUDORES VARIOS",
            "DEUDORES MOROSOS",
            "DEUDORES EN GESTIÓN JUDICIAL",
            "PREVISION DEUDORES INCOBRALES",
            "PREVISION POR DESVALORIZACIÓN DE BIENES DE CAMBIO",
            "DOCUMENTOS A COBRAR",
            "IVA A FAVOR"
        };

            foreach(string item in listaCuentas)
                comboCuentas.Items.Add(item);
        }
    }
}
