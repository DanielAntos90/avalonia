using Microsoft.EntityFrameworkCore;
using Test.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Test.Services
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Objednavka> DbObjednavka { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=database.db");
            //optionsBuilder.LogTo(Console.WriteLine);
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        modelBuilder.Entity<Objednavka>(
            ob =>
            {
                ob.OwnsOne(
                    o => o.OrderedPizza,
                    sa =>
                    {
                        sa.Property(p => p.Name).IsRequired();
                        sa.Property(p => p.Pridavky).IsRequired();
                    });

                ob.Navigation(o => o.OrderedPizza)
                    .IsRequired();
            });
        }
    }
}
