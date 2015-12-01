using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class DBConnection
    {
        SqlConnection myConnection = new SqlConnection(@"Data Source=Localhost; Initial Catalog= MessagesAteaGLobalServices;Integrated Security=True");
        SqlDataReader myReader = null;

        public void DatabaseConnection()
        {
            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void CloseDatabaseConnection()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public List<Message> getMessages()
        {
            List<Message> messages = new List<Message>();
            DatabaseConnection();
            try
            {
                var myCommand = new SqlCommand("SELECT * FROM Messages", myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    DateTime tempDateAndTime = (DateTime)myReader["DateAndTime"];
                    string tempMessage = myReader["Message"].ToString();
                    Message message = new Message(tempDateAndTime, tempMessage);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            CloseDatabaseConnection();

            return messages;
        }
    }
}