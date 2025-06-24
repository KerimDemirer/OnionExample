using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Presentation.EntityConfigurations
{
    public class UserConfiguration : BaseEntityTypeConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(u => u.PasswordHash)
                .IsRequired();
            builder.Property(u => u.PasswordSalt)
                .IsRequired();
            builder.Property(u => u.Role)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
