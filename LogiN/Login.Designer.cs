namespace LogiN
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox2 = new PictureBox();
            label1 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            txtSenha = new TextBox();
            label3 = new Label();
            btnEntrar = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(568, 25);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(237, 137);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(543, 242);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(543, 260);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(290, 26);
            txtUsuario.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(640, 200);
            label2.Name = "label2";
            label2.Size = new Size(87, 19);
            label2.TabIndex = 4;
            label2.Text = "Bem vinda!";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(543, 341);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(290, 26);
            txtSenha.TabIndex = 6;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(543, 323);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 5;
            label3.Text = "Senha";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(625, 422);
            btnEntrar.Margin = new Padding(3, 2, 3, 2);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(126, 28);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 8F);
            label4.Location = new Point(820, 540);
            label4.Name = "label4";
            label4.Size = new Size(89, 16);
            label4.TabIndex = 8;
            label4.Text = "by  ASTER TECH";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, -5);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(466, 576);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(917, 561);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtSenha;
        private Label label3;
        private Button btnEntrar;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
