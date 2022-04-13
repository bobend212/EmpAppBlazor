using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpAppBlazor.Server.Migrations
{
    public partial class TasksEntityAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskItems",
                columns: table => new
                {
                    TaskItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedToId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    EditorId = table.Column<int>(type: "int", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaskStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Importance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateEdited = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItems", x => x.TaskItemId);
                });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 4, 25, 8, 57, 35, 20, DateTimeKind.Local).AddTicks(7983), new DateTime(2022, 4, 17, 8, 57, 35, 20, DateTimeKind.Local).AddTicks(8026), new DateTime(2022, 5, 28, 8, 57, 35, 20, DateTimeKind.Local).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 6, 8, 57, 35, 20, DateTimeKind.Local).AddTicks(8029), new DateTime(2022, 6, 14, 8, 57, 35, 20, DateTimeKind.Local).AddTicks(8034), new DateTime(2022, 5, 8, 8, 57, 35, 20, DateTimeKind.Local).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 24, 8, 57, 35, 20, DateTimeKind.Local).AddTicks(8037), new DateTime(2022, 4, 19, 8, 57, 35, 20, DateTimeKind.Local).AddTicks(8041), new DateTime(2022, 6, 7, 8, 57, 35, 20, DateTimeKind.Local).AddTicks(8039) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskItems");

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 4, 20, 9, 32, 21, 265, DateTimeKind.Local).AddTicks(2083), new DateTime(2022, 4, 12, 9, 32, 21, 265, DateTimeKind.Local).AddTicks(2126), new DateTime(2022, 5, 23, 9, 32, 21, 265, DateTimeKind.Local).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 1, 9, 32, 21, 265, DateTimeKind.Local).AddTicks(2129), new DateTime(2022, 6, 9, 9, 32, 21, 265, DateTimeKind.Local).AddTicks(2133), new DateTime(2022, 5, 3, 9, 32, 21, 265, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 19, 9, 32, 21, 265, DateTimeKind.Local).AddTicks(2135), new DateTime(2022, 4, 14, 9, 32, 21, 265, DateTimeKind.Local).AddTicks(2139), new DateTime(2022, 6, 2, 9, 32, 21, 265, DateTimeKind.Local).AddTicks(2137) });
        }
    }
}
