using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DataBaseHomework
{
    internal class BD
    {
        public string cs = "datasource=localhost;port=3306;username=root;password=raizV2toorU2;database=nossobanco;";
        public MySqlConnection databaseConnection = new MySqlConnection();

        public Boolean getConection()
        {
            
            try
            {
                databaseConnection.ConnectionString = cs;
                databaseConnection = new MySqlConnection(cs);
                databaseConnection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                close();
                Console.WriteLine(ex.Message);
                return false;
            }

        }
        public void close()
        {
            databaseConnection.Close();
        }
    }
}
