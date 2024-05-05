using Final_Task___Winform.Context;
using Final_Task___Winform.Entities;
using Final_Task___Winform.Extensions;
using Final_Task___Winform.models;
using Final_Task___Winform.Repositories.EFRespositories;
using Microsoft.EntityFrameworkCore;
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
    public partial class FormSettings : Form
    {
        private readonly GameRepository _gameRepository;
        private readonly CategoryRepository _categoryRepository;
        private readonly SubtitleRepository _subtitleRepository;
        public FormSettings()
        {
            _gameRepository = new GameRepository();
            _categoryRepository = new CategoryRepository();
            _subtitleRepository = new SubtitleRepository();
            InitializeComponent();

        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            FillDataGrid();
            FillComboBox();
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
                dataGridViewSettings.DataSource = gameList;
            }

        }

        private async void FillComboBox()
        {
            comboBoxCategory.Items.Clear();
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Id";
            comboBoxCategory.DataSource = await _categoryRepository.GetAllAsync();
            comboBoxSubtitle.Items.Clear();
            comboBoxSubtitle.DisplayMember = "Name";
            comboBoxSubtitle.ValueMember = "Id";
            comboBoxSubtitle.DataSource = await _subtitleRepository.GetAllAsync();
        }
        private async void Add_Click(object sender, EventArgs e)
        {
            if (txt_GameName.IsEmpty())

            {
                MessageBox.Show("Form is not valid!");
                return;
            }

            Game game = new()
            {
                Name = txt_GameName.Text,
                Price = txt_Price.ToInt(),
                CategoryId = (int)comboBoxCategory.SelectedValue,
                SubtitleId = (int)comboBoxSubtitle.SelectedValue
            };
            await _gameRepository.Add(game);
            await _gameRepository.SaveChangesAsync();
            MessageBox.Show("Game added!");
            FillDataGrid();
        }


        int i = 0;
        private void dataGridViewSettings_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            i = e.RowIndex;
            txt_GameName.Text = dataGridViewSettings.Rows[i].Cells[1].Value.ToString();
            txt_Price.Text = dataGridViewSettings.Rows[i].Cells[2].Value.ToString();
        }
        private async void Delete_Click(object sender, EventArgs e)
        {



            using (var context = new GameContext())
            {
                int gameIdToDelete = (int)dataGridViewSettings.CurrentRow.Cells["Id"].Value;

                var gameToDelete = await context.Games.FindAsync(gameIdToDelete);

                if (gameToDelete != null)
                {
                    context.Games.Remove(gameToDelete);
                    await context.SaveChangesAsync();

                }
            }

            MessageBox.Show("Game deleted!");
            FillDataGrid();

        }



        private async void Update_Click(object sender, EventArgs e)
        {
            int gameIdToUpdate = (int)dataGridViewSettings.CurrentRow.Cells["Id"].Value;

            using (var context = new GameContext())
            {
                var gameToUpdate = await context.Games.FindAsync(gameIdToUpdate);

                if (gameToUpdate != null)
                {
                    gameToUpdate.Name = txt_GameName.Text;
                    gameToUpdate.Price = txt_Price.ToInt();
                    gameToUpdate.CategoryId = (int)comboBoxCategory.SelectedValue;
                    gameToUpdate.SubtitleId = (int)comboBoxSubtitle.SelectedValue;

                    await context.SaveChangesAsync();
                }
            }

            MessageBox.Show("Game updated!");
            FillDataGrid();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewSettings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_GameName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
