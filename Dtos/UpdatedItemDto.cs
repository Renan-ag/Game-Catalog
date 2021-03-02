using System.ComponentModel.DataAnnotations;

namespace catalog.Dtos
{
    public record UpdatedItemDto
    {   
        [Required]
        public string Name { get; init; }
        
        [Required]
        [Range(1, 1000)]
        public decimal Price{ get; init; }
    }
}