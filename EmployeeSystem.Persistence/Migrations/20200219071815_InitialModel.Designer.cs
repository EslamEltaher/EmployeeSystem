﻿// <auto-generated />
using System;
using EmployeeSystem.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeSystem.Persistence.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20200219071815_InitialModel")]
    partial class InitialModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeSystem.Application.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CountryID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryCode")
                        .HasColumnName("CountryCode")
                        .HasMaxLength(2);

                    b.Property<string>("CountryName")
                        .HasColumnName("CountryName")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("EmployeeSystem.Application.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("empID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnName("empBirthDate");

                    b.Property<int>("CountryID");

                    b.Property<string>("Email")
                        .HasColumnName("empEmail")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasColumnName("empName")
                        .HasMaxLength(50);

                    b.Property<byte[]>("Photo")
                        .HasColumnName("empPhoto");

                    b.Property<float>("Salary")
                        .HasColumnName("empSalary");

                    b.Property<string>("Title")
                        .HasColumnName("empTitle")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CountryID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeSystem.Application.Models.Employee", b =>
                {
                    b.HasOne("EmployeeSystem.Application.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
