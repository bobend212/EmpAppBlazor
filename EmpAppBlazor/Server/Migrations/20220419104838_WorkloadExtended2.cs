using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpAppBlazor.Server.Migrations
{
    public partial class WorkloadExtended2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DesignLeaderId",
                table: "Workloads",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 5, 1, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4790), new DateTime(2022, 4, 23, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4829), new DateTime(2022, 6, 3, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 12, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4831), new DateTime(2022, 6, 20, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4835), new DateTime(2022, 5, 14, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 30, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4838), new DateTime(2022, 4, 25, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4841), new DateTime(2022, 6, 13, 12, 48, 37, 840, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.CreateIndex(
                name: "IX_Workloads_DesignLeaderId",
                table: "Workloads",
                column: "DesignLeaderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workloads_Users_DesignLeaderId",
                table: "Workloads",
                column: "DesignLeaderId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workloads_Users_DesignLeaderId",
                table: "Workloads");

            migrationBuilder.DropIndex(
                name: "IX_Workloads_DesignLeaderId",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "DesignLeaderId",
                table: "Workloads");

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 5, 1, 11, 56, 34, 240, DateTimeKind.Local).AddTicks(5397), new DateTime(2022, 4, 23, 11, 56, 34, 240, DateTimeKind.Local).AddTicks(5440), new DateTime(2022, 6, 3, 11, 56, 34, 240, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 12, 11, 56, 34, 240, DateTimeKind.Local).AddTicks(5443), new DateTime(2022, 6, 20, 11, 56, 34, 240, DateTimeKind.Local).AddTicks(5447), new DateTime(2022, 5, 14, 11, 56, 34, 240, DateTimeKind.Local).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 30, 11, 56, 34, 240, DateTimeKind.Local).AddTicks(5450), new DateTime(2022, 4, 25, 11, 56, 34, 240, DateTimeKind.Local).AddTicks(5453), new DateTime(2022, 6, 13, 11, 56, 34, 240, DateTimeKind.Local).AddTicks(5451) });
        }
    }
}
