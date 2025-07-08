using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ItemDrink
    {
        //Classe que guarda as informaçoes de infrediente e quantidade deste ingrediente em um drink.
        //Todos os ItemDrink que possuem o mesmo DrinkId são unidos posteriormente para formar o drink em sí

        public int Id { get; set; }
        [StringLength(100)]
        public string QuantidadeEIngrediente { get; set; }
        [Required]



        public DrinkPreparoEImagem DrinkPreparoEImagem { get; set; }
    }
}
