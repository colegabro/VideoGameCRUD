namespace CadastroVideoGames.Forms
{
    partial class CadastarEditar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.lbDataLancamento = new System.Windows.Forms.Label();
            this.lbPlataforma = new System.Windows.Forms.Label();
            this.lbDesenvolvedor = new System.Windows.Forms.Label();
            this.lbCadastro = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtPlataforma = new System.Windows.Forms.TextBox();
            this.txtDesenvolvedor = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.dateTimePickerLancamento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(12, 121);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(73, 26);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Título:";
            // 
            // lbGenero
            // 
            this.lbGenero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenero.Location = new System.Drawing.Point(12, 198);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(73, 26);
            this.lbGenero.TabIndex = 1;
            this.lbGenero.Text = "Gênero:";
            // 
            // lbDataLancamento
            // 
            this.lbDataLancamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataLancamento.Location = new System.Drawing.Point(12, 275);
            this.lbDataLancamento.Name = "lbDataLancamento";
            this.lbDataLancamento.Size = new System.Drawing.Size(174, 26);
            this.lbDataLancamento.TabIndex = 2;
            this.lbDataLancamento.Text = "Data de Lançamento:";
            // 
            // lbPlataforma
            // 
            this.lbPlataforma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlataforma.Location = new System.Drawing.Point(297, 121);
            this.lbPlataforma.Name = "lbPlataforma";
            this.lbPlataforma.Size = new System.Drawing.Size(119, 26);
            this.lbPlataforma.TabIndex = 3;
            this.lbPlataforma.Text = "Plataforma:";
            // 
            // lbDesenvolvedor
            // 
            this.lbDesenvolvedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesenvolvedor.Location = new System.Drawing.Point(297, 198);
            this.lbDesenvolvedor.Name = "lbDesenvolvedor";
            this.lbDesenvolvedor.Size = new System.Drawing.Size(145, 26);
            this.lbDesenvolvedor.TabIndex = 4;
            this.lbDesenvolvedor.Text = "Desenvolvedor:";
            // 
            // lbCadastro
            // 
            this.lbCadastro.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastro.Location = new System.Drawing.Point(142, 35);
            this.lbCadastro.Name = "lbCadastro";
            this.lbCadastro.Size = new System.Drawing.Size(212, 26);
            this.lbCadastro.TabIndex = 5;
            this.lbCadastro.Text = "CADASTRAR JOGO";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(16, 150);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(170, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(16, 227);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(170, 20);
            this.txtGenero.TabIndex = 7;
            // 
            // txtPlataforma
            // 
            this.txtPlataforma.Location = new System.Drawing.Point(301, 150);
            this.txtPlataforma.Name = "txtPlataforma";
            this.txtPlataforma.Size = new System.Drawing.Size(170, 20);
            this.txtPlataforma.TabIndex = 9;
            // 
            // txtDesenvolvedor
            // 
            this.txtDesenvolvedor.Location = new System.Drawing.Point(301, 227);
            this.txtDesenvolvedor.Name = "txtDesenvolvedor";
            this.txtDesenvolvedor.Size = new System.Drawing.Size(170, 20);
            this.txtDesenvolvedor.TabIndex = 10;
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.SeaGreen;
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(243, 390);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(111, 31);
            this.btSalvar.TabIndex = 11;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Red;
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(360, 390);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(111, 31);
            this.btCancelar.TabIndex = 12;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // dateTimePickerLancamento
            // 
            this.dateTimePickerLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerLancamento.Location = new System.Drawing.Point(16, 304);
            this.dateTimePickerLancamento.Name = "dateTimePickerLancamento";
            this.dateTimePickerLancamento.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerLancamento.TabIndex = 13;
            // 
            // CadastarEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.dateTimePickerLancamento);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtDesenvolvedor);
            this.Controls.Add(this.txtPlataforma);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lbCadastro);
            this.Controls.Add(this.lbDesenvolvedor);
            this.Controls.Add(this.lbPlataforma);
            this.Controls.Add(this.lbDataLancamento);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.lbTitulo);
            this.Name = "CadastarEditar";
            this.Text = "CadastarEditar";
            this.Load += new System.EventHandler(this.CadastarEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Label lbDataLancamento;
        private System.Windows.Forms.Label lbPlataforma;
        private System.Windows.Forms.Label lbDesenvolvedor;
        private System.Windows.Forms.Label lbCadastro;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtPlataforma;
        private System.Windows.Forms.TextBox txtDesenvolvedor;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.DateTimePicker dateTimePickerLancamento;
    }
}