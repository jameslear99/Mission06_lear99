﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_lear99.Models;

namespace Mission06_lear99.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_lear99.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Romance"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Other"
                        });
                });

            modelBuilder.Entity("Mission06_lear99.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            CategoryID = 1,
                            Director = "John Landis",
                            Edited = false,
                            LentTo = "N/A",
                            Notes = "Potentially the greatest movie of all time!",
                            Rating = "PG",
                            Title = "The Three Amigos",
                            Year = 1986
                        },
                        new
                        {
                            MovieID = 2,
                            CategoryID = 2,
                            Director = "Guy Ritchie",
                            Edited = false,
                            LentTo = "N/A",
                            Notes = "A very fun spy movie with good russian!",
                            Rating = "PG-13",
                            Title = "The Man From U.N.C.L.E.",
                            Year = 2015
                        },
                        new
                        {
                            MovieID = 3,
                            CategoryID = 1,
                            Director = "Wes Anderson",
                            Edited = false,
                            LentTo = "N/A",
                            Notes = "Wes Anderson movies are amazing!",
                            Rating = "PG",
                            Title = "Fantastic Mr. Fox",
                            Year = 2009
                        });
                });

            modelBuilder.Entity("Mission06_lear99.Models.Movie", b =>
                {
                    b.HasOne("Mission06_lear99.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
