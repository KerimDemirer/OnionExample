using Domain.Enums;

namespace Domain.Entities
{
    public class TestResult : BaseEntity
    {
        public TestType Type { get; set; }
        public string ResultValue { get; set; }
        public DateTime Date { get; set; }

        public Guid PatientId { get; set; }
        public Patient Patient { get; set; }

    }
}
