using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCourseProject.Domain.Entities;

namespace WebCourseProject.DAL.Configurations
{
    public class ColumnsConfiguration : IEntityTypeConfiguration<Columns>
    {
        public void Configure(EntityTypeBuilder<Columns> builder)
        {

            builder.HasKey(Column => Column.columnId);

            builder.
                HasOne(Column => Column.Grid)
                .WithMany(Grid => Grid.Columns);
            //.HasForeignKey(Column => Column.gridId);
        }
    }
}
