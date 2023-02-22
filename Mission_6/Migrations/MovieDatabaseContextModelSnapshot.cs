﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission_6.Models;

namespace Mission_6.Migrations
{
    [DbContext(typeof(MovieDatabaseContext))]
    partial class MovieDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Mission_6.Models.AppRes", b =>
                {
                    b.Property<int>("ApplicationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("ApplicationID");

                    b.HasIndex("CategoryId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            ApplicationID = 1,
                            CategoryId = 6,
                            Director = "Quentin Tarantino",
                            Edited = false,
                            Rating = "R",
                            Title = "Pulp Fiction",
                            Year = 1994
                        },
                        new
                        {
                            ApplicationID = 2,
                            CategoryId = 1,
                            Director = "Quentin Tarantino",
                            Edited = false,
                            Rating = "R",
                            Title = "Inglourious Basterds",
                            Year = 2009
                        },
                        new
                        {
                            ApplicationID = 3,
                            CategoryId = 6,
                            Director = "Quentin Tarantino",
                            Edited = false,
                            Rating = "R",
                            Title = "The Hateful Eight",
                            Year = 2015
                        });
                });

            modelBuilder.Entity("Mission_6.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Sci-Fi"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Romance"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Documentary"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Other"
                        });
                });

            modelBuilder.Entity("Mission_6.Models.AppRes", b =>
                {
                    b.HasOne("Mission_6.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
