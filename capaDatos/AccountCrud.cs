using System;
using MySql.Data.MySqlClient;
using capaEntidad;
using capaDatos;
using System.Data;

namespace capaDatos
{
    public class AccountCrud
    {
        string CadenaConexion = "Server=localhost;User=root;Password=;Port=3306;database=contabilidad_db";

        public void PruebaConexion()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);

            try
            {
                mySqlConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al conectarse " + e.Message);
                return;
            }
            mySqlConnection.Close();
            MessageBox.Show("Conectado!");

        }

        public void Crear(Account account)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "INSERT INTO `accounts` (`name`) VALUES ('"+ account.Name + "');";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();

            MessageBox.Show("Registro Creado!");
        }

        public void Editar(Account account)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "UPDATE `accounts` SET `name`='"+ account.Name +"' WHERE  `id`="+ account.Id +";";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();

            MessageBox.Show("Registro Actualizado!");
        }

        public void Eliminar(Account account)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "DELETE FROM `accounts` WHERE  `id`="+ account.Id + ";";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();

            MessageBox.Show("Registro Eliminar!");
        }

        public DataSet Listar()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "SELECT  `id`, `name` FROM `accounts` LIMIT 1000;";
            MySqlDataAdapter Adaptador;
            DataSet dataSet = new DataSet();

            Adaptador = new MySqlDataAdapter(Query, mySqlConnection);
            Adaptador.Fill(dataSet, "accounts");

            return dataSet;

        }

        

    }
}