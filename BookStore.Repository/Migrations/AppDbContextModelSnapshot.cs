﻿// <auto-generated />
using System;
using BookStore.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStore.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookLibrary", b =>
                {
                    b.Property<int>("BooksId")
                        .HasColumnType("int");

                    b.Property<int>("LibrariesId")
                        .HasColumnType("int");

                    b.HasKey("BooksId", "LibrariesId");

                    b.HasIndex("LibrariesId");

                    b.ToTable("BookLibrary");
                });

            modelBuilder.Entity("BookStore.Core.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "TEST",
                            IsDeleted = false,
                            LastName = "TEST"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "TEST2",
                            IsDeleted = false,
                            LastName = "TEST2"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "TEST3",
                            IsDeleted = false,
                            LastName = "TEST3"
                        });
                });

            modelBuilder.Entity("BookStore.Core.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("EditionNumber")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("ISBN")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("PublishedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("GenreId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            BookName = "TEST1",
                            Description = "Test",
                            EditionNumber = 0,
                            GenreId = 1,
                            ISBN = 99299231,
                            IsDeleted = false,
                            Title = "TEST"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            BookName = "TEST2",
                            Description = "Test",
                            EditionNumber = 0,
                            GenreId = 2,
                            ISBN = 12312345,
                            IsDeleted = false,
                            Title = "TEST"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 1,
                            BookName = "TEST3",
                            Description = "Test",
                            EditionNumber = 0,
                            GenreId = 3,
                            ISBN = 12343455,
                            IsDeleted = false,
                            Title = "TEST"
                        });
                });

            modelBuilder.Entity("BookStore.Core.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenreName = "Psychology",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            GenreName = "Science",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            GenreName = "History",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("BookStore.Core.Entities.Library", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Libraries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("BookStore.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAdress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LibraryId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProfileImg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmailAdress = "testdata@gmail.com",
                            IsActive = true,
                            IsAdmin = true,
                            IsDeleted = false,
                            LibraryId = 0,
                            Password = "test1",
                            ProfileImg = "a.jpg",
                            Username = "CANB"
                        },
                        new
                        {
                            Id = 2,
                            EmailAdress = "test1@gmail.com",
                            IsActive = true,
                            IsAdmin = false,
                            IsDeleted = false,
                            LibraryId = 0,
                            Password = "test2",
                            ProfileImg = "a.jpg",
                            Username = "Test1"
                        },
                        new
                        {
                            Id = 3,
                            EmailAdress = "test2@gmail.com",
                            IsActive = true,
                            IsAdmin = false,
                            IsDeleted = false,
                            LibraryId = 0,
                            Password = "test3",
                            ProfileImg = "a.jpg",
                            Username = "Test2"
                        },
                        new
                        {
                            Id = 4,
                            EmailAdress = "test3@gmail.com",
                            IsActive = false,
                            IsAdmin = false,
                            IsDeleted = true,
                            LibraryId = 0,
                            Password = "test4",
                            ProfileImg = "a.jpg",
                            Username = "Test3"
                        },
                        new
                        {
                            Id = 5,
                            EmailAdress = "test4@gmail.com",
                            IsActive = true,
                            IsAdmin = false,
                            IsDeleted = false,
                            LibraryId = 0,
                            Password = "test5",
                            ProfileImg = "a.jpg",
                            Username = "Test4"
                        });
                });

            modelBuilder.Entity("BookUser", b =>
                {
                    b.Property<int>("BooksId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("BooksId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("BookUser");
                });

            modelBuilder.Entity("BookLibrary", b =>
                {
                    b.HasOne("BookStore.Core.Entities.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Core.Entities.Library", null)
                        .WithMany()
                        .HasForeignKey("LibrariesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.Core.Entities.Book", b =>
                {
                    b.HasOne("BookStore.Core.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Core.Entities.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("BookStore.Core.Entities.Library", b =>
                {
                    b.HasOne("BookStore.Core.Entities.User", "User")
                        .WithOne("Library")
                        .HasForeignKey("BookStore.Core.Entities.Library", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookUser", b =>
                {
                    b.HasOne("BookStore.Core.Entities.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.Core.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookStore.Core.Entities.Genre", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookStore.Core.Entities.User", b =>
                {
                    b.Navigation("Library")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
