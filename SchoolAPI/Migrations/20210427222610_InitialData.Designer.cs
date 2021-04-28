﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SchoolAPI.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20210427222610_InitialData")]
    partial class InitialData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Assignment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssignmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("Assignments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991873"),
                            Name = "Assignment 1"
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            Name = "Assignment 2"
                        });
                });

            modelBuilder.Entity("Entities.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AssignmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<Guid?>("SectionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("SectionId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991871"),
                            Name = "Advanced Web Applications"
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce1"),
                            Name = "Web Mining"
                        });
                });

            modelBuilder.Entity("Entities.Models.Organization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrgName")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            City = "Bloomfield",
                            Country = "USA",
                            OrgName = "xyz org"
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            City = "Lusaka",
                            Country = "ZM",
                            OrgName = "lmnop org"
                        });
                });

            modelBuilder.Entity("Entities.Models.Section", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("Sections");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991872"),
                            Name = "Section 1"
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce2"),
                            Name = "Section 2"
                        });
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                            Age = 0,
                            Name = "kwilliams",
                            OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                        },
                        new
                        {
                            Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                            Age = 0,
                            Name = "ka393939",
                            OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            Age = 0,
                            Name = "kaw3939",
                            OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479812"),
                            Age = 21,
                            Name = "Tomas",
                            OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                            Age = 25,
                            Name = "Natalie",
                            OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479814"),
                            Age = 31,
                            Name = "Ethan",
                            OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479815"),
                            Age = 28,
                            Name = "Dan",
                            OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                        });
                });

            modelBuilder.Entity("Entities.Models.Course", b =>
                {
                    b.HasOne("Entities.Models.Assignment", null)
                        .WithMany("Courses")
                        .HasForeignKey("AssignmentId");

                    b.HasOne("Entities.Models.Section", null)
                        .WithMany("Courses")
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.HasOne("Entities.Models.Course", null)
                        .WithMany("Users")
                        .HasForeignKey("CourseId");

                    b.HasOne("Entities.Models.Organization", "Organization")
                        .WithMany("Users")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
