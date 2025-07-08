using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Contexto
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options)
        {
        }

        //public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<ItemDrink> ItensDrink { get; set; }
        public DbSet<DrinkPreparoEImagem> DrinksPreparoEImagem { get; set; }

    }
}
