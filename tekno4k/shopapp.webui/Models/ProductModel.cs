using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using shopapp.entity;

namespace shopapp.webui.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }  
      public string Name { get; set; }     
       
        [Required(ErrorMessage="Url zorunlu bir alan.")]  
        public string Url { get; set; }     
      public double? Price { get; set; } 
      
        [Required(ErrorMessage="Description zorunlu bir alan.")]
        [StringLength(100,MinimumLength=5,ErrorMessage="Description 5-100 karakter aralığında olmalıdır.")]

        public string Description { get; set; }      
       
        [Required(ErrorMessage="ImageUrl zorunlu bir alan.")]  
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public List<Category> SelectedCategories { get; set; }
        
                public List<Comment> Comments { get; set; }

    }
}