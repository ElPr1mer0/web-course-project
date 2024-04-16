using Microsoft.EntityFrameworkCore;
using WebCourseProject.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebCourseProject.DataBaseConfiguration.Configurations
{
    public class ColumnsConfiguration : IEntityTypeConfiguration<Columns>
    {
        public void Configure(EntityTypeBuilder<Columns> builder) {

            builder.HasKey(Column => Column.columnId);

            builder.
                HasOne(Column => Column.Grid)
                .WithMany(Grid => Grid.Columns);
                //.HasForeignKey(Column => Column.gridId);
        }
    }
}
