using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Web.Data.Migrations
{
    public partial class addedDefaultUsersandRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "36bfcd2c-aaaa-aaaa-aaaa-d5f719ffaaaa", "de78c3aa-0918-4a5d-83a3-c446c768c887", "User", "USER" },
                    { "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec", "58a59b83-533e-48b6-9ee7-1067e2ce1802", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1100acdc2-c69c-abba-bac2-d5f719ffffaa", 0, "2a856fd1-2824-4238-a99d-4245bdaa01c9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEC84Vn1W7SOf7ikKcAP7SH3IBymFUuKvCUIlq6UZflQlQ2wqvkPf/5rNHzzuUaqXtw==", null, false, "1a764430-9ae4-4344-9b67-b2fdccd498a9", false, null },
                    { "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec", 0, "adf3d30e-7a85-4234-9feb-d42ce0913461", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAED2R46pma4XiCr92hlJR7mps8JGsgVEPKU3m/fqRDF9QrTIcUbD3VCQvP/DTJBCzDg==", null, false, "c7a5be34-8fda-49f7-91f3-9a42c1b5081e", false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "36bfcd2c-aaaa-aaaa-aaaa-d5f719ffaaaa", "1100acdc2-c69c-abba-bac2-d5f719ffffaa" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec", "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "36bfcd2c-aaaa-aaaa-aaaa-d5f719ffaaaa", "1100acdc2-c69c-abba-bac2-d5f719ffffaa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec", "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-aaaa-aaaa-aaaa-d5f719ffaaaa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1100acdc2-c69c-abba-bac2-d5f719ffffaa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec");
        }
    }
}
