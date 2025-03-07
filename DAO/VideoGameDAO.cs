using CadastroVideoGames.Data;
using CadastroVideoGames.Interface;
using CadastroVideoGames.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CadastroVideoGames.DAO
{
    internal class VideoGameDAO : IDAO
    {
        public void Salvar(VideoGame videoGame)
        {
            try
            {
                string sql = "INSERT INTO VideoGame (titulo, genero, dataLancamento, plataforma, desenvolvedor) " +
                    "VALUES (@titulo, @genero, @dataLancamento, @plataforma, @desenvolvedor)";

                MySqlCommand command = new MySqlCommand(sql, Conexao.Conectar());
                command.Parameters.AddWithValue("@titulo", videoGame.titulo);
                command.Parameters.AddWithValue("@genero", videoGame.genero);
                command.Parameters.AddWithValue("@dataLancamento", videoGame.dataLancamento);
                command.Parameters.AddWithValue("@plataforma", videoGame.plataforma);
                command.Parameters.AddWithValue("@desenvolvedor", videoGame.desenvolvedor);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex.Message);
            }


        }

        public void Deletar(int id)
        {
            try
            {
                string sql = "DELETE FROM VideoGame WHERE " + "id_videogame = @id_videogame";
                MySqlCommand command = new MySqlCommand(sql, Conexao.Conectar());
                command.Parameters.AddWithValue("@id_videogame", id);

                command.ExecuteNonQuery();              
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar jogo." + ex.Message);
            }
        }

        public void Atualizar(VideoGame videoGame)
        {
            try
            {
                string sql = "UPDATE VideoGame SET titulo = @titulo, genero = @genero, dataLancamento = @dataLancamento, " +
                "plataforma = @plataforma, desenvolvedor = @desenvolvedor WHERE id_videogame = @id_videogame";

                Conexao.Conectar();
                MySqlCommand command = new MySqlCommand(sql, Conexao.Conectar());
                command.Parameters.AddWithValue("@titulo", videoGame.titulo);
                command.Parameters.AddWithValue("@genero", videoGame.genero);
                command.Parameters.AddWithValue("@dataLancamento", videoGame.dataLancamento);
                command.Parameters.AddWithValue("@plataforma", videoGame.plataforma);
                command.Parameters.AddWithValue("@desenvolvedor", videoGame.desenvolvedor);
                command.Parameters.AddWithValue("@id_videogame", videoGame.id_videogame);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
            finally
            {
                // Pra ter certeza de que a conexão foi fechada
                if (Conexao.Conectar().State == ConnectionState.Open)
                {
                    Conexao.Conectar().Close();
                }
            }
        }

        public List<VideoGame> ListarTodos()
        {
            List<VideoGame> videoGames = new List<VideoGame>();

            try
            {

                Conexao.Conectar();
                    string sql = "SELECT * FROM VideoGame";
                    using (MySqlCommand command = new MySqlCommand(sql, Conexao.Conectar()))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                VideoGame game = new VideoGame
                                {
                                    id_videogame = reader.GetInt32("id_videogame"),
                                    titulo = reader.GetString("titulo"),
                                    genero = reader.GetString("genero"),
                                    dataLancamento = reader.GetDateTime("dataLancamento"),
                                    plataforma = reader.GetString("plataforma"),
                                    desenvolvedor = reader.GetString("desenvolvedor")
                                };
                                videoGames.Add(game);
                            }
                        }
                    }
                
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar jogos: " + ex.Message);
            }

            return videoGames;
        }
    }

}

