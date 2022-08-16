using IBVL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Data.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {

            builder.HasKey(e => e.Id);

            builder.Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(u => u.Email).IsUnique();
            builder.Property(u => u.Email)
                .IsRequired();


            builder.Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(8);
            builder.Ignore(u => u.Membro);
                   
        }
    }
}
