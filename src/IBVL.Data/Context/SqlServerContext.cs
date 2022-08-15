using IBVL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Data.Context
{
    public class SqlServerContext:DbContext
    {

        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Membro> Membros { get; set; }

        public SqlServerContext(DbContextOptions<SqlServerContext>options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlServerContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
