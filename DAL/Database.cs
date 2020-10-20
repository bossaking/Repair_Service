using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows;
using Repair_Service.Models;

namespace Repair_Service.DAL
{
    public abstract class Database
    {
        private string connectionString;
        public MySqlConnection connection;


        public Database()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            connection = new MySqlConnection(connectionString);
        }


        public void OpenConnection()
        {
            try
            {
                connection.Open();
                
                MessageBox.Show(connection.Database, "Server");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }



        #region Abstract Methods

        public abstract bool InsertData(Order order);

        public abstract void ReadData();

        public abstract void UpdateData(Order order);

        #endregion
    }
}
