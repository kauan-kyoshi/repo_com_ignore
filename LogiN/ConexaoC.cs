using MySql.Data.MySqlClient;

namespace LogiN
{
    public class ConexaoC
    {
        private string connectionString = "server=localhost;database=Projeto;uid=root;pwd=;";

        public MySqlConnection Conectar()
        {
            return new MySqlConnection(connectionString);
        }
    }
}