using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpAppBlazor.Server.Migrations
{
    public partial class WorkloadEntityExtendedUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SlabnStage",
                table: "Workloads",
                newName: "SlabStage");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Workloads",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Workloads_AuthorId",
                table: "Workloads",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workloads_Users_AuthorId",
                table: "Workloads",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workloads_Users_AuthorId",
                table: "Workloads");

            migrationBuilder.DropIndex(
                name: "IX_Workloads_AuthorId",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Workloads");

            migrationBuilder.RenameColumn(
                name: "SlabStage",
                table: "Workloads",
                newName: "SlabnStage");
        }
    }
}
