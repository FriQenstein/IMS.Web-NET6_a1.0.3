using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Web.Data.Migrations
{
    public partial class addedLeaveTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultDays = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveAllocation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfDays = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveAllocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveAllocation_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-aaaa-aaaa-aaaa-d5f719ffaaaa",
                column: "ConcurrencyStamp",
                value: "7686afe8-cc28-4592-b3c4-0095a760ee6f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                column: "ConcurrencyStamp",
                value: "0a0f2c08-87c3-4dbb-a966-fa4d988a96e2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1100acdc2-c69c-abba-bac2-d5f719ffffaa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24f9c01c-c792-4216-ad82-72d92528ff5e", "AQAAAAEAACcQAAAAEBTUBcwLtRXIYAgWej+aTltbBMpNSvYg371lybwpUoCc6QITeYiNDliS1cGEsrSq2g==", "1a152257-9f69-43da-8a75-8d4dede2b04a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fffe2a65-aa3e-4858-9a6c-533789208bef", "AQAAAAEAACcQAAAAEDBThpYmxGwRtjkKeammusgBE+pMaDMfeM8oVITo4xfGPuKB9p1QUapbwQN5KTC8Yg==", "08a75aee-17e5-416a-959b-d868b7d34f62" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocation_LeaveTypeId",
                table: "LeaveAllocation",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveAllocation");

            migrationBuilder.DropTable(
                name: "LeaveTypes");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-aaaa-aaaa-aaaa-d5f719ffaaaa",
                column: "ConcurrencyStamp",
                value: "f9059467-cfd8-400d-ac19-4dea9fec5cbc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                column: "ConcurrencyStamp",
                value: "2049921a-caba-4893-88c9-1bd751bb2f44");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1100acdc2-c69c-abba-bac2-d5f719ffffaa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b59e7f0c-7c9b-4983-af28-19d4e08c1151", "AQAAAAEAACcQAAAAEHtw5GiDmtFryMxnQP1+FZif7DekkW9fJRY5XtvYc/NxNGIPQFYbFtruR00M5TnxOw==", "a3f1ee6e-30aa-442a-8b4e-648feb259342" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6332c6f-a7dc-4ac0-94e3-85f14bf8cb3c", "AQAAAAEAACcQAAAAEG/awasRfo1Remido2ArS1vudaXreEOXAggKv4L9TuVWlnxDE+aSEvZONbLYDkRh1g==", "096ab0f9-4aa1-4a72-9a78-7652ac240ee0" });
        }
    }
}
