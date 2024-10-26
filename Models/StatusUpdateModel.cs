using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoAppVar1.Models
{
    public class StatusUpdateModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("ServiceId")]
        public int ServiceId { get; set; }
        public ServiceModel? Service { get; set; }

        [ForeignKey("StatusId")]
        public int StatusId { get; set; }
        public StatusModel? Status { get; set; }
    }
}
