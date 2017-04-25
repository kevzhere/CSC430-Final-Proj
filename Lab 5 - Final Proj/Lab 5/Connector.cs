using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace MySqlConnector
{

    public class Connector
    {
        static MySqlConnection conn;
        //connects to dataserver if possible
        public static void con(String server, String user, String pass, String data)
        {
                String conString = "server=" + server + ";User Id=" + user + ";password=" + pass + ";database=" + data + ";";
                conn = new MySqlConnection(conString);
                conn.Open();
        }
        
        //returns selected data 
        public static Object login(String user, String Pass)
        {
            //String qry = "select * from customer where username = '" + user + "' and passw = '" + Pass + "';";
            String qry = "select * from customer where username = 'abc123' and passw = 'abc123';";
            MySqlCommand check = new MySqlCommand(qry, conn);
            Object value = check.ExecuteScalar();
            return value;
        }

        public static MySqlCommand query(String query)
        {
            MySqlCommand qry = new MySqlCommand(query, conn);
            return qry;
        }
        public static void update( String query)
        {
            MySqlCommand qry = new MySqlCommand(query, conn);
            qry.ExecuteNonQuery();
        }

        public static MySqlCommand select (string query)
        {
            MySqlCommand qry = new MySqlCommand(query, conn);
            return qry;
        }

        public static MySqlDataAdapter table(string query)
        {
            MySqlCommand qry = new MySqlCommand(query, conn);
            MySqlDataAdapter data = new MySqlDataAdapter(qry);
            return data;
        }
        public static void test()
        {
            MySqlCommand qry = new MySqlCommand("select num_left from room_left;", conn);
            MySqlDataReader rdr = qry.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine("testing");
                Console.WriteLine(rdr[0]);
            }
        }
        
              
    }
}
