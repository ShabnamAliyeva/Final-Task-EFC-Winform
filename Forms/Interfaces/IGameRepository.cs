using Final_Task___Winform.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task___Winform.Interfaces
{
    internal interface IGameRepository
    {
        Task Add(Game game);
        Task Update(Game game);
        Task Remove(Game game);
        Task<IEnumerable<Game>> GetGames();
    }
}
