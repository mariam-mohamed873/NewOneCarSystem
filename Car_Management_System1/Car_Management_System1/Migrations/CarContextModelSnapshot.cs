// <auto-generated />
using System;
using Car_Management_System1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Car_Management_System1.Migrations
{
    [DbContext(typeof(CarContext))]
    partial class CarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Car_Management_System1.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Employee_ID")
                        .HasColumnType("int");

                    b.Property<int>("Model")
                        .HasColumnType("int");

                    b.Property<string>("PlateNumber")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("Id");

                    b.HasIndex("Employee_ID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Car_Management_System1.Models.Card", b =>
                {
                    b.Property<int>("CardAccess")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardAccess"), 1L, 1);

                    b.Property<int>("Car_ID")
                        .HasColumnType("int");

                    b.Property<int>("Credit")
                        .HasColumnType("int");

                    b.Property<int>("Employee_ID")
                        .HasColumnType("int");

                    b.HasKey("CardAccess");

                    b.HasIndex("Car_ID");

                    b.HasIndex("Employee_ID");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("Car_Management_System1.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Car_Management_System1.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Car_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date_of_entry")
                        .HasColumnType("datetime2");

                    b.Property<int>("Employee_ID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Car_ID");

                    b.HasIndex("Employee_ID");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Car_Management_System1.Models.Car", b =>
                {
                    b.HasOne("Car_Management_System1.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("Employee_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Car_Management_System1.Models.Card", b =>
                {
                    b.HasOne("Car_Management_System1.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("Car_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Car_Management_System1.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("Employee_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Car_Management_System1.Models.Transaction", b =>
                {
                    b.HasOne("Car_Management_System1.Models.Car", "Car")
                        .WithMany("Transactions")
                        .HasForeignKey("Car_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Car_Management_System1.Models.Employee", "Employee")
                        .WithMany("Transactions")
                        .HasForeignKey("Employee_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Car_Management_System1.Models.Car", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Car_Management_System1.Models.Employee", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
