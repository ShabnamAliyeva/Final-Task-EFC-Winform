using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task___Winform.Entities
{
        public class Game
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public int CategoryId { get; set; }
            public Category Category { get; set; }
            public int SubtitleId { get; set; }
            public Subtitle Subtitle { get; set; }
        }
}
