using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistence.Configurations
{
    public class MotorbikeConfiguration : IEntityTypeConfiguration<Motorbike>
    {
        public void Configure(EntityTypeBuilder<Motorbike> builder)
        {
            builder.ToTable("Motorbikes");
            builder.HasKey(m => m.Id);
            builder.HasIndex(p => p.Brand);  // performanıs arttırır
            builder.Property(p=>p.Price).HasColumnType("money");

        }
    }
}
