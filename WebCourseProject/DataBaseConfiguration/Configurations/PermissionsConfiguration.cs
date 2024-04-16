using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebCourseProject.Domain.Entities;

namespace WebCourseProject.DataBaseConfiguration.Configurations
{
    public class PermissionsConfiguration : IEntityTypeConfiguration<Permissions>
    {
        public void Configure(EntityTypeBuilder<Permissions> builder)
        {

            builder.HasKey(Permission => Permission.permId);

            builder.
                HasOne(Permission => Permission.User)
                .WithMany(User => User.Permissions);

            builder.
                HasOne(Permission => Permission.Grid)
                .WithMany(Grid => Grid.Permissions);
        }
    }
}
