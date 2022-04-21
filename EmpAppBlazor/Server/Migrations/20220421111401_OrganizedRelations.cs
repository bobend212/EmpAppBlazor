using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpAppBlazor.Server.Migrations
{
    public partial class OrganizedRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectUser");

            migrationBuilder.CreateTable(
                name: "UserProjects",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProjects", x => new { x.UserId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_UserProjects_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProjects_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserProjects_ProjectId",
                table: "UserProjects",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProjects");

            migrationBuilder.CreateTable(
                name: "ProjectUser",
                columns: table => new
                {
                    DesignersId = table.Column<int>(type: "int", nullable: false),
                    ProjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectUser", x => new { x.DesignersId, x.ProjectsId });
                    table.ForeignKey(
                        name: "FK_ProjectUser_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectUser_Users_DesignersId",
                        column: x => x.DesignersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 5, 1, 15, 45, 59, 703, DateTimeKind.Local).AddTicks(9041), new DateTime(2022, 4, 23, 15, 45, 59, 703, DateTimeKind.Local).AddTicks(9081), new DateTime(2022, 6, 3, 15, 45, 59, 703, DateTimeKind.Local).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 12, 15, 45, 59, 703, DateTimeKind.Local).AddTicks(9084), new DateTime(2022, 6, 20, 15, 45, 59, 703, DateTimeKind.Local).AddTicks(9089), new DateTime(2022, 5, 14, 15, 45, 59, 703, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryDate", "OrderPlaced", "RequiredDate" },
                values: new object[] { new DateTime(2022, 6, 30, 15, 45, 59, 703, DateTimeKind.Local).AddTicks(9091), new DateTime(2022, 4, 25, 15, 45, 59, 703, DateTimeKind.Local).AddTicks(9095), new DateTime(2022, 6, 13, 15, 45, 59, 703, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_ProjectsId",
                table: "ProjectUser",
                column: "ProjectsId");
        }
    }
}
