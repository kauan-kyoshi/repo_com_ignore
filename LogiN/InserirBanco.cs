using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogiN
{
    internal class InserirBanco
    {
        public void Inserir(string nome, string telefone, string cpf)
        {


            Conexao conec = new Conexao();
            MySqlConnection con = conec.conection();

            try
            {
                con.Open();
                string sql = "INSERT INTO Itens (nome, telefone, cpf ) VALUES (@nome, @telefone, @cpf)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@cpf", cpf);

                cmd.ExecuteNonQuery();
                     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }

            Listar();
        }

        public DataTable Listar()
        {
            Conexao conec = new Conexao();
            MySqlConnection con = conec.conection();
            string sqlSelect = "SELECT * FROM Clientes";
            MySqlDataAdapter da = new MySqlDataAdapter(sqlSelect, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
