namespace CadastroVideoGames
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.dataGridViewVideoGames = new System.Windows.Forms.DataGridView();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.lbCadastroVideoGames = new System.Windows.Forms.Label();
            this.dateTimePickerLancamento = new System.Windows.Forms.DateTimePicker();
            this.txtDesenvolvedor = new System.Windows.Forms.TextBox();
            this.txtPlataforma = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lbDesenvolvedor = new System.Windows.Forms.Label();
            this.lbPlataforma = new System.Windows.Forms.Label();
            this.lbDataLancamento = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btRecarregar = new System.Windows.Forms.Button();
            this.id_videogame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desenvolvedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVideoGames)).BeginInit();
            this.SuspendLayout();
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // dataGridViewVideoGames
            // 
            this.dataGridViewVideoGames.AllowUserToAddRows = false;
            this.dataGridViewVideoGames.AllowUserToOrderColumns = true;
            this.dataGridViewVideoGames.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewVideoGames.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewVideoGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVideoGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_videogame,
            this.titulo,
            this.genero,
            this.dataLancamento,
            this.plataforma,
            this.desenvolvedor});
            this.dataGridViewVideoGames.Location = new System.Drawing.Point(12, 120);
            this.dataGridViewVideoGames.Name = "dataGridViewVideoGames";
            this.dataGridViewVideoGames.Size = new System.Drawing.Size(573, 318);
            this.dataGridViewVideoGames.TabIndex = 0;
            this.dataGridViewVideoGames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVideoGames_CellContentClick);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Orange;
            this.btCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(613, 120);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(149, 34);
            this.btCadastrar.TabIndex = 1;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.Orange;
            this.btEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEditar.Location = new System.Drawing.Point(613, 160);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(149, 34);
            this.btEditar.TabIndex = 2;
            this.btEditar.Text = "EDITAR";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.BackColor = System.Drawing.Color.Orange;
            this.btDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDeletar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDeletar.Location = new System.Drawing.Point(613, 200);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(149, 34);
            this.btDeletar.TabIndex = 3;
            this.btDeletar.Text = "DELETAR";
            this.btDeletar.UseVisualStyleBackColor = false;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // lbCadastroVideoGames
            // 
            this.lbCadastroVideoGames.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroVideoGames.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCadastroVideoGames.Location = new System.Drawing.Point(12, 28);
            this.lbCadastroVideoGames.Name = "lbCadastroVideoGames";
            this.lbCadastroVideoGames.Size = new System.Drawing.Size(743, 46);
            this.lbCadastroVideoGames.TabIndex = 4;
            this.lbCadastroVideoGames.Text = "GERENCIAR JOGOS";
            this.lbCadastroVideoGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerLancamento
            // 
            this.dateTimePickerLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerLancamento.Location = new System.Drawing.Point(19, 372);
            this.dateTimePickerLancamento.Name = "dateTimePickerLancamento";
            this.dateTimePickerLancamento.Size = new System.Drawing.Size(60, 20);
            this.dateTimePickerLancamento.TabIndex = 23;
            // 
            // txtDesenvolvedor
            // 
            this.txtDesenvolvedor.Location = new System.Drawing.Point(428, 295);
            this.txtDesenvolvedor.Name = "txtDesenvolvedor";
            this.txtDesenvolvedor.Size = new System.Drawing.Size(129, 20);
            this.txtDesenvolvedor.TabIndex = 22;
            // 
            // txtPlataforma
            // 
            this.txtPlataforma.Location = new System.Drawing.Point(428, 218);
            this.txtPlataforma.Name = "txtPlataforma";
            this.txtPlataforma.Size = new System.Drawing.Size(129, 20);
            this.txtPlataforma.TabIndex = 21;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(19, 295);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(129, 20);
            this.txtGenero.TabIndex = 20;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(19, 218);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(129, 20);
            this.txtTitulo.TabIndex = 19;
            // 
            // lbDesenvolvedor
            // 
            this.lbDesenvolvedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesenvolvedor.Location = new System.Drawing.Point(424, 266);
            this.lbDesenvolvedor.Name = "lbDesenvolvedor";
            this.lbDesenvolvedor.Size = new System.Drawing.Size(104, 26);
            this.lbDesenvolvedor.TabIndex = 18;
            this.lbDesenvolvedor.Text = "Desenvolvedor:";
            // 
            // lbPlataforma
            // 
            this.lbPlataforma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlataforma.Location = new System.Drawing.Point(424, 189);
            this.lbPlataforma.Name = "lbPlataforma";
            this.lbPlataforma.Size = new System.Drawing.Size(78, 26);
            this.lbPlataforma.TabIndex = 17;
            this.lbPlataforma.Text = "Plataforma:";
            // 
            // lbDataLancamento
            // 
            this.lbDataLancamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataLancamento.Location = new System.Drawing.Point(15, 343);
            this.lbDataLancamento.Name = "lbDataLancamento";
            this.lbDataLancamento.Size = new System.Drawing.Size(133, 26);
            this.lbDataLancamento.TabIndex = 16;
            this.lbDataLancamento.Text = "Data de Lançamento:";
            // 
            // lbGenero
            // 
            this.lbGenero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenero.Location = new System.Drawing.Point(15, 266);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(32, 26);
            this.lbGenero.TabIndex = 15;
            this.lbGenero.Text = "Gênero:";
            // 
            // lbTitulo
            // 
            this.lbTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(15, 189);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(32, 26);
            this.lbTitulo.TabIndex = 14;
            this.lbTitulo.Text = "Título:";
            // 
            // btRecarregar
            // 
            this.btRecarregar.BackColor = System.Drawing.Color.LightGreen;
            this.btRecarregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRecarregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRecarregar.Location = new System.Drawing.Point(613, 379);
            this.btRecarregar.Name = "btRecarregar";
            this.btRecarregar.Size = new System.Drawing.Size(149, 59);
            this.btRecarregar.TabIndex = 24;
            this.btRecarregar.Text = "RECARREGAR TABELA";
            this.btRecarregar.UseVisualStyleBackColor = false;
            this.btRecarregar.Click += new System.EventHandler(this.btRecarregar_Click);
            // 
            // id_videogame
            // 
            this.id_videogame.DataPropertyName = "id_videogame";
            this.id_videogame.HeaderText = "ID";
            this.id_videogame.Name = "id_videogame";
            this.id_videogame.Width = 30;
            // 
            // titulo
            // 
            this.titulo.DataPropertyName = "titulo";
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            // 
            // genero
            // 
            this.genero.DataPropertyName = "genero";
            this.genero.HeaderText = "Gênero";
            this.genero.Name = "genero";
            // 
            // dataLancamento
            // 
            this.dataLancamento.DataPropertyName = "dataLancamento";
            this.dataLancamento.HeaderText = "Data de Lançamento";
            this.dataLancamento.Name = "dataLancamento";
            // 
            // plataforma
            // 
            this.plataforma.DataPropertyName = "plataforma";
            this.plataforma.HeaderText = "Plataforma";
            this.plataforma.Name = "plataforma";
            // 
            // desenvolvedor
            // 
            this.desenvolvedor.DataPropertyName = "desenvolvedor";
            this.desenvolvedor.HeaderText = "Desenvolvedor";
            this.desenvolvedor.Name = "desenvolvedor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.btRecarregar);
            this.Controls.Add(this.lbCadastroVideoGames);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.dataGridViewVideoGames);
            this.Controls.Add(this.dateTimePickerLancamento);
            this.Controls.Add(this.txtDesenvolvedor);
            this.Controls.Add(this.txtPlataforma);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lbDesenvolvedor);
            this.Controls.Add(this.lbPlataforma);
            this.Controls.Add(this.lbDataLancamento);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.lbTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVideoGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewVideoGames;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Label lbCadastroVideoGames;
        private System.Windows.Forms.DateTimePicker dateTimePickerLancamento;
        private System.Windows.Forms.TextBox txtDesenvolvedor;
        private System.Windows.Forms.TextBox txtPlataforma;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lbDesenvolvedor;
        private System.Windows.Forms.Label lbPlataforma;
        private System.Windows.Forms.Label lbDataLancamento;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btRecarregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_videogame;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn plataforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn desenvolvedor;
    }
}

