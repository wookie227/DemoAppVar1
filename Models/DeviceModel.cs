using System.ComponentModel.DataAnnotations;

namespace DemoAppVar1.Models
{
    public class DeviceModel
    {
        [Key]
        public string Id { get; set; } = string.Empty;

        [Required]
        public string Category { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<ServiceModel>? Services { get; set; }
    }
}
