using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpAppBlazor.Server.Migrations
{
    public partial class WorkloadUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "Workloads");

            migrationBuilder.RenameColumn(
                name: "Stage",
                table: "Workloads",
                newName: "ProductionStage");

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Workloads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryDate",
                table: "Workloads",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderPlaced",
                table: "Workloads",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RequiredDate",
                table: "Workloads",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comments", "DeliveryDate", "OrderPlaced", "ProductionStage", "RequiredDate" },
                values: new object[] { "", new DateTime(2022, 4, 20, 9, 32, 21, 265, DateTimeKind.Local).AddTicks(2083), new DateTime(2022, 4, 12, 9, 32, 21, 265, DateTimeKind.Local).AddTicks(2126), "not started", new DateTime(2022, 5, 23, 9, 32, 21, 265, DateTimeKind.Local).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Comments", "DeliveryDate", "OrderPlaced", "ProductionStage", "RequiredDate" },
                values: new object[] { "", new DateTime(2022, 6, 1, 9, 32, 21, 265, DateTimeKind.Local).AddTicks(2129), new DateTime(2022, 6, 9, 9, 32, 21, 265, DateTimeKind.Local).AddTicks(2133), "not started", new DateTime(2022, 5, 3, 9, 32, 21, 265, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Comments", "DeliveryDate", "OrderPlaced", "ProductionStage", "RequiredDate" },
                values: new object[] { "", new DateTime(2022, 6, 19, 9, 32, 21, 265, DateTimeKind.Local).AddTicks(2135), new DateTime(2022, 4, 14, 9, 32, 21, 265, DateTimeKind.Local).AddTicks(2139), "not started", new DateTime(2022, 6, 2, 9, 32, 21, 265, DateTimeKind.Local).AddTicks(2137) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "OrderPlaced",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "RequiredDate",
                table: "Workloads");

            migrationBuilder.RenameColumn(
                name: "ProductionStage",
                table: "Workloads",
                newName: "Stage");

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "Workloads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "Stage" },
                values: new object[] { new DateTime(2022, 7, 17, 9, 17, 44, 568, DateTimeKind.Local).AddTicks(9946), "active" });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "Stage" },
                values: new object[] { new DateTime(2022, 9, 5, 9, 17, 44, 568, DateTimeKind.Local).AddTicks(9980), "hold" });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "Stage" },
                values: new object[] { new DateTime(2022, 10, 25, 9, 17, 44, 568, DateTimeKind.Local).AddTicks(9982), "done" });
        }
    }
}
