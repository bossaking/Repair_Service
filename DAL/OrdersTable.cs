using MySql.Data.MySqlClient;
using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Type = Repair_Service.Models.Type;

namespace Repair_Service.DAL
{
    public class OrdersTable : Database
    {

        private List<Order> orders;

        public OrdersTable()
        {
            orders = new List<Order>();
        }

        public List<Order> GetOrders()
        {
            return orders;
        }

        public override bool InsertData(Order order)
        {
            string sql = $"INSERT INTO Orders (MainProblem, PhoneNumber, OwnerName, StartPrice, TakenDate, Type, Status) VALUES " +
                $"('{order.MainProblem}', '{order.PhoneNumber}', '{order.OwnerName}', '{order.StartPrice}', '{order.TakenDate:yyyy-MM-dd HH:mm:ss}'," +
                $" '{order.Type}', '{order.Status}');";

            MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
            OpenConnection();

            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
                return false;
            }

            CloseConnection();
            return true;
        }

        public override void ReadData()
        {
            orders.Clear();

            string sql = "SELECT * FROM Orders";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
            OpenConnection();

            try
            {
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    orders.Add(new Order(
                        mySqlDataReader["MainProblem"].ToString(),
                        mySqlDataReader["PhoneNumber"].ToString(),
                        mySqlDataReader["OwnerName"].ToString(),
                        int.Parse(mySqlDataReader["StartPrice"].ToString()),
                        DateTime.Parse(mySqlDataReader["TakenDate"].ToString()),
                        (Type)Enum.Parse(typeof(Type), mySqlDataReader["Type"].ToString()),
                        (Status)Enum.Parse(typeof(Status), mySqlDataReader["Status"].ToString())
                        )
                        { Id = int.Parse(mySqlDataReader["Id"].ToString())});
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }

            CloseConnection();
        }

        public override void UpdateData(Order order)
        {
            string sql = $"UPDATE Orders SET MainProblem = {order.MainProblem}, PhoneNumber = {order.PhoneNumber}, OwnerNumber = {order.PhoneNumber}, " +
                $"StartPrice = {order.StartPrice}, Status = {order.Status} WHERE Id = {order.Id}";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
            OpenConnection();

            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }

            CloseConnection();
        }

    }
}
