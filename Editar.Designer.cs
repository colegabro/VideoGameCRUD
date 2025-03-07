namespace CadastroVideoGames.Forms
{
    partial class Editar
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
            this.lbEdicao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // lbEdicao
            // 
            this.lbEdicao.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdicao.Location = new System.Drawing.Point(95, 41);
            this.lbEdicao.Name = "lbEdicao";
            this.lbEdicao.Size = new System.Drawing.Size(282, 26);
            this.lbEdicao.TabIndex = 6;
            this.lbEdicao.Text = "EDITAR DE INFORMAÇÕES";
            this.lbEdicao.Click += new System.EventHandler(this.lbEdicao_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(343, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 31);
            this.button1.TabIndex = 24;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.SeaGreen;
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(226, 407);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(111, 31);
            this.btSalvar.TabIndex = 23;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // dateTimePickerLancamento
            // 
            this.dateTimePickerLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerLancamento.Location = new System.Drawing.Point(12, 310);
            this.dateTimePickerLancamento.Name = "dateTimePickerLancamento";
            this.dateTimePickerLancamento.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerLancamento.TabIndex = 34;
            // 
            // txtDesenvolvedor
            // 
            this.txtDesenvolvedor.Location = new System.Drawing.Point(284, 233);
            this.txtDesenvolvedor.Name = "txtDesenvolvedor";
            this.txtDesenvolvedor.Size = new System.Drawing.Size(170, 20);
            this.txtDesenvolvedor.TabIndex = 33;
            // 
            // txtPlataforma
            // 
            this.txtPlataforma.Location = new System.Drawing.Point(284, 156);
            this.txtPlataforma.Name = "txtPlataforma";
            this.txtPlataforma.Size = new System.Drawing.Size(170, 20);
            this.txtPlataforma.TabIndex = 32;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(12, 233);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(170, 20);
            this.txtGenero.TabIndex = 31;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(12, 156);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(170, 20);
            this.txtTitulo.TabIndex = 30;
            // 
            // lbDesenvolvedor
            // 
            this.lbDesenvolvedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesenvolvedor.Location = new System.Drawing.Point(280, 204);
            this.lbDesenvolvedor.Name = "lbDesenvolvedor";
            this.lbDesenvolvedor.Size = new System.Drawing.Size(145, 26);
            this.lbDesenvolvedor.TabIndex = 29;
            this.lbDesenvolvedor.Text = "Desenvolvedor:";
            // 
            // lbPlataforma
            // 
            this.lbPlataforma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlataforma.Location = new System.Drawing.Point(280, 127);
            this.lbPlataforma.Name = "lbPlataforma";
            this.lbPlataforma.Size = new System.Drawing.Size(119, 26);
            this.lbPlataforma.TabIndex = 28;
            this.lbPlataforma.Text = "Plataforma:";
            // 
            // lbDataLancamento
            // 
            this.lbDataLancamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataLancamento.Location = new System.Drawing.Point(8, 281);
            this.lbDataLancamento.Name = "lbDataLancamento";
            this.lbDataLancamento.Size = new System.Drawing.Size(174, 26);
            this.lbDataLancamento.TabIndex = 27;
            this.lbDataLancamento.Text = "Data de Lançamento:";
            // 
            // lbGenero
            // 
            this.lbGenero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenero.Location = new System.Drawing.Point(8, 204);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(73, 26);
            this.lbGenero.TabIndex = 26;
            this.lbGenero.Text = "Gênero:";
            // 
            // lbTitulo
            // 
            this.lbTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(8, 127);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(73, 26);
            this.lbTitulo.TabIndex = 25;
            this.lbTitulo.Text = "Título:";
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(474, 450);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.lbEdicao);
            this.Name = "Editar";
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.Editar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEdicao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSalvar;
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
    }
}