﻿// <auto-generated />
using System;
using EmpAppBlazor.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmpAppBlazor.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220419104838_WorkloadExtended2")]
    partial class WorkloadExtended2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
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

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EmpAppBlazor.Shared.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Site")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Tomason",
                            Number = 17156,
                            Site = "Self-Build",
                            Status = ""
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ellesar",
                            Number = 14104,
                            Site = "Self-Build",
                            Status = ""
                        },
                        new
                        {
                            Id = 3,
                            Name = "Clark",
                            Number = 21201,
                            Site = "KTS",
                            Status = ""
                        });
                });

            modelBuilder.Entity("EmpAppBlazor.Shared.TaskItem", b =>
                {
                    b.Property<int>("TaskItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaskItemId"), 1L, 1);

                    b.Property<int>("AssignedToId")
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateEdited")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EditorId")
                        .HasColumnType("int");

                    b.Property<string>("Importance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("TaskStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaskItemId");

                    b.HasIndex("AssignedToId");

                    b.HasIndex("ProjectId");

                    b.ToTable("TaskItems");
                });

            modelBuilder.Entity("EmpAppBlazor.Shared.Workload", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DesignLeaderId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductionStage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RequiredDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DesignLeaderId");

                    b.HasIndex("ProjectId")
                        .IsUnique();

                    b.ToTable("Workloads");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comments = "",
                            DeliveryDate = new DateTime(2022, 5, 1, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4790),
                            OrderPlaced = new DateTime(2022, 4, 23, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4829),
                            ProductionStage = "not started",
                            ProjectId = 1,
                            RequiredDate = new DateTime(2022, 6, 3, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4827)
                        },
                        new
                        {
                            Id = 2,
                            Comments = "",
                            DeliveryDate = new DateTime(2022, 6, 12, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4831),
                            OrderPlaced = new DateTime(2022, 6, 20, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4835),
                            ProductionStage = "not started",
                            ProjectId = 2,
                            RequiredDate = new DateTime(2022, 5, 14, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4833)
                        },
                        new
                        {
                            Id = 3,
                            Comments = "",
                            DeliveryDate = new DateTime(2022, 6, 30, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4838),
                            OrderPlaced = new DateTime(2022, 4, 25, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4841),
                            ProductionStage = "not started",
                            ProjectId = 3,
                            RequiredDate = new DateTime(2022, 6, 13, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4840)
                        });
                });

            modelBuilder.Entity("ProjectUser", b =>
                {
                    b.Property<int>("DesignersId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectsId")
                        .HasColumnType("int");

                    b.HasKey("DesignersId", "ProjectsId");

                    b.HasIndex("ProjectsId");

                    b.ToTable("ProjectUser");
                });

            modelBuilder.Entity("EmpAppBlazor.Shared.TaskItem", b =>
                {
                    b.HasOne("EmpAppBlazor.Shared.Auth.User", "AssignedTo")
                        .WithMany()
                        .HasForeignKey("AssignedToId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmpAppBlazor.Shared.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");

                    b.Navigation("AssignedTo");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("EmpAppBlazor.Shared.Workload", b =>
                {
                    b.HasOne("EmpAppBlazor.Shared.Auth.User", "DesignLeader")
                        .WithMany()
                        .HasForeignKey("DesignLeaderId");

                    b.HasOne("EmpAppBlazor.Shared.Project", "Project")
                        .WithOne("Workload")
                        .HasForeignKey("EmpAppBlazor.Shared.Workload", "ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DesignLeader");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("ProjectUser", b =>
                {
                    b.HasOne("EmpAppBlazor.Shared.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("DesignersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmpAppBlazor.Shared.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmpAppBlazor.Shared.Project", b =>
                {
                    b.Navigation("Workload");
                });
#pragma warning restore 612, 618
        }
    }
}
