using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpAppBlazor.Server.Migrations
{
    public partial class revert2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 5, 1, 15, 45, 59, 703, DateTimeKind.Local).AddTicks(9041), new DateTime(2022, 4, 23, 15, 45, 59, 703, DateTimeKind.Local).AddTicks(9081), new DateTime(2022, 6, 3, 15, 45, 59, 703, DateTimeKind.Local).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 12, 15, 45, 59, 703, DateTimeKind.Local).AddTicks(9084), new DateTime(2022, 6, 20, 15, 45, 59, 703, DateTimeKind.Local).AddTicks(9089), new DateTime(2022, 5, 14, 15, 45, 59, 703, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 30, 15, 45, 59, 703, DateTimeKind.Local).AddTicks(9091), new DateTime(2022, 4, 25, 15, 45, 59, 703, DateTimeKind.Local).AddTicks(9095), new DateTime(2022, 6, 13, 15, 45, 59, 703, DateTimeKind.Local).AddTicks(9093) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 5, 1, 15, 42, 31, 43, DateTimeKind.Local).AddTicks(9551), new DateTime(2022, 4, 23, 15, 42, 31, 43, DateTimeKind.Local).AddTicks(9599), new DateTime(2022, 6, 3, 15, 42, 31, 43, DateTimeKind.Local).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 12, 15, 42, 31, 43, DateTimeKind.Local).AddTicks(9602), new DateTime(2022, 6, 20, 15, 42, 31, 43, DateTimeKind.Local).AddTicks(9606), new DateTime(2022, 5, 14, 15, 42, 31, 43, DateTimeKind.Local).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 30, 15, 42, 31, 43, DateTimeKind.Local).AddTicks(9608), new DateTime(2022, 4, 25, 15, 42, 31, 43, DateTimeKind.Local).AddTicks(9612), new DateTime(2022, 6, 13, 15, 42, 31, 43, DateTimeKind.Local).AddTicks(9610) });
        }
    }
}
