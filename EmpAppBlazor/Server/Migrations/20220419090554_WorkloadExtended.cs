using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpAppBlazor.Server.Migrations
{
    public partial class WorkloadExtended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LeaderId",
                table: "Workloads",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "OrderPlaced", "ProductionStage", "RequiredDate" },
                values: new object[] { new DateTime(2022, 5, 1, 11, 5, 54, 276, DateTimeKind.Local).AddTicks(7549), new DateTime(2022, 4, 23, 11, 5, 54, 276, DateTimeKind.Local).AddTicks(7588), "Not Started", new DateTime(2022, 6, 3, 11, 5, 54, 276, DateTimeKind.Local).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryDate", "OrderPlaced", "ProductionStage", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 12, 11, 5, 54, 276, DateTimeKind.Local).AddTicks(7591), new DateTime(2022, 6, 20, 11, 5, 54, 276, DateTimeKind.Local).AddTicks(7598), "Not Started", new DateTime(2022, 5, 14, 11, 5, 54, 276, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryDate", "OrderPlaced", "ProductionStage", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 30, 11, 5, 54, 276, DateTimeKind.Local).AddTicks(7600), new DateTime(2022, 4, 25, 11, 5, 54, 276, DateTimeKind.Local).AddTicks(7605), "Not Started", new DateTime(2022, 6, 13, 11, 5, 54, 276, DateTimeKind.Local).AddTicks(7603) });

            migrationBuilder.CreateIndex(
                name: "IX_Workloads_LeaderId",
                table: "Workloads",
                column: "LeaderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workloads_Users_LeaderId",
                table: "Workloads",
                column: "LeaderId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workloads_Users_LeaderId",
                table: "Workloads");

            migrationBuilder.DropIndex(
                name: "IX_Workloads_LeaderId",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "LeaderId",
                table: "Workloads");

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "OrderPlaced", "ProductionStage", "RequiredDate" },
                values: new object[] { new DateTime(2022, 4, 27, 14, 37, 54, 207, DateTimeKind.Local).AddTicks(1317), new DateTime(2022, 4, 19, 14, 37, 54, 207, DateTimeKind.Local).AddTicks(1363), "not started", new DateTime(2022, 5, 30, 14, 37, 54, 207, DateTimeKind.Local).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryDate", "OrderPlaced", "ProductionStage", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 8, 14, 37, 54, 207, DateTimeKind.Local).AddTicks(1368), new DateTime(2022, 6, 16, 14, 37, 54, 207, DateTimeKind.Local).AddTicks(1376), "not started", new DateTime(2022, 5, 10, 14, 37, 54, 207, DateTimeKind.Local).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryDate", "OrderPlaced", "ProductionStage", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 26, 14, 37, 54, 207, DateTimeKind.Local).AddTicks(1380), new DateTime(2022, 4, 21, 14, 37, 54, 207, DateTimeKind.Local).AddTicks(1388), "not started", new DateTime(2022, 6, 9, 14, 37, 54, 207, DateTimeKind.Local).AddTicks(1384) });
        }
    }
}
