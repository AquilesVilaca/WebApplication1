using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebApplication1.Models
{
    public class Ingrediente
    {
        
        public int IngredienteId { get; set; }
        
        [StringLength(100)]
        
        public string Name { get; set; }
        
        [Required]
        public string Description { get; set; }
        public ICollection<ItemDrink> ItensDrink { get; }



    }
}
