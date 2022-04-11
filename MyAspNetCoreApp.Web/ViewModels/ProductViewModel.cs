using System.ComponentModel.DataAnnotations;

namespace MyAspNetCoreApp.Web.ViewModels
{
    public class ProductViewModel
    {


        public int Id { get; set; }

        [Required(ErrorMessage ="İsim alanı boş olamaz")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Fiyat alanı boş olamaz")]
        public decimal? Price { get; set; }
        [Required(ErrorMessage = "Stok alanı boş olamaz")]
        public int? Stock { get; set; }
        [Required(ErrorMessage = "Açıklama alanı boş olamaz")]
        public string Description { get; set; }


       
        public string? Color { get; set; }


        
        public DateTime? PublishDate { get; set; }
        public bool IsPublish { get; set; }

        public int Expire { get; set; }
    }
}
