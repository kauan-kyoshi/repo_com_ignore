namespace Adicionar
{
    public partial class FormAdicionar : Form
    {
        public string Nome { get; private set; }
        public string Quantidade { get; private set; }
        public string Categoria { get; private set; }

        public FormAdicionar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Nome = txtNome.Text;
            Quantidade = txtQuantidade.Text;
            Categoria = txtCategoria.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
    }
}
