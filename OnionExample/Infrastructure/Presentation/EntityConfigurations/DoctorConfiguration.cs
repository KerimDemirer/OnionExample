namespace Presentation.EntityConfigurations
{
    public class DoctorConfiguration : BaseEntityTypeConfiguration<Domain.Entities.Doctor>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Domain.Entities.Doctor> builder)
        {
            base.Configure(builder);
            builder.Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(d => d.Specialization)
                .IsRequired()
                .HasMaxLength(100);
            builder.HasMany(d => d.Patients)
                .WithOne(p => p.Doctor)
                .HasForeignKey(p => p.DoctorId);
        }
    }
}
