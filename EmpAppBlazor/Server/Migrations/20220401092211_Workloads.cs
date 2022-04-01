using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpAppBlazor.Server.Migrations
{
    public partial class Workloads : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkloadId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Workloads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workloads", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Workloads",
                columns: new[] { "Id", "DueDate", "Stage" },
                values: new object[] { 1, new DateTime(2022, 7, 10, 11, 22, 10, 938, DateTimeKind.Local).AddTicks(7051), "active" });

            migrationBuilder.InsertData(
                table: "Workloads",
                columns: new[] { "Id", "DueDate", "Stage" },
                values: new object[] { 2, new DateTime(2022, 8, 29, 11, 22, 10, 938, DateTimeKind.Local).AddTicks(7092), "hold" });

            migrationBuilder.InsertData(
                table: "Workloads",
                columns: new[] { "Id", "DueDate", "Stage" },
                values: new object[] { 3, new DateTime(2022, 10, 18, 11, 22, 10, 938, DateTimeKind.Local).AddTicks(7094), "done" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "WorkloadId" },
                values: new object[] { new DateTime(2022, 4, 6, 11, 22, 10, 938, DateTimeKind.Local).AddTicks(7208), 1 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryDate", "WorkloadId" },
                values: new object[] { new DateTime(2022, 5, 6, 11, 22, 10, 938, DateTimeKind.Local).AddTicks(7213), 2 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryDate", "WorkloadId" },
                values: new object[] { new DateTime(2022, 4, 5, 11, 22, 10, 938, DateTimeKind.Local).AddTicks(7215), 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_WorkloadId",
                table: "Projects",
                column: "WorkloadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Workloads_WorkloadId",
                table: "Projects",
                column: "WorkloadId",
                principalTable: "Workloads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Workloads_WorkloadId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "Workloads");

            migrationBuilder.DropIndex(
                name: "IX_Projects_WorkloadId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "WorkloadId",
                table: "Projects");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "DeliveryDate",
                value: new DateTime(2022, 4, 4, 20, 18, 46, 83, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "DeliveryDate",
                value: new DateTime(2022, 5, 4, 20, 18, 46, 83, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "DeliveryDate",
                value: new DateTime(2022, 4, 3, 20, 18, 46, 83, DateTimeKind.Local).AddTicks(6011));
        }
    }
}
