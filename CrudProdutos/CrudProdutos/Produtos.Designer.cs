namespace CrudProdutos
{
    partial class Produtos
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
            dgProdutos = new DataGridView();
            label1 = new Label();
            txtId = new TextBox();
            txtCodigo = new TextBox();
            label2 = new Label();
            txtTipo = new TextBox();
            label3 = new Label();
            txtNome = new TextBox();
            label4 = new Label();
            btnAdiconar = new Button();
            btnExcluir = new Button();
            btnAlterar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProdutos).BeginInit();
            SuspendLayout();
            // 
            // dgProdutos
            // 
            dgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProdutos.Location = new Point(1, -1);
            dgProdutos.Name = "dgProdutos";
            dgProdutos.RowTemplate.Height = 25;
            dgProdutos.Size = new Size(424, 504);
            dgProdutos.TabIndex = 0;
            dgProdutos.CellClick += dgProdutos_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(431, 23);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(434, 45);
            txtId.Name = "txtId";
            txtId.Size = new Size(176, 23);
            txtId.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(647, 117);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(176, 23);
            txtCodigo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(644, 90);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Código";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(431, 117);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(176, 23);
            txtTipo.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(431, 90);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 5;
            label3.Text = "Tipo";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(647, 45);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(176, 23);
            txtNome.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(644, 23);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "Nome";
            // 
            // btnAdiconar
            // 
            btnAdiconar.Location = new Point(497, 178);
            btnAdiconar.Name = "btnAdiconar";
            btnAdiconar.Size = new Size(75, 23);
            btnAdiconar.TabIndex = 9;
            btnAdiconar.Text = "Adicionar";
            btnAdiconar.UseVisualStyleBackColor = true;
            btnAdiconar.Click += btnAdiconar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(682, 178);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(591, 178);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 11;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click_1;
            // 
            // Produtos
            // 
            ClientSize = new Size(854, 503);
            Controls.Add(btnAlterar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAdiconar);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(txtTipo);
            Controls.Add(label3);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dgProdutos);
            Name = "Produtos";
            Text = "Produtos";
            Load += Produtos_Load;
            ((System.ComponentModel.ISupportInitialize)dgProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private DataGridView dgProdutos;
        private Label label1;
        private TextBox txtId;
        private TextBox txtCodigo;
        private Label label2;
        private TextBox txtTipo;
        private Label label3;
        private TextBox txtNome;
        private Label label4;
        private Button btnAdiconar;
        private Button btnExcluir;
        private Button btnAlterar;
    }
}