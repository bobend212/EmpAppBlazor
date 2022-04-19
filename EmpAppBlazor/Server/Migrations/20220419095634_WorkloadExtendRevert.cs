using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpAppBlazor.Server.Migrations
{
    public partial class WorkloadExtendRevert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTime(2022, 5, 1, 11, 56, 34, 240, DateTimeKind.Local).AddTicks(5397), new DateTime(2022, 4, 23, 11, 56, 34, 240, DateTimeKind.Local).AddTicks(5440), "not started", new DateTime(2022, 6, 3, 11, 56, 34, 240, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryDate", "OrderPlaced", "ProductionStage", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 12, 11, 56, 34, 240, DateTimeKind.Local).AddTicks(5443), new DateTime(2022, 6, 20, 11, 56, 34, 240, DateTimeKind.Local).AddTicks(5447), "not started", new DateTime(2022, 5, 14, 11, 56, 34, 240, DateTimeKind.Local).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryDate", "OrderPlaced", "ProductionStage", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 30, 11, 56, 34, 240, DateTimeKind.Local).AddTicks(5450), new DateTime(2022, 4, 25, 11, 56, 34, 240, DateTimeKind.Local).AddTicks(5453), "not started", new DateTime(2022, 6, 13, 11, 56, 34, 240, DateTimeKind.Local).AddTicks(5451) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
