using E_Commerce.Domain.Entities;
using E_Commerce.Infra.Data.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_Commerce.Infra.Data.Contexto
{
    public class E_CommerceContexto : DbContext
    {
        public E_CommerceContexto(DbContextOptions<E_CommerceContexto> dbContextOptions) : base(dbContextOptions)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new ContatoConfiguration());
            modelBuilder.ApplyConfiguration(new PessoaConfiguration());
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\w.gontijo\\Documents\\EC.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        /// <summary>
        /// Utilizando o ChangeTracker eu insiro informações de cadastro e modificação dentro do Banco de Dados.
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
            foreach (var entry in this.ChangeTracker.Entries().Where(e => e.State == EntityState.Added))
            {
                if (entry.Property("DataCadastro").CurrentValue == null)
                    entry.Property("DataCadastro").CurrentValue = DateTime.UtcNow;

            }
            foreach (var entry in this.ChangeTracker.Entries().Where(e => e.State == EntityState.Modified))
            {
                entry.Property("DataModificação").CurrentValue = DateTime.UtcNow;
            }

            return base.SaveChanges();
        }

        #region DbSet
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        #endregion
    }
}
