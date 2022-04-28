using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpAppBlazor.Server.Migrations
{
    public partial class TaskItemEntityUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_Users_AssignedToId",
                table: "TaskItems");

            migrationBuilder.AlterColumn<int>(
                name: "AssignedToId",
                table: "TaskItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 22, 2, 271, DateTimeKind.Local).AddTicks(7598), new DateTime(2022, 5, 2, 11, 22, 2, 271, DateTimeKind.Local).AddTicks(7639), new DateTime(2022, 6, 12, 11, 22, 2, 271, DateTimeKind.Local).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 21, 11, 22, 2, 271, DateTimeKind.Local).AddTicks(7641), new DateTime(2022, 6, 29, 11, 22, 2, 271, DateTimeKind.Local).AddTicks(7645), new DateTime(2022, 5, 23, 11, 22, 2, 271, DateTimeKind.Local).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 7, 9, 11, 22, 2, 271, DateTimeKind.Local).AddTicks(7648), new DateTime(2022, 5, 4, 11, 22, 2, 271, DateTimeKind.Local).AddTicks(7651), new DateTime(2022, 6, 22, 11, 22, 2, 271, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.CreateIndex(
                name: "IX_TaskItems_AuthorId",
                table: "TaskItems",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskItems_EditorId",
                table: "TaskItems",
                column: "EditorId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_Users_AssignedToId",
                table: "TaskItems",
                column: "AssignedToId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_Users_AuthorId",
                table: "TaskItems",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_Users_EditorId",
                table: "TaskItems",
                column: "EditorId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_Users_AssignedToId",
                table: "TaskItems");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_Users_AuthorId",
                table: "TaskItems");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_Users_EditorId",
                table: "TaskItems");

            migrationBuilder.DropIndex(
                name: "IX_TaskItems_AuthorId",
                table: "TaskItems");

            migrationBuilder.DropIndex(
                name: "IX_TaskItems_EditorId",
                table: "TaskItems");

            migrationBuilder.AlterColumn<int>(
                name: "AssignedToId",
                table: "TaskItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_Users_AssignedToId",
                table: "TaskItems",
                column: "AssignedToId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
