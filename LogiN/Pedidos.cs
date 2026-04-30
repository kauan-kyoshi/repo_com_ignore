using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogiN
{
    public partial class TelaPedidos : Form
    {
        public TelaPedidos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TelaEstoque tela = new TelaEstoque();
            tela.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaServicos tela = new TelaServicos();
            tela.Show();
            this.Hide();
        }


        private void lblPedidos_Click(object sender, EventArgs e)
        {
            TelaPedidos tela = new TelaPedidos();
            tela.StartPosition = FormStartPosition.CenterScreen;
            tela.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaCadastro tela = new TelaCadastro();
            tela.Show();
            this.Hide();
        }
    }
}
