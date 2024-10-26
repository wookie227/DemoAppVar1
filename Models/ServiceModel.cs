using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace DemoAppVar1.Models
{
    public  class ServiceModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Priority { get; set; } = string.Empty;

        [Required]
        public string Type { get; set; } = string.Empty;

        [Required]
        public string Desc { get; set; } = string.Empty;

        [Required]
        public string Reason { get; set; } = string.Empty;

        [Required]
        public int Price { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [ForeignKey("ClietnId")]
        public int ClientId { get; set; }
        public ClientModel? Client { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public EmployeeModel? Employee { get; set; }

        [ForeignKey("DeviceId")]
        public string DeviceId { get; set; } = string.Empty;
        public DeviceModel? Device { get; set; }

        public ICollection<StatusUpdateModel>? StatusUpdates { get; set; }
        public ICollection<ServiceDetailModel>? ServiceDetails { get; set; }
        public ICollection<CommentModel>? Comments { get; set; }
    }
}
