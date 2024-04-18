using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebCourseProject.Domain.Entities;

namespace WebCourseProject.DAL.Configurations
{
    public class GridsConfiguration : IEntityTypeConfiguration<Grids>
    {
        public void Configure(EntityTypeBuilder<Grids> builder)
        {

            builder.HasKey(Grid => Grid.gridId);

            builder.
                HasMany(Grid => Grid.Columns)
                .WithOne(Column => Column.Grid);

            builder.
                HasMany(Grid => Grid.Permissions)
                .WithOne(Permission => Permission.Grid);

        }
    }
}
