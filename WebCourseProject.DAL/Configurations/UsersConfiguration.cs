using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebCourseProject.Domain.Entities;

namespace WebCourseProject.DAL.Configurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {

            builder.HasKey(User => User.userId);

            builder.
                HasOne(User => User.Role)
                .WithOne(Role => Role.User)
                .HasForeignKey<Users>(User => User.roleId);

            builder.
                HasMany(User => User.Permissions)
                .WithOne(Permission => Permission.User);
        }
    }
}
