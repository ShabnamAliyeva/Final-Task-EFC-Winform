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
    public class SubtitleConfig : IEntityTypeConfiguration<Subtitle>
    {
        public void Configure(EntityTypeBuilder<Subtitle> builder)
        {
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(50)
                   .HasColumnType("nvarchar");

            builder.HasKey(x => x.Id);
                
            builder.HasMany(x => x.Games)
              .WithOne(x => x.Subtitle)
              .HasForeignKey(x => x.SubtitleId);
        }
    }
}
