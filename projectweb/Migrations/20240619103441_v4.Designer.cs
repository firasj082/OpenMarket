﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using userList.Models;

#nullable disable

namespace projectweb.Migrations
{
    [DbContext(typeof(usercontext))]
    [Migration("20240619103441_v4")]
    partial class v4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("projectweb.Models.product", b =>
                {
                    b.Property<int>("productid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("productid"), 1L, 1);

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("productname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("productid");

                    b.HasIndex("userid");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            productid = 1,
                            Company = "AhmadTechnology",
                            Location = "China",
                            Price = 0.0,
                            productname = "car bm2",
                            userid = 1
                        },
                        new
                        {
                            productid = 2,
                            Company = "AhmadTechnology",
                            Location = "China",
                            Price = 0.0,
                            productname = "Comedy",
                            userid = 1
                        },
                        new
                        {
                            productid = 3,
                            Company = "AhmadTechnology",
                            Location = "China",
                            Price = 0.0,
                            productname = "Drama",
                            userid = 1
                        },
                        new
                        {
                            productid = 4,
                            Company = "AhmadTechnology",
                            Location = "China",
                            Price = 0.0,
                            productname = "Horror",
                            userid = 1
                        },
                        new
                        {
                            productid = 5,
                            Company = "AhmadTechnology",
                            Location = "China",
                            Price = 0.0,
                            productname = "Musical",
                            userid = 1
                        },
                        new
                        {
                            productid = 6,
                            Company = "AhmadTechnology",
                            Location = "China",
                            Price = 0.0,
                            productname = "RomCom",
                            userid = 1
                        },
                        new
                        {
                            productid = 7,
                            Company = "AhmadTechnology",
                            Location = "China",
                            Price = 0.0,
                            productname = "SciFi",
                            userid = 1
                        });
                });

            modelBuilder.Entity("projectweb.Models.user", b =>
                {
                    b.Property<int>("userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userid"), 1L, 1);

                    b.Property<string>("Ccnum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userid");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            userid = 1,
                            Ccnum = "11234",
                            Email = "ahmadabualrob@gmail.com",
                            Password = "11",
                            Phone = "056444322",
                            Username = "ahmad"
                        });
                });

            modelBuilder.Entity("projectweb.Models.product", b =>
                {
                    b.HasOne("projectweb.Models.user", "user")
                        .WithMany()
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });
#pragma warning restore 612, 618
        }
    }
}
