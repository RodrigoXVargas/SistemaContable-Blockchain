using System;
using MySql.Data.MySqlClient;
using capaDatos;
using capaDatos;
using System.Data;


namespace capaDatos
{
    public class AccountCrud
    {
        /*Base Base = new Base();

        public void PruebaConexion()
        {
            MySqlConnection conexion = Base.Conectar();

            try
            {
                conexion.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al conectarse " + e.Message);
                return;
            }
            conexion.Close();
            MessageBox.Show("Conectado!");

        }

        public void Crear(Account account)
        {
            MySqlConnection conexion = Base.Conectar();
            string Query = "INSERT INTO `accounts` (`name`) VALUES ('"+ account.Name + "');";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, conexion);
            mySqlCommand.ExecuteNonQuery();
            conexion.Close();

            MessageBox.Show("Registro Creado!");
        }

        public void Editar(Account account)
        {
            MySqlConnection conexion = Base.Conectar();
            conexion.Open();
            string Query = "UPDATE `accounts` SET `name`='"+ account.Name +"' WHERE  `id`="+ account.Id +";";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, conexion);
            mySqlCommand.ExecuteNonQuery();
            conexion.Close();

            MessageBox.Show("Registro Actualizado!");
        }

        public void Eliminar(Account account)
        {
            MySqlConnection conexion = Base.Conectar();
            conexion.Open();
            string Query = "DELETE FROM `accounts` WHERE  `id`="+ account.Id + ";";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, conexion);
            mySqlCommand.ExecuteNonQuery();
            conexion.Close();

            MessageBox.Show("Registro Eliminar!");
        }

        public DataSet Listar()
        {
            MySqlConnection conexion = Base.Conectar();
            string Query = "SELECT  `id`, `name` FROM `accounts` LIMIT 1000;";
            MySqlDataAdapter Adaptador;
            DataSet dataSet = new DataSet();

            Adaptador = new MySqlDataAdapter(Query, conexion);
            Adaptador.Fill(dataSet, "accounts");
            
            return dataSet;

        }*/

        

    }
}