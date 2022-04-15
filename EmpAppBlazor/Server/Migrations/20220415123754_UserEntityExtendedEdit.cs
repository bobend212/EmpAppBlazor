using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpAppBlazor.Server.Migrations
{
    public partial class UserEntityExtendedEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 4, 27, 14, 37, 54, 207, DateTimeKind.Local).AddTicks(1317), new DateTime(2022, 4, 19, 14, 37, 54, 207, DateTimeKind.Local).AddTicks(1363), new DateTime(2022, 5, 30, 14, 37, 54, 207, DateTimeKind.Local).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 8, 14, 37, 54, 207, DateTimeKind.Local).AddTicks(1368), new DateTime(2022, 6, 16, 14, 37, 54, 207, DateTimeKind.Local).AddTicks(1376), new DateTime(2022, 5, 10, 14, 37, 54, 207, DateTimeKind.Local).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 26, 14, 37, 54, 207, DateTimeKind.Local).AddTicks(1380), new DateTime(2022, 4, 21, 14, 37, 54, 207, DateTimeKind.Local).AddTicks(1388), new DateTime(2022, 6, 9, 14, 37, 54, 207, DateTimeKind.Local).AddTicks(1384) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 4, 27, 14, 34, 11, 117, DateTimeKind.Local).AddTicks(703), new DateTime(2022, 4, 19, 14, 34, 11, 117, DateTimeKind.Local).AddTicks(748), new DateTime(2022, 5, 30, 14, 34, 11, 117, DateTimeKind.Local).AddTicks(746) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 8, 14, 34, 11, 117, DateTimeKind.Local).AddTicks(751), new DateTime(2022, 6, 16, 14, 34, 11, 117, DateTimeKind.Local).AddTicks(756), new DateTime(2022, 5, 10, 14, 34, 11, 117, DateTimeKind.Local).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 26, 14, 34, 11, 117, DateTimeKind.Local).AddTicks(759), new DateTime(2022, 4, 21, 14, 34, 11, 117, DateTimeKind.Local).AddTicks(763), new DateTime(2022, 6, 9, 14, 34, 11, 117, DateTimeKind.Local).AddTicks(761) });
        }
    }
}
