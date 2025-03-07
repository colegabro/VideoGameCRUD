using CadastroVideoGames.DAO;
using CadastroVideoGames.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroVideoGames.Forms
{
    public partial class CadastarEditar : Form
    {
        public CadastarEditar()
        {
            InitializeComponent();
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

                VideoGame videoGame = new VideoGame
                {
                    titulo = txtTitulo.Text,
                    genero = txtGenero.Text,
                    dataLancamento = dateTimePickerLancamento.Value,
                    plataforma = txtPlataforma.Text,
                    desenvolvedor = txtDesenvolvedor.Text
                };

                VideoGameDAO videoGameDAO = new VideoGameDAO();
                videoGameDAO.Salvar(videoGame);

                

                txtTitulo.Clear();
                txtGenero.Clear();
                dateTimePickerLancamento.Value = DateTime.Now;
                txtPlataforma.Clear();
                txtDesenvolvedor.Clear();

                MessageBox.Show("Jogo criado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o jogo: " + ex.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastarEditar_Load(object sender, EventArgs e)
        {

        }
    }
}
