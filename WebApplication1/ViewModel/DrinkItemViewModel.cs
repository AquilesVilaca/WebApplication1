using WebApplication1.Models;

namespace WebApplication1.ViewModel
{
    public class DrinkItemViewModel
    {
        public IEnumerable<DrinkPreparoEImagem> drinksPreparoEImagem { get; set; }
        public IEnumerable<Ingrediente> ingredientes { get; set;}
        public IEnumerable<ItemDrink> ItensDrink {  get; set;}
    }
}
