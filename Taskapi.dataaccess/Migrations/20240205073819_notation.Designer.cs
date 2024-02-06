﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Taskapi.dataaccess;

#nullable disable

namespace Taskapi.dataaccess.Migrations
{
    [DbContext(typeof(Tododbcontext))]
    [Migration("20240205073819_notation")]
    partial class notation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Taskapi.modles.author", b =>
                {
                    b.Property<int>("AId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AId"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AId = 1,
                            FullName = "Thilina Dilshan"
                        },
                        new
                        {
                            AId = 2,
                            FullName = "Saduni Madubhashini"
                        },
                        new
                        {
                            AId = 3,
                            FullName = "Charith vishan"
                        },
                        new
                        {
                            AId = 4,
                            FullName = "Punsara Nishanga"
                        });
                });

            modelBuilder.Entity("tasknew.modles.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("authorAId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("authorAId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2024, 2, 5, 13, 8, 18, 691, DateTimeKind.Local).AddTicks(3125),
                            Description = "get some text books for school",
                            Due = new DateTime(2024, 2, 10, 13, 8, 18, 691, DateTimeKind.Local).AddTicks(3136),
                            Status = 0,
                            Title = "Get books for school-DB",
                            authorAId = 1
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2024, 2, 5, 13, 8, 18, 691, DateTimeKind.Local).AddTicks(3145),
                            Description = "get vegetable for week",
                            Due = new DateTime(2024, 2, 7, 13, 8, 18, 691, DateTimeKind.Local).AddTicks(3146),
                            Status = 0,
                            Title = "Get Vegetable",
                            authorAId = 1
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2024, 2, 5, 13, 8, 18, 691, DateTimeKind.Local).AddTicks(3148),
                            Description = "Wter the plant quickly",
                            Due = new DateTime(2024, 2, 6, 13, 8, 18, 691, DateTimeKind.Local).AddTicks(3148),
                            Status = 0,
                            Title = "Water the plants",
                            authorAId = 2
                        });
                });

            modelBuilder.Entity("tasknew.modles.Todo", b =>
                {
                    b.HasOne("Taskapi.modles.author", "Author")
                        .WithMany()
                        .HasForeignKey("authorAId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });
#pragma warning restore 612, 618
        }
    }
}
