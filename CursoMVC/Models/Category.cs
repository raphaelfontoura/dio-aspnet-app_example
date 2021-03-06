using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
    }
}