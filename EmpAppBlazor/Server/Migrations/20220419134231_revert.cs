using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpAppBlazor.Server.Migrations
{
    public partial class revert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "OrderPlaced", "ProductionStage", "RequiredDate" },
                values: new object[] { new DateTime(2022, 5, 1, 15, 42, 31, 43, DateTimeKind.Local).AddTicks(9551), new DateTime(2022, 4, 23, 15, 42, 31, 43, DateTimeKind.Local).AddTicks(9599), "Not Started", new DateTime(2022, 6, 3, 15, 42, 31, 43, DateTimeKind.Local).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryDate", "OrderPlaced", "ProductionStage", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 12, 15, 42, 31, 43, DateTimeKind.Local).AddTicks(9602), new DateTime(2022, 6, 20, 15, 42, 31, 43, DateTimeKind.Local).AddTicks(9606), "Not Started", new DateTime(2022, 5, 14, 15, 42, 31, 43, DateTimeKind.Local).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryDate", "OrderPlaced", "ProductionStage", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 30, 15, 42, 31, 43, DateTimeKind.Local).AddTicks(9608), new DateTime(2022, 4, 25, 15, 42, 31, 43, DateTimeKind.Local).AddTicks(9612), "Not Started", new DateTime(2022, 6, 13, 15, 42, 31, 43, DateTimeKind.Local).AddTicks(9610) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "OrderPlaced", "ProductionStage", "RequiredDate" },
                values: new object[] { new DateTime(2022, 5, 1, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4790), new DateTime(2022, 4, 23, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4829), "not started", new DateTime(2022, 6, 3, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryDate", "OrderPlaced", "ProductionStage", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 12, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4831), new DateTime(2022, 6, 20, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4835), "not started", new DateTime(2022, 5, 14, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryDate", "OrderPlaced", "ProductionStage", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 30, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4838), new DateTime(2022, 4, 25, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4841), "not started", new DateTime(2022, 6, 13, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4840) });
        }
    }
}
