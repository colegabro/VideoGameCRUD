using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVideoGames.Data
{
    internal static class Conexao
    {
        static MySqlConnection _conexao;
        static string strconexao = "server=localhost;Port=3306;uid=root;pwd=root;database=cadastrovideogame";

        public static MySqlConnection Conectar()
        {
            try
            {
                _conexao = new MySqlConnection(strconexao);
                _conexao.Open();
                Console.WriteLine("Conexão realisada com sucesso");
                return _conexao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar" + ex.Message);
            }
        }
    }
}
