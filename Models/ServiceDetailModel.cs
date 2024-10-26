using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoAppVar1.Models
{
    public class ServiceDetailModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Quantity { get; set; }

        [ForeignKey("ServiceId")]
        public int ServiceId { get; set; }
        public ServiceModel? Service { get; set; }

        [ForeignKey("DetailId")]
        public int DetailId { get; set; }
        public DetailModel? Detail { get; set; }
    }
}
