using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
    public class Product
    {
        public int Id { get; set; }

        // [Display(Name = "Descrição")]
        [Required(ErrorMessage = "The Description field is mandatory")]
        public string Description { get; set; }
        [Range(1,10)]
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}