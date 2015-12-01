using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{

    class DBConnection
    {
        SqlConnection myConnection = new SqlConnection(@"Data Source=ACADEMY27-VM\SQLEXPRESS;Initial Catalog= MessagesAteaGLobalServices;Integrated Security=True");
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

        public void addMessage(DateTime consoleDateAndTime, string consoleMessage)
        {

            try
            {
                while (myReader.Read())
                {
                    var myCommand = new SqlCommand(

                    ($"insert into messages (Message, DateAndTime) Values ({consoleDateAndTime}, {consoleMessage})"));

                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }
}
