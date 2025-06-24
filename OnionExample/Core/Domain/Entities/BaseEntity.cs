namespace Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
        public bool IsRecordActive { get; set; } = true;
    }
}
