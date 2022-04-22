using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CustomerPortal.Migrations
{
    [DbContext(typeof(CustomerPortalContext))]
    [Migration("20220419160145_fixedmodels")]
    partial class fixedmodels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("CustomerPortal.Models.Battery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BuildingType")
                        .HasColumnType("TEXT");

                    b.Property<string>("Certificate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ColumnId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CommissionDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Information")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastInspectionDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ColumnId");

                    b.ToTable("Battery");
                });

            modelBuilder.Entity("CustomerPortal.Models.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AdminEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminName")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminPhone")
                        .HasColumnType("TEXT");

                    b.Property<int?>("BatteryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("TechEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("TechName")
                        .HasColumnType("TEXT");

                    b.Property<string>("TechPhone")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BatteryId");

                    b.ToTable("Building");
                });

            modelBuilder.Entity("CustomerPortal.Models.Column", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BuildingType")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ElevatorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Information")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberFloorsServed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ElevatorId");

                    b.ToTable("Column");
                });

            modelBuilder.Entity("CustomerPortal.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BuildingId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CompanyDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactPhone")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("TechAuthorityEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("TechAuthorityName")
                        .HasColumnType("TEXT");

                    b.Property<string>("TechAuthorityPhone")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("CustomerPortal.Models.Elevator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BuildingType")
                        .HasColumnType("TEXT");

                    b.Property<string>("Certificate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CommissionDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Information")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastInspectionDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Elevator");
                });

            modelBuilder.Entity("CustomerPortal.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BatteryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BatteryId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("CustomerPortal.Models.Battery", b =>
                {
                    b.HasOne("CustomerPortal.Models.Column", null)
                        .WithMany("batteries")
                        .HasForeignKey("ColumnId");
                });

            modelBuilder.Entity("CustomerPortal.Models.Building", b =>
                {
                    b.HasOne("CustomerPortal.Models.Battery", null)
                        .WithMany("buildings")
                        .HasForeignKey("BatteryId");
                });

            modelBuilder.Entity("CustomerPortal.Models.Column", b =>
                {
                    b.HasOne("CustomerPortal.Models.Elevator", null)
                        .WithMany("columns")
                        .HasForeignKey("ElevatorId");
                });

            modelBuilder.Entity("CustomerPortal.Models.Customer", b =>
                {
                    b.HasOne("CustomerPortal.Models.Building", null)
                        .WithMany("customers")
                        .HasForeignKey("BuildingId");
                });

            modelBuilder.Entity("CustomerPortal.Models.Employee", b =>
                {
                    b.HasOne("CustomerPortal.Models.Battery", null)
                        .WithMany("employees")
                        .HasForeignKey("BatteryId");
                });

            modelBuilder.Entity("CustomerPortal.Models.Battery", b =>
                {
                    b.Navigation("buildings");

                    b.Navigation("employees");
                });

            modelBuilder.Entity("CustomerPortal.Models.Building", b =>
                {
                    b.Navigation("customers");
                });

            modelBuilder.Entity("CustomerPortal.Models.Column", b =>
                {
                    b.Navigation("batteries");
                });

            modelBuilder.Entity("CustomerPortal.Models.Elevator", b =>
                {
                    b.Navigation("columns");
                });
#pragma warning restore 612, 618
        }
    }
}