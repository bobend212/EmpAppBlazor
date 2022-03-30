using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpAppBlazor.Server.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "DeliveryDate", "Description", "Name", "Number", "Site" },
                values: new object[] { 1, new DateTime(2022, 4, 4, 20, 18, 46, 83, DateTimeKind.Local).AddTicks(5969), "", "Tomason", 17156, "Self-Build" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "DeliveryDate", "Description", "Name", "Number", "Site" },
                values: new object[] { 2, new DateTime(2022, 5, 4, 20, 18, 46, 83, DateTimeKind.Local).AddTicks(6007), "", "Ellesar", 14104, "Self-Build" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "DeliveryDate", "Description", "Name", "Number", "Site" },
                values: new object[] { 3, new DateTime(2022, 4, 3, 20, 18, 46, 83, DateTimeKind.Local).AddTicks(6011), "This project is on hold now.", "Clark", 21201, "KTS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
