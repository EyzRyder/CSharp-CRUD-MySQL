using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DataBaseHomework
{
    internal class Registro
    {
        private string id;
        private string nome;
        private string sobrenome;
        private string endereco;
        BibloitecaDAO dao = new BibloitecaDAO();

        public void updateUser()
        {
            dao.updateUser("");
        }


        public void deleteUser(string ID)
        {
            id = ID;
            // Delete the item with ID 1
            // string id = listView1.SelectedItems[0].Text.ToString();
            dao.deleteUser(id);
        }
        public MySqlDataReader listUsers()
        {
            MySqlDataReader reader = dao.ListUsers();

            return reader;
        }

        public void SaveUser(string first_name, string last_name, string address)
        {
            nome = first_name;
            sobrenome = last_name;
            endereco = address;

            dao.SaveUser(nome, sobrenome, endereco);
        }
    }
}
