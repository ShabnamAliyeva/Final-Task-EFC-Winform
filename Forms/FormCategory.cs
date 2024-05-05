using Final_Task___Winform.Context;
using Final_Task___Winform.Entities;
using Final_Task___Winform.Interfaces;
using Final_Task___Winform.models;
using Final_Task___Winform.Models;
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
    public partial class FormCategory : Form
    {
        private readonly CategoryRepository _categoryRepository;
        public FormCategory()
        {
            _categoryRepository = new CategoryRepository();
            InitializeComponent();
        }
        private async Task FillDataGridAsync()
        {
            using (GameContext context = new GameContext())
            {
                IEnumerable<Category> categories = await _categoryRepository.GetAllAsync();
                List<CategoryModel> categoryList = new List<CategoryModel>();
                var categoryFromDb = context.Categories.Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();

                foreach (var category in categoryFromDb)
                {
                    CategoryModel categoryModel = new()
                    {
                        Id = category.Id,
                        Name = category.Name,
                    };
                    categoryList.Add(categoryModel);
                }
                dataGridViewCategory.DataSource = categoryList;

            }
        }
        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            FillDataGridAsync();
        }
    }
}
