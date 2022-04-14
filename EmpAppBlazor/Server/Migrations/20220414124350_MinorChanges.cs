using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpAppBlazor.Server.Migrations
{
    public partial class MinorChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.CreateIndex(
                name: "IX_TaskItems_ProjectId",
                table: "TaskItems",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_Projects_ProjectId",
                table: "TaskItems",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_Projects_ProjectId",
                table: "TaskItems");

            migrationBuilder.DropIndex(
                name: "IX_TaskItems_ProjectId",
                table: "TaskItems");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
