using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataBaseHomework
{

    internal class Usuario
    {
        private string usuario;
        private string senha;


        BibloitecaDAO dao = new BibloitecaDAO();

        public Boolean autenticaUser(string name, string paswrd)
        {
            usuario = name;
            senha = paswrd;

            if (dao.autenticaUser(usuario, senha) == false) {
                return false;
            }
            return true;
  
        }
    }
}
