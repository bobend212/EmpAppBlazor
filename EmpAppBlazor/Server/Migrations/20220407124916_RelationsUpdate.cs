using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpAppBlazor.Server.Migrations
{
    public partial class RelationsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Workloads_WorkloadId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_WorkloadId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "WorkloadId",
                table: "Projects");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Workloads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "ProjectId" },
                values: new object[] { new DateTime(2022, 7, 16, 14, 49, 16, 225, DateTimeKind.Local).AddTicks(3676), 1 });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "ProjectId" },
                values: new object[] { new DateTime(2022, 9, 4, 14, 49, 16, 225, DateTimeKind.Local).AddTicks(3712), 2 });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "ProjectId" },
                values: new object[] { new DateTime(2022, 10, 24, 14, 49, 16, 225, DateTimeKind.Local).AddTicks(3715), 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Workloads_ProjectId",
                table: "Workloads",
                column: "ProjectId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Workloads_Projects_ProjectId",
                table: "Workloads",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workloads_Projects_ProjectId",
                table: "Workloads");

            migrationBuilder.DropIndex(
                name: "IX_Workloads_ProjectId",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Workloads");

            migrationBuilder.AddColumn<int>(
                name: "WorkloadId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "WorkloadId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "WorkloadId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "WorkloadId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2022, 7, 16, 14, 43, 30, 169, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2022, 9, 4, 14, 43, 30, 169, DateTimeKind.Local).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2022, 10, 24, 14, 43, 30, 169, DateTimeKind.Local).AddTicks(9727));

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
    }
}
