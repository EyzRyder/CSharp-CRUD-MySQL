using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace DataBaseHomework
{
    internal class BibloitecaDAO
    {
        private string statement;
        private string resultSet;
        private string men;
        private string sql;

        BD db = new BD();
        public MySqlConnection DataBase()
        {
            if (db.getConection() == false) { return new MySqlConnection(); }

            //db.databaseConnection.ConnectionString = db.cs;
           return db.databaseConnection = new MySqlConnection(db.cs);
        }

        public Boolean autenticaUser(string name, string paswrd)
        {
            DataBase();
            string query = "SELECT * from admin where user_name = '" + name + "' and user_password = '" + paswrd + "' ";

            MySqlCommand commandDatabase = new MySqlCommand(query, db.databaseConnection);
            commandDatabase.CommandTimeout = 60;

            MySqlDataReader reader;

            try
            {
                db.databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (name != "" || paswrd != "")
                {

                    if (reader.HasRows)
                    {
                        return true;
    
                    }
                    else
                    {
                        MessageBox.Show("Nada foi encontrado");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("coloque seus dados");
                    return false;

                }

                db.close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;

            }

        }

        public void updateUser(string query)
        {
            DataBase();


            // Update the properties of the row with ID 1
            // string query = "UPDATE `user` SET `first_name`='MF',`last_name`='DOOM',`address`='NEWYORK' WHERE id = 4";

            MySqlCommand commandDatabase = new MySqlCommand(query, db.databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try {
                db.databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                // Succesfully updated

                db.databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        public void deleteUser(string id)
        {
            id.ToString();
            string query = "DELETE FROM `user` WHERE id =" + id;

            DataBase();

            MySqlCommand commandDatabase = new MySqlCommand(query, db.databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                db.databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                // Succesfully deleted

                db.close();
            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);

            }
        }

        public MySqlDataReader ListUsers()
        {

            // Select all
            string query = "SELECT * FROM user";
            DataBase();
            MySqlCommand commandDatabase = new MySqlCommand(query, db.databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                db.databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                // Success, now list 

                // If there are available rows
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //                                 ID                    First name                     Last Name                        Address
                        // Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3));
                        // row = new string[] { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        // return row;
                        return reader;
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    return default;


                }

                db.close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return default;


        }

        public void SaveUser(string first_name, string last_name, string address)
        {
            DataBase();

            string query = "INSERT INTO user(`id`, `first_name`, `last_name`, `address`) VALUES (NULL, '" + first_name + "', '" + last_name + "', '" + address + "')";
            // Which could be translated manually to :
            // INSERT INTO user(`id`, `first_name`, `last_name`, `address`) VALUES (NULL, 'Bruce', 'Wayne', 'Wayne Manor')

            MySqlCommand commandDatabase = new MySqlCommand(query, db.databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                db.databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("User succesfully registered");
                db.close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }
    }
}
