﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250227190704_AddCard")]
    partial class AddCard
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.2");

            modelBuilder.Entity("API.Entity.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerId")
                        .HasColumnType("TEXT");

                    b.HasKey("CardId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("API.Entity.CardItem", b =>
                {
                    b.Property<int>("CardItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("CardItemId");

                    b.HasIndex("CardId");

                    b.HasIndex("ProductId");

                    b.ToTable("CardItem");
                });

            modelBuilder.Entity("API.Entity.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("TEXT");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Description = "Telefon açıklaması.",
                            ImageUrl = "1.png",
                            IsActive = true,
                            ProductName = "IPhone 16 Pro",
                            ProductPrice = 87999m,
                            Stock = 50
                        },
                        new
                        {
                            ProductId = 2,
                            Description = "Telefon açıklaması2.",
                            ImageUrl = "2.png",
                            IsActive = true,
                            ProductName = "IPhone 11 Pro Max",
                            ProductPrice = 41000m,
                            Stock = 15
                        },
                        new
                        {
                            ProductId = 3,
                            Description = "Telefon açıklaması3.",
                            ImageUrl = "3.png",
                            IsActive = true,
                            ProductName = "Poco",
                            ProductPrice = 21000m,
                            Stock = 50
                        },
                        new
                        {
                            ProductId = 4,
                            Description = "Telefon açıklaması4.",
                            ImageUrl = "4.png",
                            IsActive = true,
                            ProductName = "Samsung Galaxy S24",
                            ProductPrice = 45000m,
                            Stock = 40
                        },
                        new
                        {
                            ProductId = 5,
                            Description = "Telefon açıklaması5.",
                            ImageUrl = "5.png",
                            IsActive = true,
                            ProductName = "IPhone 15 Pro",
                            ProductPrice = 99999m,
                            Stock = 50
                        });
                });

            modelBuilder.Entity("API.Entity.CardItem", b =>
                {
                    b.HasOne("API.Entity.Card", "Card")
                        .WithMany("CardItems")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entity.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("API.Entity.Card", b =>
                {
                    b.Navigation("CardItems");
                });
#pragma warning restore 612, 618
        }
    }
}
