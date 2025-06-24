namespace Domain.Entities
{
    public class Doctor : BaseEntity
    {
        public string Name { get; set; }
        public string Specialization { get; set; }
        public ICollection<Patient> Patients { get; set; } = new List<Patient>();
    }
}
