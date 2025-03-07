using CadastroVideoGames.DAO;
using CadastroVideoGames.Models;
using System;
using System.Windows.Forms;

namespace CadastroVideoGames.Forms
{
    public partial class Editar : Form
    {
        private VideoGame _videoGame;
        public Editar(VideoGame videoGame)
        {
            InitializeComponent();
            _videoGame = videoGame;

            txtTitulo.Text = _videoGame.titulo;
            txtGenero.Text = _videoGame.genero;
            dateTimePickerLancamento.Value = _videoGame.dataLancamento;
            txtPlataforma.Text = _videoGame.plataforma;
            txtDesenvolvedor.Text = _videoGame.desenvolvedor;
        }



        private void lbEdicao_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                    string.IsNullOrWhiteSpace(txtGenero.Text) ||
                    string.IsNullOrWhiteSpace(txtPlataforma.Text) ||
                    string.IsNullOrWhiteSpace(txtDesenvolvedor.Text))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _videoGame.titulo = txtTitulo.Text;
                _videoGame.genero = txtGenero.Text;
                _videoGame.dataLancamento = dateTimePickerLancamento.Value;
                _videoGame.plataforma = txtPlataforma.Text;
                _videoGame.desenvolvedor = txtDesenvolvedor.Text;

                VideoGameDAO gameDAO = new VideoGameDAO();
                gameDAO.Atualizar(_videoGame);

                MessageBox.Show("Jogo atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o jogo: " + ex.Message);
            }

        }

        private void Editar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
    }
}
