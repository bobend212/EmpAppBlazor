using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpAppBlazor.Server.Migrations
{
    public partial class UserEntityExtended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
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

            migrationBuilder.CreateIndex(
                name: "IX_TaskItems_AssignedToId",
                table: "TaskItems",
                column: "AssignedToId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_Users_AssignedToId",
                table: "TaskItems",
                column: "AssignedToId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_Users_AssignedToId",
                table: "TaskItems");

            migrationBuilder.DropIndex(
                name: "IX_TaskItems_AssignedToId",
                table: "TaskItems");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 4, 26, 14, 43, 50, 341, DateTimeKind.Local).AddTicks(1793), new DateTime(2022, 4, 18, 14, 43, 50, 341, DateTimeKind.Local).AddTicks(1837), new DateTime(2022, 5, 29, 14, 43, 50, 341, DateTimeKind.Local).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 7, 14, 43, 50, 341, DateTimeKind.Local).AddTicks(1840), new DateTime(2022, 6, 15, 14, 43, 50, 341, DateTimeKind.Local).AddTicks(1844), new DateTime(2022, 5, 9, 14, 43, 50, 341, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 25, 14, 43, 50, 341, DateTimeKind.Local).AddTicks(1847), new DateTime(2022, 4, 20, 14, 43, 50, 341, DateTimeKind.Local).AddTicks(1851), new DateTime(2022, 6, 8, 14, 43, 50, 341, DateTimeKind.Local).AddTicks(1849) });
        }
    }
}
