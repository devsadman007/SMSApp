namespace SMSApp.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Short_name { get; set; }
        public string Code { get; set; }
        public string? createdBy { get; set; }
        public DateTime? createdAt { get; set; }
        public string? editedBy { get; set; }
        public DateTime? editedAt { get; set; }
        public string? deletedBy { get; set; }
        public DateTime? deletedAt { get; set; }
        public bool isDeleted { get; set; }
    }
}
