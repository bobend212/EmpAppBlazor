using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpAppBlazor.Server.Migrations
{
    public partial class AddUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "DeliveryDate",
                value: new DateTime(2022, 4, 9, 13, 27, 33, 442, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "DeliveryDate",
                value: new DateTime(2022, 5, 9, 13, 27, 33, 442, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "DeliveryDate",
                value: new DateTime(2022, 4, 8, 13, 27, 33, 442, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2022, 7, 13, 13, 27, 33, 442, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2022, 9, 1, 13, 27, 33, 442, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2022, 10, 21, 13, 27, 33, 442, DateTimeKind.Local).AddTicks(8866));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "DeliveryDate",
                value: new DateTime(2022, 4, 6, 11, 22, 10, 938, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "DeliveryDate",
                value: new DateTime(2022, 5, 6, 11, 22, 10, 938, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "DeliveryDate",
                value: new DateTime(2022, 4, 5, 11, 22, 10, 938, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2022, 7, 10, 11, 22, 10, 938, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2022, 8, 29, 11, 22, 10, 938, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2022, 10, 18, 11, 22, 10, 938, DateTimeKind.Local).AddTicks(7094));
        }
    }
}
