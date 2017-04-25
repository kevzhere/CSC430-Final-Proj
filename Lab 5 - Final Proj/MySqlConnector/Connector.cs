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
        
        //returns selected data, take in a string query
        public MySqlDataAdapter select(String query)
        {
            MySqlCommand qry = new MySqlCommand(query, conn);
            MySqlDataAdapter data = new MySqlDataAdapter(qry);
            return data;
        }      
        
        //updates data, take in string query
        public void update(String query)
        {
            MySqlCommand qry = new MySqlCommand(query, conn);
            MySqlDataAdapter data = new MySqlDataAdapter(qry);
        }
    }
}
