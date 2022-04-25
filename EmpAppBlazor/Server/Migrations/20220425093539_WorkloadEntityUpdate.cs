using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpAppBlazor.Server.Migrations
{
    public partial class WorkloadEntityUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EditorId",
                table: "Workloads",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdate",
                table: "Workloads",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 5, 7, 11, 35, 39, 471, DateTimeKind.Local).AddTicks(287), new DateTime(2022, 4, 29, 11, 35, 39, 471, DateTimeKind.Local).AddTicks(329), new DateTime(2022, 6, 9, 11, 35, 39, 471, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 18, 11, 35, 39, 471, DateTimeKind.Local).AddTicks(332), new DateTime(2022, 6, 26, 11, 35, 39, 471, DateTimeKind.Local).AddTicks(337), new DateTime(2022, 5, 20, 11, 35, 39, 471, DateTimeKind.Local).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 7, 6, 11, 35, 39, 471, DateTimeKind.Local).AddTicks(339), new DateTime(2022, 5, 1, 11, 35, 39, 471, DateTimeKind.Local).AddTicks(343), new DateTime(2022, 6, 19, 11, 35, 39, 471, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.CreateIndex(
                name: "IX_Workloads_EditorId",
                table: "Workloads",
                column: "EditorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workloads_Users_EditorId",
                table: "Workloads",
                column: "EditorId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workloads_Users_EditorId",
                table: "Workloads");

            migrationBuilder.DropIndex(
                name: "IX_Workloads_EditorId",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "EditorId",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "Workloads");

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 5, 3, 13, 14, 1, 354, DateTimeKind.Local).AddTicks(5590), new DateTime(2022, 4, 25, 13, 14, 1, 354, DateTimeKind.Local).AddTicks(5646), new DateTime(2022, 6, 5, 13, 14, 1, 354, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 14, 13, 14, 1, 354, DateTimeKind.Local).AddTicks(5651), new DateTime(2022, 6, 22, 13, 14, 1, 354, DateTimeKind.Local).AddTicks(5666), new DateTime(2022, 5, 16, 13, 14, 1, 354, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 7, 2, 13, 14, 1, 354, DateTimeKind.Local).AddTicks(5676), new DateTime(2022, 4, 27, 13, 14, 1, 354, DateTimeKind.Local).AddTicks(5688), new DateTime(2022, 6, 15, 13, 14, 1, 354, DateTimeKind.Local).AddTicks(5680) });
        }
    }
}
