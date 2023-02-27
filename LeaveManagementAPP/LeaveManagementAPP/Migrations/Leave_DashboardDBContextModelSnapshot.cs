﻿// <auto-generated />
using System;
using LeaveManagementAPP.ModelView;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LeaveManagementAPP.Migrations
{
    [DbContext(typeof(Leave_DashboardDBContext))]
    partial class Leave_DashboardDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LeaveManagementAPP.model.Employee_Manage", b =>
                {
                    b.Property<int>("Emp_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Emp_ID"));

                    b.Property<string>("Emp_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emp_Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emp_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emp_Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Emp_ID");

                    b.ToTable("Employee_Manages");
                });

            modelBuilder.Entity("LeaveManagementAPP.model.Leave_Dashboard", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Leave_Dashboard");
                });
#pragma warning restore 612, 618
        }
    }
}
