using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class DrinkPreparoEImagem
    {
        //Classe que guarda as informações de um drink específico

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string NomeDoDrink { get; set; }
        [Required]
        [StringLength(200)]
        public string UrlImagem { get; set; }
        [Required]
        public string DescricaoPreparo {  get; set; }
        //public string UrlImagemPaginaDoDrink { get; set; }
        //public string DescricaoDrink { get; set; }

        [Required]
        public ICollection<ItemDrink> ItensDrink { get; }

    }
}
