using Final_Task___Winform.Context;
using Final_Task___Winform.Entities;
using Final_Task___Winform.models;
using Final_Task___Winform.Repositories.EFRespositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Task___Winform.Forms
{
    public partial class FormGames : Form
    {
        private readonly GameRepository _gameRepository;
        public FormGames()
        {
            _gameRepository = new GameRepository();
            InitializeComponent();
        }
        private async Task FillDataGrid()
        {
            using (GameContext context = new GameContext())
            {
                IEnumerable<Game> games = await _gameRepository.GetAllAsync();
                List<GameModel> gameList = new List<GameModel>();
                var gameFromDb = context.Games.Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    CategoryId = x.CategoryId,
                    SubtitleId = x.SubtitleId
                }).ToList();

                foreach (var game in gameFromDb)
                {
                    GameModel gameModel = new()
                    {
                        Id = game.Id,
                        Name = game.Name,
                        Price = game.Price,
                        CategoryId = game.CategoryId,
                        SubtitleId = game.SubtitleId
                    };
                    gameList.Add(gameModel);
                }
                dataGridViewGames.DataSource = gameList;
            }
        }


        private void FormGames_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }
        private void dataGridViewGames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

