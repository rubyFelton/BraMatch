﻿// <auto-generated />
using System;
using EntityDataAccess.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityDataAccess.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityDataAccess.Models.Bra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Maker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SizeId")
                        .HasColumnType("int");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SizeId");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Bras");
                });

            modelBuilder.Entity("EntityDataAccess.Models.BraSize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BandSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CupSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MesureSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BraSizes");
                });

            modelBuilder.Entity("EntityDataAccess.Models.BraType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Convertable")
                        .HasColumnType("bit");

                    b.Property<string>("Cup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Strap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Style")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Wire")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("BraTypes");
                });

            modelBuilder.Entity("EntityDataAccess.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BandMeasure")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Implants")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MeasureSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PointMeasure")
                        .HasColumnType("decimal(5,2)");

                    b.Property<bool>("Reduction")
                        .HasColumnType("bit");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("WidestMeasure")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EntityDataAccess.Models.Bra", b =>
                {
                    b.HasOne("EntityDataAccess.Models.BraSize", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId");

                    b.HasOne("EntityDataAccess.Models.BraType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.HasOne("EntityDataAccess.Models.User", null)
                        .WithMany("Bras")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}