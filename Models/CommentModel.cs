using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoAppVar1.Models
{
    public class CommentModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; } = string.Empty;

        [Required]
        public DateTime CreatedAt { get; set; }

        [ForeignKey("ServiceId")]
        public int ServiceId { get; set; }
        public ServiceModel? Service { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public EmployeeModel? Employee { get; set; }
    }
}
