namespace TelaPrincipal
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnRelatorios = new Button();
            btnServicos = new Button();
            btnClientes = new Button();
            btnEstoque = new Button();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txtBusca = new TextBox();
            btnAdicionar = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnRelatorios);
            panel1.Controls.Add(btnServicos);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(btnEstoque);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 826);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            label1.Location = new Point(47, 165);
            label1.Name = "label1";
            label1.Size = new Size(253, 26);
            label1.TabIndex = 5;
            label1.Text = "Bem-vinda ao Sistema";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnRelatorios
            // 
            btnRelatorios.BackColor = Color.WhiteSmoke;
            btnRelatorios.FlatAppearance.BorderSize = 0;
            btnRelatorios.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnRelatorios.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnRelatorios.FlatStyle = FlatStyle.Flat;
            btnRelatorios.Font = new Font("Century Gothic", 12F);
            btnRelatorios.Image = (Image)resources.GetObject("btnRelatorios.Image");
            btnRelatorios.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelatorios.Location = new Point(26, 638);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(291, 64);
            btnRelatorios.TabIndex = 3;
            btnRelatorios.Text = "Relatórios";
            btnRelatorios.UseVisualStyleBackColor = false;
            // 
            // btnServicos
            // 
            btnServicos.BackColor = Color.WhiteSmoke;
            btnServicos.FlatAppearance.BorderSize = 0;
            btnServicos.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnServicos.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnServicos.FlatStyle = FlatStyle.Flat;
            btnServicos.Font = new Font("Century Gothic", 12F);
            btnServicos.Image = (Image)resources.GetObject("btnServicos.Image");
            btnServicos.ImageAlign = ContentAlignment.MiddleLeft;
            btnServicos.Location = new Point(26, 526);
            btnServicos.Name = "btnServicos";
            btnServicos.Size = new Size(291, 64);
            btnServicos.TabIndex = 2;
            btnServicos.Text = "Serviços";
            btnServicos.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.WhiteSmoke;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Century Gothic", 12F);
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(26, 416);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(291, 64);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnEstoque
            // 
            btnEstoque.FlatAppearance.BorderSize = 0;
            btnEstoque.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnEstoque.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.Font = new Font("Century Gothic", 12F);
            btnEstoque.ForeColor = Color.Black;
            btnEstoque.Image = (Image)resources.GetObject("btnEstoque.Image");
            btnEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstoque.Location = new Point(26, 306);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(291, 64);
            btnEstoque.TabIndex = 0;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            label2.Location = new Point(401, 22);
            label2.Name = "label2";
            label2.Size = new Size(278, 32);
            label2.TabIndex = 6;
            label2.Text = "Controle de Estoque";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F);
            label3.Location = new Point(401, 63);
            label3.Name = "label3";
            label3.Size = new Size(327, 21);
            label3.TabIndex = 7;
            label3.Text = "Gerencie seus materiais e aviamentos";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtBusca);
            panel2.Location = new Point(392, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(1044, 63);
            panel2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 39);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // txtBusca
            // 
            txtBusca.BackColor = Color.White;
            txtBusca.Location = new Point(59, 11);
            txtBusca.Multiline = true;
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(979, 39);
            txtBusca.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(191, 165, 187);
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnAdicionar.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Century Gothic", 12F);
            btnAdicionar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionar.Location = new Point(1221, 63);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(215, 49);
            btnAdicionar.TabIndex = 9;
            btnAdicionar.Text = "+ Adicionar Item";
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumAquamarine;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(401, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1026, 548);
            dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nome";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Quantidade";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Categoria";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1428, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 34);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // ucCadastro2
            // 
            ucCadastro2.BackColor = Color.WhiteSmoke;
            ucCadastro2.Location = new Point(333, 0);
            ucCadastro2.Name = "ucCadastro2";
            ucCadastro2.Size = new Size(1438, 1091);
            ucCadastro2.TabIndex = 14;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1475, 826);
            Controls.Add(ucCadastro2);
            Controls.Add(btnAdicionar);
            Controls.Add(pictureBox3);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FormPrincipal";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnEstoque;
        private Button btnRelatorios;
        private Button btnServicos;
        private Button btnClientes;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private TextBox txtBusca;
        private Button btnAdicionar;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private PictureBox pictureBox3;
        private ucCadastro ucCadastro1;
        private ucCadastro ucCadastro;
        private ucCadastro ucCadastro2;
    }
}
