using System.ComponentModel.DataAnnotations;

namespace Foody.Web.Models
{
    public class ProductsDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        [Display(Name="Category Name")]
        public string CategoryName { get; set; }

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }
    }
}
