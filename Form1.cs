using CadastroVideoGames.DAO;
using CadastroVideoGames.Data;
using CadastroVideoGames.Forms;
using CadastroVideoGames.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroVideoGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Conexao.Conectar();
            MostrarGrid();
        }

        public void dataGridViewVideoGames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void MostrarGrid()
        {
            try
            {
                Conexao.Conectar();
                string sql = "SELECT * FROM VideoGame";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, Conexao.Conectar());
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewVideoGames.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Não foi possivel mostrar nenhum item. " + ex.Message);
            }

        }

        public void dataGridViewVideoGames_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewVideoGames.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewVideoGames.SelectedRows[0];
                txtTitulo.Text = row.Cells["titulo"].Value.ToString();
                txtGenero.Text = row.Cells["genero"].Value.ToString();
                dateTimePickerLancamento.Value = Convert.ToDateTime(row.Cells["dataLancamento"].Value);
                txtPlataforma.Text = row.Cells["plataforma"].Value.ToString();
                txtDesenvolvedor.Text = row.Cells["desenvolvedor"].Value.ToString();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            CadastarEditar tela = new CadastarEditar();
            tela.Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {

            if (dataGridViewVideoGames.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewVideoGames.SelectedRows[0];
                VideoGame selectedGame = new VideoGame
                {
                    id_videogame = Convert.ToInt32(row.Cells["id_videogame"].Value),
                    titulo = row.Cells["titulo"].Value.ToString(),
                    genero = row.Cells["genero"].Value.ToString(),
                    dataLancamento = Convert.ToDateTime(row.Cells["dataLancamento"].Value),
                    plataforma = row.Cells["plataforma"].Value.ToString(),
                    desenvolvedor = row.Cells["desenvolvedor"].Value.ToString()
                };

                
                Editar FormEditar = new Editar(selectedGame);
                FormEditar.ShowDialog();
               
                MostrarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um jogo para atualizar.");
            }

        }

        private void btRecarregar_Click(object sender, EventArgs e)
        {
            MostrarGrid();
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridViewVideoGames.SelectedRows.Count > 0)
            {
                try
                {        
                    int id = Convert.ToInt32(dataGridViewVideoGames.SelectedRows[0].Cells["id_videogame"].Value);

                    DialogResult result = MessageBox.Show("Tem certeza que deseja deletar este jogo?", "Confirmar Deleção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        
                        VideoGameDAO dao = new VideoGameDAO();
                        dao.Deletar(id);

                        MostrarGrid();

                        MessageBox.Show("Jogo deletado com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar o jogo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecione um jogo para deletar.");
            }
        }
    }
}
