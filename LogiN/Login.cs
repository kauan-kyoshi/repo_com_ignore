using MySql.Data.MySqlClient;
using System.Web;
namespace LogiN
{
    public partial class Login : System.Windows.Forms.Form
    {
        string conexao = "server=localhost; uid = root; PWd =; Database=fiodeouro;";
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btnEntrar;


        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }





        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;


            if (usuario == "ad" && senha == "123")
            {
                TelaEstoque principal = new TelaEstoque();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }


        private void btnSalvarS_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                con.Open();
                string sql = "INSERT INTO Login_usuário(nome, cpf,senha) VALUES (@nome,@cpf,@senha);";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                cmd.Parameters.AddWithValue("@senha", txtcadastroSenha.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro feito com sucesso, parabéns!");
                con.Close();
            }
            catch (Exception ex)
            {

            }

        }

        private void btncadastraL_Click_1(object sender, EventArgs e)
        {
            PainelUsuario.Visible=true;
        }

        private void btnVoltarS_Click(object sender, EventArgs e)
        {
            PainelUsuario.Visible = false;
        }
    }
}
