﻿// <auto-generated />
using System;
using EmpAppBlazor.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmpAppBlazor.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmpAppBlazor.Shared.Auth.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EmpAppBlazor.Shared.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Site")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkloadId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkloadId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DeliveryDate = new DateTime(2022, 4, 11, 9, 48, 39, 86, DateTimeKind.Local).AddTicks(6511),
                            Description = "",
                            Name = "Tomason",
                            Number = 17156,
                            Site = "Self-Build",
                            WorkloadId = 1
                        },
                        new
                        {
                            Id = 2,
                            DeliveryDate = new DateTime(2022, 5, 11, 9, 48, 39, 86, DateTimeKind.Local).AddTicks(6515),
                            Description = "",
                            Name = "Ellesar",
                            Number = 14104,
                            Site = "Self-Build",
                            WorkloadId = 2
                        },
                        new
                        {
                            Id = 3,
                            DeliveryDate = new DateTime(2022, 4, 10, 9, 48, 39, 86, DateTimeKind.Local).AddTicks(6518),
                            Description = "This project is on hold now.",
                            Name = "Clark",
                            Number = 21201,
                            Site = "KTS",
                            WorkloadId = 3
                        });
                });

            modelBuilder.Entity("EmpAppBlazor.Shared.Workload", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Stage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Workloads");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DueDate = new DateTime(2022, 7, 15, 9, 48, 39, 86, DateTimeKind.Local).AddTicks(6348),
                            Stage = "active"
                        },
                        new
                        {
                            Id = 2,
                            DueDate = new DateTime(2022, 9, 3, 9, 48, 39, 86, DateTimeKind.Local).AddTicks(6388),
                            Stage = "hold"
                        },
                        new
                        {
                            Id = 3,
                            DueDate = new DateTime(2022, 10, 23, 9, 48, 39, 86, DateTimeKind.Local).AddTicks(6391),
                            Stage = "done"
                        });
                });

            modelBuilder.Entity("EmpAppBlazor.Shared.Project", b =>
                {
                    b.HasOne("EmpAppBlazor.Shared.Workload", "Workload")
                        .WithMany()
                        .HasForeignKey("WorkloadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Workload");
                });
#pragma warning restore 612, 618
        }
    }
}
