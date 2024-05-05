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
    public class AdminConfig : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.AdminName)
               .IsRequired()
               .HasMaxLength(200)
               .HasColumnType("nvarchar");

            builder.Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("nvarchar");
        }
    }
}
