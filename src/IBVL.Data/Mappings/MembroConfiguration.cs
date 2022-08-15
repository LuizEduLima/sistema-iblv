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
    public class MembroConfiguration : IEntityTypeConfiguration<Membro>
    {
        public void Configure(EntityTypeBuilder<Membro> builder)
        {
            builder.Property(m => m.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(m => m.DateDeNascimmento)
                .IsRequired();

                 builder.Property(m => m.Endereco)
                .IsRequired();

            builder.Property(m => m.EstadoCivil)
               .IsRequired();


            builder.Property(m => m.TelefoneCelular)
               .IsRequired();

            builder.HasOne(m => m.Usuario)
                 .WithOne(u => u.Membro);

            builder.HasOne(e => e.Endereco)
                .WithOne(m => m.Membro);
               

           
        }
    }
}
