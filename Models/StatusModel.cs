namespace DemoAppVar1.Models
{
    public class StatusModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<StatusUpdateModel>? StatusUpdate {  get; set; }
    }
}
