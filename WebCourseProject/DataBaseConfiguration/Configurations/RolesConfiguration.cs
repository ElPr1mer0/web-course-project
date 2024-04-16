using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebCourseProject.Domain.Entities;

namespace WebCourseProject.DataBaseConfiguration.Configurations
{
    public class RolesConfiguration : IEntityTypeConfiguration<Roles>
    {
        public void Configure(EntityTypeBuilder<Roles> builder)
        {

            builder.HasKey(Role => Role.roleId);

            builder.
                HasOne(Role => Role.User)
                .WithOne(User => User.Role)
                .HasForeignKey<Roles>(Role => Role.userId);
        }
    }
}
