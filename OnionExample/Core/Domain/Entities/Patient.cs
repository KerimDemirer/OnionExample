using Domain.Enums;

namespace Domain.Entities
{
    public class Patient : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
