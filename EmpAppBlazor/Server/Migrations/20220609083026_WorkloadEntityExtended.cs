using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpAppBlazor.Server.Migrations
{
    public partial class WorkloadEntityExtended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Workloads",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "RequiredDate",
                table: "Workloads",
                newName: "SlabRequired");

            migrationBuilder.AddColumn<DateTime>(
                name: "BregsEstimated",
                table: "Workloads",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BregsIssued",
                table: "Workloads",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BregsRequired",
                table: "Workloads",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BregsStage",
                table: "Workloads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Workloads",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DesignInfo",
                table: "Workloads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "DrawingsReceived",
                table: "Workloads",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EngReceived",
                table: "Workloads",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "EstimDesignTime",
                table: "Workloads",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FullSetEstimated",
                table: "Workloads",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FullSetIssued",
                table: "Workloads",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FullSetRequired",
                table: "Workloads",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Issued",
                table: "Workloads",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "IssuingEstimated",
                table: "Workloads",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "IssuingIssued",
                table: "Workloads",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "IssuingRequired",
                table: "Workloads",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Planner",
                table: "Workloads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProjectType",
                table: "Workloads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "SlabEstimated",
                table: "Workloads",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SlabIssued",
                table: "Workloads",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SlabnStage",
                table: "Workloads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BregsEstimated",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "BregsIssued",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "BregsRequired",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "BregsStage",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "DesignInfo",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "DrawingsReceived",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "EngReceived",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "EstimDesignTime",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "FullSetEstimated",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "FullSetIssued",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "FullSetRequired",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "Issued",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "IssuingEstimated",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "IssuingIssued",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "IssuingRequired",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "Planner",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "ProjectType",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "SlabEstimated",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "SlabIssued",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "SlabnStage",
                table: "Workloads");

            migrationBuilder.RenameColumn(
                name: "SlabRequired",
                table: "Workloads",
                newName: "RequiredDate");

            migrationBuilder.InsertData(
                table: "Workloads",
                columns: new[] { "Id", "Comments", "DeliveryDate", "DesignLeaderId", "EditorId", "LastUpdate", "OrderPlaced", "ProductionStage", "ProjectId", "RequiredDate" },
                values: new object[] { 1, "", new DateTime(2022, 5, 10, 11, 22, 2, 271, DateTimeKind.Local).AddTicks(7598), null, null, null, new DateTime(2022, 5, 2, 11, 22, 2, 271, DateTimeKind.Local).AddTicks(7639), "Not Started", 1, new DateTime(2022, 6, 12, 11, 22, 2, 271, DateTimeKind.Local).AddTicks(7637) });

            migrationBuilder.InsertData(
                table: "Workloads",
                columns: new[] { "Id", "Comments", "DeliveryDate", "DesignLeaderId", "EditorId", "LastUpdate", "OrderPlaced", "ProductionStage", "ProjectId", "RequiredDate" },
                values: new object[] { 2, "", new DateTime(2022, 6, 21, 11, 22, 2, 271, DateTimeKind.Local).AddTicks(7641), null, null, null, new DateTime(2022, 6, 29, 11, 22, 2, 271, DateTimeKind.Local).AddTicks(7645), "Not Started", 2, new DateTime(2022, 5, 23, 11, 22, 2, 271, DateTimeKind.Local).AddTicks(7644) });

            migrationBuilder.InsertData(
                table: "Workloads",
                columns: new[] { "Id", "Comments", "DeliveryDate", "DesignLeaderId", "EditorId", "LastUpdate", "OrderPlaced", "ProductionStage", "ProjectId", "RequiredDate" },
                values: new object[] { 3, "", new DateTime(2022, 7, 9, 11, 22, 2, 271, DateTimeKind.Local).AddTicks(7648), null, null, null, new DateTime(2022, 5, 4, 11, 22, 2, 271, DateTimeKind.Local).AddTicks(7651), "Not Started", 3, new DateTime(2022, 6, 22, 11, 22, 2, 271, DateTimeKind.Local).AddTicks(7649) });
        }
    }
}
