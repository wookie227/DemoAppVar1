using System.ComponentModel.DataAnnotations;

namespace DemoAppVar1.Models
{
    public class DetailModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Desc { get; set; } = string.Empty;

        [Required]
        public int Price { get; set; }

        public ICollection<ServiceDetailModel>? ServiceDetail { get; set; }
    }
}
