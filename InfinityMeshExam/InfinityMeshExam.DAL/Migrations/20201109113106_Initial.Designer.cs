﻿// <auto-generated />
using System;
using InfinityMeshExam.DAL.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InfinityMeshExam.DAL.Migrations
{
    [DbContext(typeof(InfinityMeshExamDbContext))]
    [Migration("20201109113106_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InfinityMeshExam.DAL.Domain.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(3500)")
                        .HasMaxLength(3500);

                    b.Property<DateTime>("Published")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(350)")
                        .HasMaxLength(350);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("blogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            Published = new DateTime(2020, 11, 9, 11, 31, 6, 102, DateTimeKind.Utc).AddTicks(912),
                            Summary = "Lorem ipsum dolor sit amet",
                            Title = "Univerzalni tekst kojeg svi programeri koriste",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("InfinityMeshExam.DAL.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Age")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfBlogs")
                        .HasColumnType("int");

                    b.Property<string>("ViewProfile")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = new DateTime(1999, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ahmedterzic@infinity.com",
                            Name = "Ahmed Terzic",
                            NumberOfBlogs = 0,
                            ViewProfile = "www.infinitymesh.com/profile/ahmedterzic"
                        },
                        new
                        {
                            Id = 2,
                            Age = new DateTime(1998, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ajdintabak@infinity.com",
                            Name = "Ajding Tabak",
                            NumberOfBlogs = 0,
                            ViewProfile = "www.infinitymesh.com/profile/ajdintabak"
                        },
                        new
                        {
                            Id = 3,
                            Age = new DateTime(1999, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "huseinmuftic@infinity.com",
                            Name = "Husein Muftic",
                            NumberOfBlogs = 0,
                            ViewProfile = "www.infinitymesh.com/profile/huseinmuftic"
                        });
                });

            modelBuilder.Entity("InfinityMeshExam.DAL.Domain.Blog", b =>
                {
                    b.HasOne("InfinityMeshExam.DAL.Domain.User", "User")
                        .WithMany("Blogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
