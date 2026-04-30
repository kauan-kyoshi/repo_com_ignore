using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LogiN
{
    internal class Conexao
    {
        public string Conex  = "server=localhost; uid=root; pwd=; Database=fiodeouros;";

        public MySqlConnection conection()
        {
            return new MySqlConnection(Conex);
        }
    }
}
