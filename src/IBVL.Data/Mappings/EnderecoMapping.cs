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
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(x => x.Bairro)
                 .IsRequired()
                 .HasMaxLength(80);

            builder.Property(x => x.Numero)
                .IsRequired();
               
            builder.Property(x => x.Cep)
                .IsRequired()
                .HasMaxLength(8);

            builder.Property(x => x.Cidade)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Logradouro)
               .IsRequired()
               .HasMaxLength(100);
            builder.Property(x => x.Numero)
               .IsRequired()
               .HasMaxLength(12);

            



        }
    }
}
