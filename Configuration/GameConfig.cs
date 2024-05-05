using Final_Task___Winform.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task___Winform.Configuration
{
    public class GameConfig : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
               .IsRequired()
               .HasMaxLength(100)
               .HasColumnType("nvarchar");

            builder.Property(x => x.Price)
                .IsRequired();
                

         

        }
    }
}
