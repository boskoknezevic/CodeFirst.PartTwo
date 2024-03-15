﻿// <auto-generated />
using CodeFirst.PartTwo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirst.PartTwo.Migrations
{
    [DbContext(typeof(CarContext))]
    [Migration("20240315082757_CreateCarsEnginesAndEngineTypes")]
    partial class CreateCarsEnginesAndEngineTypes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CodeFirst.PartTwo.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ChassisNumber")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("CarId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CodeFirst.PartTwo.Models.Engine", b =>
                {
                    b.Property<int>("EngineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EngineId"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("EngineTypeId")
                        .HasColumnType("int");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("EngineId");

                    b.HasIndex("CarId")
                        .IsUnique();

                    b.HasIndex("EngineTypeId");

                    b.ToTable("Engines");
                });

            modelBuilder.Entity("CodeFirst.PartTwo.Models.EngineType", b =>
                {
                    b.Property<int>("EngineTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EngineTypeId"));

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EngineTypeId");

                    b.ToTable("EngineTypes");
                });

            modelBuilder.Entity("CodeFirst.PartTwo.Models.Engine", b =>
                {
                    b.HasOne("CodeFirst.PartTwo.Models.Car", "Car")
                        .WithOne("Engine")
                        .HasForeignKey("CodeFirst.PartTwo.Models.Engine", "CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirst.PartTwo.Models.EngineType", "EngineType")
                        .WithMany("Engines")
                        .HasForeignKey("EngineTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("EngineType");
                });

            modelBuilder.Entity("CodeFirst.PartTwo.Models.Car", b =>
                {
                    b.Navigation("Engine")
                        .IsRequired();
                });

            modelBuilder.Entity("CodeFirst.PartTwo.Models.EngineType", b =>
                {
                    b.Navigation("Engines");
                });
#pragma warning restore 612, 618
        }
    }
}
