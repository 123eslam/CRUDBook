using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC1.Models
{
    public class AddBook
    {
        [Required(ErrorMessage = "Name Is Required")]
        [MinLength(5, ErrorMessage = "Name Must Be 5 Char Min")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Price Is Required")]
        [Range(1, int.MaxValue)]
        public int Price { get; set; }
        [Required(ErrorMessage = "Category name Is Required")]
        [Range(1, int.MaxValue)]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Author name Is Required")]
        [Range(1, int.MaxValue)]
        public int AuthorId { get; set; }
        
    }
}
