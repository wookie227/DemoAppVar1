using System.ComponentModel.DataAnnotations;

namespace DemoAppVar1.Models
{
    public class ClientModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Phone { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        public ICollection<ServiceModel>? Services { get; set; }
    }
}
