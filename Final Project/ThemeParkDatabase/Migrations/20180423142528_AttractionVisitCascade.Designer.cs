﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using ThemeParkDatabase.Models;

namespace ThemeParkDatabase.Migrations
{
    [DbContext(typeof(ThemeParkDatabaseContext))]
    [Migration("20180423142528_AttractionVisitCascade")]
    partial class AttractionVisitCascade
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ThemeParkDatabase.Models.Attraction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttractionTypeId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("LocationId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("AttractionTypeId");

                    b.HasIndex("LocationId");

                    b.ToTable("Attraction");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.AttractionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("AttractionType");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.AttractionVisit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttractionId");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("AttractionId");

                    b.ToTable("AttractionVisit");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.DailyParkReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<double>("InchesPrecipitation");

                    b.Property<int>("NumVisitors");

                    b.Property<bool>("Rainout");

                    b.Property<double>("Temperature");

                    b.HasKey("Id");

                    b.ToTable("DailyParkReport");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.DeletionRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EmployeeId");

                    b.Property<int>("TableId");

                    b.Property<string>("TableName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("TimeRequested")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("DeletionRequest");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LocationId");

                    b.Property<int?>("ManagerId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DepartmentId");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("date");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("MiddleInitial")
                        .HasColumnType("nchar(1)");

                    b.Property<decimal>("Salary");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.MaintenanceAudit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttractionId");

                    b.Property<string>("CurrentStatus");

                    b.Property<DateTime>("DateRequested");

                    b.Property<DateTime>("DateResolved");

                    b.Property<string>("Description");

                    b.Property<decimal>("EstimatedCost");

                    b.Property<DateTime>("UpdatedOne");

                    b.HasKey("Id");

                    b.ToTable("MaintenanceAudit");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.MaintenanceRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttractionId");

                    b.Property<string>("CurrentStatus")
                        .IsRequired();

                    b.Property<DateTime>("DateRequested")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DateResolved")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<decimal>("EstimatedCost");

                    b.HasKey("Id");

                    b.HasIndex("AttractionId");

                    b.ToTable("MaintenanceRequest");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.ParkInfomation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PostalCode")
                        .HasColumnType("nchar(10)");

                    b.Property<string>("State")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("ParkInfomation");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("RedeemedDate")
                        .HasColumnType("date");

                    b.Property<int>("TicketTypeId");

                    b.Property<int>("VisitorId");

                    b.HasKey("Id");

                    b.HasIndex("TicketTypeId");

                    b.HasIndex("VisitorId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.TicketType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("TicketType");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("LocationId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("VendorTypeId");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("VendorTypeId");

                    b.ToTable("Vendor");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.VendorSalesReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<decimal>("SalesGoal");

                    b.Property<decimal>("TotalSales");

                    b.Property<int>("VendorId");

                    b.HasKey("Id");

                    b.HasIndex("VendorId");

                    b.ToTable("VendorSalesReport");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.VendorType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("VendorType");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.Visitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("MiddleInitial")
                        .HasMaxLength(1);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("Visitor");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.WeatherAudit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<double>("InchesPrecipitation");

                    b.Property<bool>("Rainout");

                    b.Property<double>("Temperature");

                    b.HasKey("Id");

                    b.ToTable("WeatherAudit");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.Attraction", b =>
                {
                    b.HasOne("ThemeParkDatabase.Models.AttractionType", "AttractionType")
                        .WithMany("Attraction")
                        .HasForeignKey("AttractionTypeId")
                        .HasConstraintName("FK_Attraction_AttractionType");

                    b.HasOne("ThemeParkDatabase.Models.Location", "Location")
                        .WithMany("Attraction")
                        .HasForeignKey("LocationId")
                        .HasConstraintName("FK_Attraction_Location");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.AttractionVisit", b =>
                {
                    b.HasOne("ThemeParkDatabase.Models.Attraction", "Attraction")
                        .WithMany("AttractionVisit")
                        .HasForeignKey("AttractionId")
                        .HasConstraintName("FK_AttractionVisit_Attraction")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.DeletionRequest", b =>
                {
                    b.HasOne("ThemeParkDatabase.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.Employee", b =>
                {
                    b.HasOne("ThemeParkDatabase.Models.Department", "Department")
                        .WithMany("Employee")
                        .HasForeignKey("DepartmentId")
                        .HasConstraintName("FK_Employee_Department1");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.MaintenanceRequest", b =>
                {
                    b.HasOne("ThemeParkDatabase.Models.Attraction", "Attraction")
                        .WithMany("MaintenanceRequest")
                        .HasForeignKey("AttractionId")
                        .HasConstraintName("FK_MaintenanceRequest_Attraction");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.Ticket", b =>
                {
                    b.HasOne("ThemeParkDatabase.Models.TicketType", "TicketType")
                        .WithMany("Ticket")
                        .HasForeignKey("TicketTypeId")
                        .HasConstraintName("FK_Ticket_TicketType");

                    b.HasOne("ThemeParkDatabase.Models.Visitor", "Visitor")
                        .WithMany("Ticket")
                        .HasForeignKey("VisitorId")
                        .HasConstraintName("FK_Ticket_Visitor");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.Vendor", b =>
                {
                    b.HasOne("ThemeParkDatabase.Models.Location", "Location")
                        .WithMany("Vendor")
                        .HasForeignKey("LocationId")
                        .HasConstraintName("FK_Vendor_Location");

                    b.HasOne("ThemeParkDatabase.Models.VendorType", "VendorType")
                        .WithMany("Vendor")
                        .HasForeignKey("VendorTypeId")
                        .HasConstraintName("FK_Vendor_VendorType");
                });

            modelBuilder.Entity("ThemeParkDatabase.Models.VendorSalesReport", b =>
                {
                    b.HasOne("ThemeParkDatabase.Models.Vendor", "Vendor")
                        .WithMany("VendorSalesReport")
                        .HasForeignKey("VendorId")
                        .HasConstraintName("FK_VendorSalesReport_Vendor");
                });
#pragma warning restore 612, 618
        }
    }
}
