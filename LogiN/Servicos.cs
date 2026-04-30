using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LogiN
{
    public partial class TelaServicos : Form
    {
        public TelaServicos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            TelaPedidos tela = new TelaPedidos();
            tela.Show();
            this.Hide();
        }





        private void lblServicos_Click(object sender, EventArgs e)
        {
            TelaServicos tela = new TelaServicos();
            
            tela.Show();
            this.Close();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }
    }

}
