using Final_Task___Winform.Entities;
using Final_Task___Winform.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final_Task___Winform.Repositories.EFRespositories
{
    internal class GameRepository : GenericRepository<Game>,
        IGameRepository

    {
        public Task<IEnumerable<Game>> GetGames()
        {
            throw new NotImplementedException();
        }

        Task IGameRepository.Remove(Game game)
        {
            throw new NotImplementedException();
        }

        Task IGameRepository.Update(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
