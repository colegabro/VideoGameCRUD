using CadastroVideoGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVideoGames.Interface
{
    internal interface IDAO
    {
        void Salvar(VideoGame videoGame);

        void Deletar(int id);

        void Atualizar(VideoGame videoGame);

        List<VideoGame> ListarTodos();
    }
}
