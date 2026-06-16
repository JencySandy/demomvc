using System.ComponentModel.DataAnnotations;

namespace demomvc.Models
{
    public class Brand
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        public string Name { get; set; }

        public int EstablishedYear { get; set; }

        public string BrandLogo { get; set; }
    }
}
