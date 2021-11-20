﻿// <auto-generated />
using System;
using CanteenManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CanteenManagementSystem.Migrations.AppDb
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CanteenManagementSystem.Models.menuDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("manuAvailbility")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("manuDescription")
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("manuImage")
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("manuName")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("manuType")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("menuPrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("vegOrNonVeg")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("menudetails");
                });

            modelBuilder.Entity("CanteenManagementSystem.Models.orderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("customerEmailId")
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("customerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("customerName")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("menuId")
                        .HasColumnType("int");

                    b.Property<string>("menuName")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("menuPrice")
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime>("orderDate")
                        .HasColumnType("date");

                    b.Property<string>("paymentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("orderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
