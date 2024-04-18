﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebCourseProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240416190153_InitialSchema")]
    partial class InitialSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("WebCourseProject.Domain.Entities.Columns", b =>
                {
                    b.Property<int>("columnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("gridId")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("type")
                        .HasColumnType("text");

                    b.HasKey("columnId");

                    b.HasIndex("gridId");

                    b.ToTable("Columns");
                });

            modelBuilder.Entity("WebCourseProject.Domain.Entities.Grids", b =>
                {
                    b.Property<int>("gridId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("privacy")
                        .HasColumnType("text");

                    b.HasKey("gridId");

                    b.ToTable("Grids");
                });

            modelBuilder.Entity("WebCourseProject.Domain.Entities.Permissions", b =>
                {
                    b.Property<int>("permId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("create")
                        .HasColumnType("boolean");

                    b.Property<int>("gridId")
                        .HasColumnType("integer");

                    b.Property<bool>("read")
                        .HasColumnType("boolean");

                    b.Property<bool>("update")
                        .HasColumnType("boolean");

                    b.Property<int>("userId")
                        .HasColumnType("integer");

                    b.Property<bool>("write")
                        .HasColumnType("boolean");

                    b.HasKey("permId");

                    b.HasIndex("gridId");

                    b.HasIndex("userId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("WebCourseProject.Domain.Entities.Roles", b =>
                {
                    b.Property<int>("roleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("type")
                        .HasColumnType("text");

                    b.Property<int>("userId")
                        .HasColumnType("integer");

                    b.HasKey("roleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("WebCourseProject.Domain.Entities.Users", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("login")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .HasColumnType("text");

                    b.Property<int>("roleId")
                        .HasColumnType("integer");

                    b.HasKey("userId");

                    b.HasIndex("roleId")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebCourseProject.Domain.Entities.Columns", b =>
                {
                    b.HasOne("WebCourseProject.Domain.Entities.Grids", "Grid")
                        .WithMany("Columns")
                        .HasForeignKey("gridId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grid");
                });

            modelBuilder.Entity("WebCourseProject.Domain.Entities.Permissions", b =>
                {
                    b.HasOne("WebCourseProject.Domain.Entities.Grids", "Grid")
                        .WithMany("Permissions")
                        .HasForeignKey("gridId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebCourseProject.Domain.Entities.Users", "User")
                        .WithMany("Permissions")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grid");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebCourseProject.Domain.Entities.Users", b =>
                {
                    b.HasOne("WebCourseProject.Domain.Entities.Roles", "Role")
                        .WithOne("User")
                        .HasForeignKey("WebCourseProject.Domain.Entities.Users", "roleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("WebCourseProject.Domain.Entities.Grids", b =>
                {
                    b.Navigation("Columns");

                    b.Navigation("Permissions");
                });

            modelBuilder.Entity("WebCourseProject.Domain.Entities.Roles", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("WebCourseProject.Domain.Entities.Users", b =>
                {
                    b.Navigation("Permissions");
                });
#pragma warning restore 612, 618
        }
    }
}
