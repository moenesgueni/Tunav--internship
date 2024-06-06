using Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class CompteConfigurations : IEntityTypeConfiguration<Compte>
    {
        public void Configure(EntityTypeBuilder<Compte> builder)
        {
         builder.HasOne(f => f.Client)
        .WithMany(p => p.Comptes)
        .HasForeignKey(f => f.ClientFk)
        .IsRequired()
        .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
