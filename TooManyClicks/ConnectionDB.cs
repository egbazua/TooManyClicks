using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TooManyClicks
{
    internal class ConnectionDB
    {
        string chain = "Data Source=EGBAZUA-PC;Initial Catalog=TooManyClicks; Integrated Security=True";
        public SqlConnection myConnection = new SqlConnection();

        public ConnectionDB()
        {
            myConnection.ConnectionString = chain;
        }

        public void open()
        {
            try
            {
                myConnection.Open();
                Console.WriteLine("Connection open");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Connection error" + ex.Message);
            }
        }

        public void close()
        {
            myConnection.Close();
        }
    }
}
