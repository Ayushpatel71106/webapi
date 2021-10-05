﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApIAngular.model;

namespace WebApIAngular.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApIAngular.model.Employees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<decimal>("Salary");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WebApIAngular.model.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateOn");

                    b.Property<string>("Email");

                    b.Property<string>("Fname");

                    b.Property<string>("Gender");

                    b.Property<string>("Image");

                    b.Property<string>("Lname");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
