﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using homework_6_trevinoj73.Models;

namespace homework6trevinoj73.Migrations
{
    [DbContext(typeof(WishlistContext))]
    partial class WishlistContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21");

            modelBuilder.Entity("homework_6_trevinoj73.Models.Link", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("URLLink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("WishId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("WishId");

                    b.ToTable("Link");
                });

            modelBuilder.Entity("homework_6_trevinoj73.Models.Wish", b =>
                {
                    b.Property<int>("WishID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(60);

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.HasKey("WishID");

                    b.ToTable("Wish");
                });

            modelBuilder.Entity("homework_6_trevinoj73.Models.Link", b =>
                {
                    b.HasOne("homework_6_trevinoj73.Models.Wish", "Wish")
                        .WithMany("Links")
                        .HasForeignKey("WishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
