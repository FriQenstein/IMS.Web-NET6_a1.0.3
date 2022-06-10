using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Web.Data.Migrations
{
    public partial class addedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
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
                value: "096e2c19-cc6b-4a2f-8e4e-e527ba8ce21e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                column: "ConcurrencyStamp",
                value: "f0e668ec-94f4-4fd7-9409-6801d6e09b17");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1100acdc2-c69c-abba-bac2-d5f719ffffaa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc87eb21-b4a1-47b4-b022-f5796ee09c67", "AQAAAAEAACcQAAAAEInTvyY0s544BtwXfwA9wwttklPGkwjpFwnqmJWFKHuT2Z8a3VhT7jjRzysF7Z/whw==", "3eeb1559-0d72-4045-9dcf-c598ed8e6c42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c34ee49f-4b1b-4252-b990-af2424a311d4", "AQAAAAEAACcQAAAAEFMH+COrCGQPBLT/ru2ADJ6qAZR1q5464eWtMIWyoDdjU1rhTKRlO8eYYvxcstYEWQ==", "1d0d5972-7126-4291-b607-a16fb8768c29" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-aaaa-aaaa-aaaa-d5f719ffaaaa",
                column: "ConcurrencyStamp",
                value: "de0b6c14-c37e-4e07-98c0-d9cbcf89e919");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                column: "ConcurrencyStamp",
                value: "61df48c8-34d7-4ddb-a503-4a2e1ad29b99");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1100acdc2-c69c-abba-bac2-d5f719ffffaa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b17447ae-74f1-46da-ab26-ecf160bbda12", "AQAAAAEAACcQAAAAELwkNtIpi6qg2o33KnVLs4k5FpSQgIiLrMZwtMFRnmCDt65IEQCHCz6bXjZKkAlebw==", "0de361a6-e0d5-4f2f-bacb-4a1cb12ffc86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d6a3758-0e70-4086-bc75-adb547515fe3", "AQAAAAEAACcQAAAAEBcfk9wrcM/OOjQeGxpBrrql9kWyr8X9qXRv/8OgOpxAQm0FafQQcC2TfNyPhMNr0Q==", "4aec9967-fbe0-491e-8ce4-b4d6cd2903ff" });
        }
    }
}
